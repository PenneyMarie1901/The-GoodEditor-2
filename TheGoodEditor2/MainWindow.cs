using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGoodEditor2.EditorWindows;
using TheGoodEditor2.AboutAssets;
using TheGoodEditor2.EditorWindows.Randomizer;
using TheGoodEditor2.Sections;
using HiHoFile;
using static HiHoFile.Extensions;
using System.Globalization;
using libWiiSharp;
using System.Drawing.Imaging;
using TheGoodEditor2.EditorWindows.TextureEditors;

namespace TheGoodEditor2
{
    public partial class MainWindow : Form
    {

        public MainWindow()

        {
            InitializeComponent();
        }

        public void label6_Click(object sender, EventArgs e)
        {

        }
        private void FillLayerListBox()
        {
            label4.Text = "File: " + fileName;
            listBoxLayers.Items.Clear();
            foreach (var layer in hoFile.MAST.sectionSect2.layers)
                listBoxLayers.Items.Add(layer.layerType.Replace("\0", ""));
        }
        private void listBoxLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAssets.BeginUpdate();
            listBoxAssets.Items.Clear();
            if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
            {
                if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                {
                    foreach (var asset in psl.assets)
                    {
                        string type;
                        if (Enum.IsDefined(typeof(AssetTypeHashed), asset.assetType))
                            type = ((AssetTypeHashed)asset.assetType).ToString();
                        else
                            type = asset.assetType.ToString("X8");

                        string name = $"[{type}] [{asset.assetID.ToString("X16")}]";
                        listBoxAssets.Items.Add(name);
                    }
                }
            }
            listBoxAssets.EndUpdate();
            listBoxAssets_SelectedIndexChanged(sender, e);
        }
        HoFile hoFile;
        string fileName;
        byte[] editableHoFile;
        public void loadHoParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    editableHoFile = File.ReadAllBytes(openFile.FileName);
                    hoFile = new HoFile(openFile.FileName);
                    fileName = openFile.FileName;

                    FillLayerListBox();
                }
        }
        public ulong GetSelectedAssetID()
        {
            if (listBoxAssets.SelectedItem != null)
                return Convert.ToUInt64(listBoxAssets.SelectedItem.ToString().Substring(listBoxAssets.SelectedItem.ToString().LastIndexOf("[") + 1, 16), 16);

            return 0;
        }
        public void ReplaceInEditableArray(int offset, byte[] file, int maxSize)
        {
            for (int i = 0; i < file.Length; i++)
                editableHoFile[offset + i] = file[i];
            for (int i = file.Length; i < maxSize; i++)
                editableHoFile[offset + i] = 0x33;
        }

        public void WriteNewSizeInEditableArray(int offset, int length)
        {
            byte[] bytes = BitConverter.GetBytes(length.Switch());
            for (int i = 0; i < bytes.Length; i++)
                editableHoFile[offset + i] = bytes[i];
        }

        public void listBoxAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                            label6.Text = "Size: " + psl.assets[listBoxAssets.SelectedIndex].actualSize.ToString() + "\nMax Size: " + psl.assets[listBoxAssets.SelectedIndex].totalDataSize.ToString();
        }
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dontSwitch = checkBox1.Checked;
        }

        private void saveHoParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("You don't have a ho file open, so saving would not make sense. Please open a ho file first!");
            }
            else if (File.Exists(fileName))
            {
                File.WriteAllBytes(fileName, editableHoFile);
            }
        }

        public void listBoxAssets_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            if (listBoxAssets.SelectedIndex <= -1)
                            {
                                listBoxAssets.SelectedIndex = 0;
                            }
                            if (listBoxAssets.SelectedIndex > -1)
                            {
                                string isWhatItem = listBoxAssets.GetItemText(listBoxAssets.SelectedItem);
                                if (isWhatItem.Contains("BDE21A8D"))
                                {


                                    x = psl.assets[listBoxAssets.SelectedIndex].data;
                                    byte[] untrimmed = x;
                                    byte[] trimmed = untrimmed.Skip(32).ToArray();
                                    var bmp = TPL.Load(trimmed);
                                    Bitmap newbmp = new Bitmap(bmp.ExtractTexture());

                                    texturePreviewBox.Image = newbmp;
                                }

                                if (isWhatItem.Contains("GEN_RawBlob"))
                                {
                                    x = psl.assets[listBoxAssets.SelectedIndex].data;
                                    byte[] untrimmed = x;
                                    byte[] trimmed = untrimmed.Skip(32).ToArray();
                                    var bmp = TPL.Load(trimmed);
                                    Bitmap newbmp = new Bitmap(bmp.ExtractTexture());

                                    texturePreviewBox.Image = newbmp;
                                }
                                if (chkTurnPreviewOff.Checked)
                                {
                                    TurnOfTexurePreviewing();
                                }

                            }
                        }
        }

        public void exitTheGoodEditor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static byte[] x;
        public static string SetValueForTextPosX = "";
        public static string SetValueForTextPosY = "";
        public static string SetValueForTextPosZ = "";

        public static string SetValueForTextRotX = "";
        public static string SetValueForTextRotY = "";
        public static string SetValueForTextRotZ = "";

        public static string SetValueForTextScaleX = "";
        public static string SetValueForTextScaleY = "";
        public static string SetValueForTextScaleZ = "";
        public static string SetFlagVisibility = "";
        public static string setCollFlag = "";

        public static string SetValueForTextPlatformPosX = "";
        public static string SetValueForTextPlatformPosY = "";
        public static string SetValueForTextPlatformPosZ = "";

        public static string SetValueForTextPlatformRotX = "";
        public static string SetValueForTextPlatformRotY = "";
        public static string SetValueForTextPlatformRotZ = "";

        public static string SetValueForTextPlatformScaleX = "";
        public static string SetValueForTextPlatformScaleY = "";
        public static string SetValueForTextPlatformScaleZ = "";

        public static string SetValueForCollectiblePosX = "";
        public static string SetValueForCollectiblePosY = "";
        public static string SetValueForCollectiblePosZ = "";
        private void button2_Click(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {

                            x = psl.assets[listBoxAssets.SelectedIndex].data;
                            byte[] PlaceableData = x;

                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(x, 0x2C, 4);
                                Array.Reverse(x, 0x30, 4);
                                Array.Reverse(x, 0x34, 4);

                                Array.Reverse(x, 0x20, 4);
                                Array.Reverse(x, 0x24, 4);
                                Array.Reverse(x, 0x28, 4);

                                Array.Reverse(x, 0x38, 4);
                                Array.Reverse(x, 0x3C, 4);
                                Array.Reverse(x, 0x40, 4);
                                Array.Reverse(x, 0x10, 0);
                                Array.Reverse(x, 0x13, 0);

                            }
                            float myFloat = System.BitConverter.ToSingle(PlaceableData, 0x2C); //Read Position X's Float
                            float myFloat2 = System.BitConverter.ToSingle(PlaceableData, 0x30); //Read Position Y's Float
                            float myFloat3 = System.BitConverter.ToSingle(PlaceableData, 0x34); //Read Position Z's Float

                            float myFloat4 = System.BitConverter.ToSingle(PlaceableData, 0x20); //Read Roation X's Float
                            float myFloat5 = System.BitConverter.ToSingle(PlaceableData, 0x24); //Read Rotation Y's Float
                            float myFloat6 = System.BitConverter.ToSingle(PlaceableData, 0x28); //Read Rotation Z's Float

                            float myFloat7 = System.BitConverter.ToSingle(PlaceableData, 0x38); //Read Scale X's Float
                            float myFloat8 = System.BitConverter.ToSingle(PlaceableData, 0x3C); //Read Scale Y's Float
                            float myFloat9 = System.BitConverter.ToSingle(PlaceableData, 0x40); //ReadScale Z's Float
                            int FlagVisible = PlaceableData[0x10]; // Read the visibility flag of a SIMP (not PLAT)
                            int FlagColl = PlaceableData[0x13]; // Read the collision flag of a SIMP (not PLAT)
                            string flag1 = FlagVisible.ToString();
                            string flag2 = FlagColl.ToString();
                            string z = myFloat.ToString();
                            string j = myFloat2.ToString();
                            string i = myFloat3.ToString();

                            string q = myFloat4.ToString();
                            string w = myFloat5.ToString();
                            string r = myFloat6.ToString();

                            string t = myFloat7.ToString();
                            string y = myFloat8.ToString();
                            string o = myFloat9.ToString();


                            SetValueForTextPosX = z;
                            SetValueForTextPosY = j;
                            SetValueForTextPosZ = y;

                            SetValueForTextRotX = q;
                            SetValueForTextRotY = w;
                            SetValueForTextRotZ = r;

                            SetValueForTextScaleX = t;
                            SetValueForTextScaleY = y;
                            SetValueForTextScaleZ = o;

                            SetFlagVisibility = flag1;
                            setCollFlag = flag2;

                            string isWhatAsset = listBoxAssets.GetItemText(listBoxAssets.SelectedItem);
                            if (isWhatAsset.Contains("SimpleObject"))
                            {
                                SimpleObjectEditor simpEdit = new SimpleObjectEditor();
                                simpEdit.Show();
                            }

                            if (isWhatAsset.Contains("Platform"))
                            {
                                x = psl.assets[listBoxAssets.SelectedIndex].data;
                                byte[] PlaceableDataPlatform = x;


                                float myFloatPlatform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x20); //Read Position X's Float
                                float myFloat2Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x24); //Read Position Y's Float
                                float myFloat3Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x28); //Read Position Z's Float

                                float myFloat4Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x2C); //Read Roation X's Float
                                float myFloat5Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x30); //Read Rotation Y's Float
                                float myFloat6Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x34); //Read Rotation Z's Float

                                float myFloat7Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x38); //Read Scale X's Float
                                float myFloat8Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x3C); //Read Scale Y's Float
                                float myFloat9Platform = System.BitConverter.ToSingle(PlaceableDataPlatform, 0x40); //ReadScale Z's Float

                                string PlatPosX = myFloatPlatform.ToString();
                                string PlatPosY = myFloat2Platform.ToString();
                                string PlatPosZ = myFloat3Platform.ToString();

                                string PlatRotX = myFloat4Platform.ToString();
                                string PlatRotY = myFloat5Platform.ToString();
                                string PlatRotZ = myFloat6Platform.ToString();

                                string PlatScaleX = myFloat7Platform.ToString();
                                string PlatScaleY = myFloat8Platform.ToString();
                                string PlatScaleZ = myFloat9Platform.ToString();


                                SetValueForTextPlatformPosX = PlatPosX;
                                SetValueForTextPlatformPosY = PlatPosY;
                                SetValueForTextPlatformPosZ = PlatPosZ;

                                SetValueForTextPlatformRotX = PlatRotX;
                                SetValueForTextPlatformRotY = PlatRotY;
                                SetValueForTextPlatformRotZ = PlatRotZ;

                                SetValueForTextPlatformScaleX = PlatScaleX;
                                SetValueForTextPlatformScaleY = PlatScaleY;
                                SetValueForTextPlatformScaleZ = PlatScaleZ;

                                PlatformEditor platEdit = new PlatformEditor();
                                platEdit.Show();
                            }
                            if (isWhatAsset.Contains("FloatingCollectible"))
                            {
                                x = psl.assets[listBoxAssets.SelectedIndex].data;
                                byte[] PlaceableDataFloatingCollectible = x;
                                if (BitConverter.IsLittleEndian)
                                {
                                    Array.Reverse(x, 0x60, 4);
                                    Array.Reverse(x, 0x64, 4);
                                    Array.Reverse(x, 0x68, 4);
                                }


                                float myFloatCollectible = System.BitConverter.ToSingle(PlaceableDataFloatingCollectible, 0x60); //Read Position X's Float
                                float myFloat2Collectible = System.BitConverter.ToSingle(PlaceableDataFloatingCollectible, 0x64); //Read Position Y's Float
                                float myFloat3Collectible = System.BitConverter.ToSingle(PlaceableDataFloatingCollectible, 0x68); //Read Position Z's Float


                                string CollectiblePosX = myFloatCollectible.ToString();
                                string CollectiblePosY = myFloat2Collectible.ToString();
                                string CollectiblePosZ = myFloat3Collectible.ToString();



                                SetValueForCollectiblePosX = CollectiblePosX;
                                SetValueForCollectiblePosY = CollectiblePosY;
                                SetValueForCollectiblePosZ = CollectiblePosZ;


                                FloatingCollectibleEditorWindow collEdit = new FloatingCollectibleEditorWindow();
                                collEdit.Show();
                            }



                        }
        }

        private void buttonExtract_Click_1(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                            using (SaveFileDialog saveFile = new SaveFileDialog()
                            {
                                FileName = psl.assets[listBoxAssets.SelectedIndex].assetID.ToString("X16")
                            })
                                if (saveFile.ShowDialog() == DialogResult.OK)
                                    File.WriteAllBytes(saveFile.FileName, psl.assets[listBoxAssets.SelectedIndex].data);
        }


        private void exportLayerListToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBoxLayers.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Successfully Wrote Layers to Text File!");
            }
        }

        private void exportAssetsListToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBoxAssets.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Successfully Wrote Assets List to Text File!");
            }
        }

        private void saveHoParcelAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog()
            {
                FileName = fileName
            })
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFile.FileName;
                    saveHoParcelToolStripMenuItem_Click(sender, e);
                }
        }


        private void btnLayerUp_Click(object sender, EventArgs e)
        {
            if (listBoxLayers.SelectedIndex != listBoxLayers.Items.Count + 1)
                listBoxLayers.SelectedIndex = listBoxLayers.SelectedIndex - 1;
        }

        private void btnLayerDown_Click(object sender, EventArgs e)
        {
            if (listBoxLayers.SelectedIndex > 0)
                listBoxLayers.SelectedIndex = listBoxLayers.SelectedIndex + 1;
        }

        private void btnAssetUp_Click(object sender, EventArgs e)
        {
            if (listBoxAssets.SelectedIndex != listBoxAssets.Items.Count + 1)
                listBoxAssets.SelectedIndex = listBoxAssets.SelectedIndex - 1;
        }

        private void btnAssetDown_Click(object sender, EventArgs e)
        {
            if (listBoxAssets.SelectedIndex > 0)
                listBoxAssets.SelectedIndex = listBoxAssets.SelectedIndex + 1;
        }

        private void aboutTheGoodEditor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutWindow = new About();
            aboutWindow.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gHelpToolTips.Active = true;
        }

        private void disableToolTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gHelpToolTips.Active = false;
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            gHelpToolTips.Show("Check this checkbox to open ho files that are little endian. Example: Family Guy: Back to the Multiverse's ho files", checkBox1);
        }

        private void listBoxLayers_MouseHover(object sender, EventArgs e)
        {
            gHelpToolTips.Show("This listbox shows which layers are loaded from the ho file. Click on one to view which assets are in that layer.", listBoxLayers);
        }

        private void listBoxAssets_MouseHover(object sender, EventArgs e)
        {
            gHelpToolTips.Show("This listbox shows which assets are in a layer.", listBoxAssets);
        }




        private void btnLayerUp_MouseHover(object sender, EventArgs e)
        {
            gHelpToolTips.Show("fine scroll up through layers.", btnLayerUp);
        }

        private void btnLayerDown_MouseHover(object sender, EventArgs e)
        {
            gHelpToolTips.Show("fine scroll down through layers.", btnLayerDown);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DiscordRPCController.ToggleDiscordRichPresence(checkBox2.Checked);
        }

        private void grupAssetOtherTools_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExtractAll_Click_2(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    hoFile.ExtractAssetsToFolders(folderBrowser.SelectedPath, true);
        }

        private void buttonReplace_Click_2(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                            using (OpenFileDialog openFile = new OpenFileDialog()
                            {
                                Title = "Choose a file to replace."
                            })
                                if (openFile.ShowDialog() == DialogResult.OK)
                                {
                                    byte[] file = File.ReadAllBytes(openFile.FileName);
                                    if (file.Length <= psl.assets[listBoxAssets.SelectedIndex].totalDataSize)
                                    {
                                        psl.assets[listBoxAssets.SelectedIndex].data = file;
                                        ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, file, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                                        psl.assets[listBoxAssets.SelectedIndex].actualSize = file.Length;
                                        WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, file.Length);

                                        listBoxAssets_SelectedIndexChanged(sender, e);
                                    }
                                    else
                                        MessageBox.Show($"Please choose a file with at most the maximum size of the asset you want to replace.\n" +
                                            $"Maximum asset size: {psl.assets[listBoxAssets.SelectedIndex].totalDataSize} bytes\n" +
                                            $"Size of your file: {file.Length} bytes");
                                }
        }

        private void buttonExtract_Click_2(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                            using (SaveFileDialog saveFile = new SaveFileDialog()
                            {
                                FileName = psl.assets[listBoxAssets.SelectedIndex].assetID.ToString("X16")
                            })
                                if (saveFile.ShowDialog() == DialogResult.OK)
                                    File.WriteAllBytes(saveFile.FileName, psl.assets[listBoxAssets.SelectedIndex].data);
        }

        public void button2_Click_1(object sender, EventArgs e)
        {

        }
        byte[] posX;
        byte[] posY;
        byte[] posZ;

        byte[] rotX;
        byte[] rotY;
        byte[] rotZ;

        byte[] scaleX;
        byte[] scaleY;
        byte[] scaleZ;
        public void saveSimpleObject(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            float parsePosX = float.Parse(SimpleObjectEditor.SaveValueForTextPosX);
                            float parsePosY = float.Parse(SimpleObjectEditor.SaveValueForTextPosY);
                            float parsePosZ = float.Parse(SimpleObjectEditor.SaveValueForTextPosZ);
                            float s = parsePosX;
                            float i = parsePosY;
                            float p = parsePosZ;
                            float all1 = float.Parse(s.ToString());
                            float all2 = float.Parse(i.ToString());
                            float all3 = float.Parse(p.ToString());
                            posX = BitConverter.GetBytes(all1);
                            posY = BitConverter.GetBytes(all2);
                            posZ = BitConverter.GetBytes(all3);

                            float parseRotX = float.Parse(SimpleObjectEditor.SaveValueForTextRotX);
                            float parseRotY = float.Parse(SimpleObjectEditor.SaveValueForTextRotY);
                            float parseRotZ = float.Parse(SimpleObjectEditor.SaveValueForTextRotZ);
                            float q = parseRotX;
                            float w = parseRotY;
                            float r = parseRotZ;
                            float all4 = float.Parse(q.ToString());
                            float all5 = float.Parse(w.ToString());
                            float all6 = float.Parse(r.ToString());
                            rotX = BitConverter.GetBytes(all4);
                            rotY = BitConverter.GetBytes(all5);
                            rotZ = BitConverter.GetBytes(all6);

                            float parseScaleX = float.Parse(SimpleObjectEditor.SaveValueForTextScaleX);
                            float parseScaleY = float.Parse(SimpleObjectEditor.SaveValueForTextScaleY);
                            float parseScaleZ = float.Parse(SimpleObjectEditor.SaveValueForTextScaleZ);
                            float a = parseScaleX;
                            float l = parseScaleY;
                            float d = parseScaleZ;
                            float all7 = float.Parse(a.ToString());
                            float all8 = float.Parse(l.ToString());
                            float all9 = float.Parse(d.ToString());
                            scaleX = BitConverter.GetBytes(all7);
                            scaleY = BitConverter.GetBytes(all8);
                            scaleZ = BitConverter.GetBytes(all9);

                            byte parseFlag = Byte.Parse(SimpleObjectEditor.SaveVisibilityFlag);
                            byte parseFlag1 = Byte.Parse(SimpleObjectEditor.SaveCollFlag);

                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(posX);
                                Array.Reverse(posY);
                                Array.Reverse(posZ);

                                Array.Reverse(rotX);
                                Array.Reverse(rotY);
                                Array.Reverse(rotZ);

                                Array.Reverse(scaleX);
                                Array.Reverse(scaleY);
                                Array.Reverse(scaleZ);

                            }

                            posX.CopyTo(x, 0x2C);
                            posY.CopyTo(x, 0x30);
                            posZ.CopyTo(x, 0x34);

                            rotX.CopyTo(x, 0x20);
                            rotY.CopyTo(x, 0x24);
                            rotZ.CopyTo(x, 0x28);

                            scaleX.CopyTo(x, 0x38);
                            scaleY.CopyTo(x, 0x3C);
                            scaleZ.CopyTo(x, 0x40);
                            x[0x10] = parseFlag;
                            x[0x13] = parseFlag1;


                            psl.assets[listBoxAssets.SelectedIndex].data = x;
                            ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, x, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                            psl.assets[listBoxAssets.SelectedIndex].actualSize = x.Length;
                            WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, x.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }
        }
        byte[] posXPlat;
        byte[] posYPlat;
        byte[] posZPlat;

        byte[] rotXPlat;
        byte[] rotYPlat;
        byte[] rotZPlat;

        byte[] scaleXPlat;
        byte[] scaleYPlat;
        byte[] scaleZPlat;
        public void savePlatform(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            float parsePosXPlat = float.Parse(PlatformEditor.SaveValueForTextPosXPlat);
                            float parsePosYPlat = float.Parse(PlatformEditor.SaveValueForTextPosYPlat);
                            float parsePosZPlat = float.Parse(PlatformEditor.SaveValueForTextPosZPlat);
                            float posxplatPlat = parsePosXPlat;
                            float platY = parsePosYPlat;
                            float PlatZ = parsePosZPlat;
                            float all01 = float.Parse(posxplatPlat.ToString());
                            float all02 = float.Parse(platY.ToString());
                            float all03 = float.Parse(PlatZ.ToString());
                            posXPlat = BitConverter.GetBytes(all01);
                            posYPlat = BitConverter.GetBytes(all02);
                            posZPlat = BitConverter.GetBytes(all03);

                            float parseRotXPlat = float.Parse(PlatformEditor.SaveValueForTextRotXPlat);
                            float parseRotYPlat = float.Parse(PlatformEditor.SaveValueForTextRotYPlat);
                            float parseRotZPlat = float.Parse(PlatformEditor.SaveValueForTextRotZPlat);
                            float PlatRX = parseRotXPlat;
                            float PlatRY = parseRotYPlat;
                            float PlatRZ = parseRotZPlat;
                            float all04 = float.Parse(PlatRX.ToString());
                            float all05 = float.Parse(PlatRY.ToString());
                            float all06 = float.Parse(PlatRZ.ToString());
                            rotXPlat = BitConverter.GetBytes(all04);
                            rotYPlat = BitConverter.GetBytes(all05);
                            rotZPlat = BitConverter.GetBytes(all06);

                            float parseScaleXPlat = float.Parse(PlatformEditor.SaveValueForTextScaleXPlat);
                            float parseScaleYPlat = float.Parse(PlatformEditor.SaveValueForTextScaleYPlat);
                            float parseScaleZPlat = float.Parse(PlatformEditor.SaveValueForTextScaleZPlat);
                            float PlatSX = parseScaleXPlat;
                            float PlatSY = parseScaleYPlat;
                            float PlatSZ = parseScaleZPlat;
                            float all07 = float.Parse(PlatSX.ToString());
                            float all08 = float.Parse(PlatSY.ToString());
                            float all09 = float.Parse(PlatSZ.ToString());
                            scaleXPlat = BitConverter.GetBytes(all07);
                            scaleYPlat = BitConverter.GetBytes(all08);
                            scaleZPlat = BitConverter.GetBytes(all09);


                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(posXPlat);
                                Array.Reverse(posYPlat);
                                Array.Reverse(posZPlat);

                                Array.Reverse(rotXPlat);
                                Array.Reverse(rotYPlat);
                                Array.Reverse(rotZPlat);

                                Array.Reverse(scaleXPlat);
                                Array.Reverse(scaleYPlat);
                                Array.Reverse(scaleZPlat);

                            }

                            posXPlat.CopyTo(x, 0x2C);
                            posYPlat.CopyTo(x, 0x30);
                            posZPlat.CopyTo(x, 0x34);

                            rotXPlat.CopyTo(x, 0x20);
                            rotYPlat.CopyTo(x, 0x24);
                            rotZPlat.CopyTo(x, 0x28);

                            scaleXPlat.CopyTo(x, 0x38);
                            scaleYPlat.CopyTo(x, 0x3C);
                            scaleZPlat.CopyTo(x, 0x40);

                            psl.assets[listBoxAssets.SelectedIndex].data = x;
                            ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, x, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                            psl.assets[listBoxAssets.SelectedIndex].actualSize = x.Length;
                            WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, x.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }
        }
        byte[] posXCollectible;
        byte[] posYCollectible;
        byte[] posZCollectible;
        public void saveFloatingCollectible(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            float parsePosXColl = float.Parse(FloatingCollectibleEditorWindow.SaveValueForTextPosXCollectible);
                            float parsePosYColl = float.Parse(FloatingCollectibleEditorWindow.SaveValueForTextPosYCollectible);
                            float parsePosZColl = float.Parse(FloatingCollectibleEditorWindow.SaveValueForTextPosZCollectible);
                            float Coll01 = parsePosXColl;
                            float Coll02 = parsePosYColl;
                            float Coll03 = parsePosZColl;
                            float all001 = float.Parse(Coll01.ToString());
                            float all002 = float.Parse(Coll02.ToString());
                            float all003 = float.Parse(Coll03.ToString());
                            posXCollectible = BitConverter.GetBytes(all001);
                            posYCollectible = BitConverter.GetBytes(all002);
                            posZCollectible = BitConverter.GetBytes(all003);

                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(posXCollectible);
                                Array.Reverse(posYCollectible);
                                Array.Reverse(posZCollectible);
                            }
                            posXCollectible.CopyTo(x, 0x60);
                            posYCollectible.CopyTo(x, 0x64);
                            posZCollectible.CopyTo(x, 0x68);


                            psl.assets[listBoxAssets.SelectedIndex].data = x;
                            ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, x, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                            psl.assets[listBoxAssets.SelectedIndex].actualSize = x.Length;
                            WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, x.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string whatIsAsset = listBoxAssets.GetItemText(listBoxAssets.SelectedItem);
            if (whatIsAsset.Contains("SimpleObject"))
            {
                WhatIsSimpleObjectWindow simpAbout = new WhatIsSimpleObjectWindow();
                simpAbout.ShowDialog();
            }
            if (whatIsAsset.Contains("Platform"))
            {
                WhatIsPlatformWindow platWindow = new WhatIsPlatformWindow();
                platWindow.ShowDialog();
            }
            if (whatIsAsset.Contains("FloatingCollectible"))
            {
                WhatIsFloatingCollectible floatWindow = new WhatIsFloatingCollectible();
                floatWindow.ShowDialog();
            }
            if (whatIsAsset.Contains("BDE21A8D"))
            {
                WhatIsTextureWindow texWindow = new WhatIsTextureWindow();
                texWindow.ShowDialog();
            }
            if (whatIsAsset.Contains("GEN_RawBlob"))
            {
                WhatIsGenRawBlob texWindow = new WhatIsGenRawBlob();
                texWindow.ShowDialog();
            }
        }


        private void btnOpenByteViewer_Click(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {

                            x = psl.assets[listBoxAssets.SelectedIndex].data;
                            ByteViewerBox byteView = new ByteViewerBox();
                            byteView.ShowDialog();
                        }
                        else if (listBoxAssets.SelectedIndex == -1)
                            MessageBox.Show("You have not selected an asset! Please select an asset first!");
            {

            }
        }

        public void HexBox_CopiedHex(object sender, EventArgs e)
        {
            var hex = Clipboard.GetText();
            var hexHex = hex.Split(' ');
            var hexArr = new byte[hexHex.Length];
            for (var i = 0; i < hexHex.Length; i++)
            {
                hexArr[i] = byte.Parse(hexHex[i], NumberStyles.AllowHexSpecifier);
            }
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            psl.assets[listBoxAssets.SelectedIndex].data = hexArr;
                            ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, hexArr, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                            psl.assets[listBoxAssets.SelectedIndex].actualSize = hexArr.Length;
                            WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, hexArr.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }


        }

        private void openTheSaveFileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            x = psl.assets[listBoxAssets.SelectedIndex].data;
                            TextureViewer texView = new TextureViewer();
                            texView.ShowDialog();
                        }

        }
        public void TurnOfTexurePreviewing()
        {
            texturePreviewBox.Image = null;
        }
        public void HideOpenButton()
        {
            btnOpenTextureViewer.Visible = false;
        }
        public void ShowOpenButton()
        {
            btnOpenTextureViewer.Visible = true;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurnOffPreviewButton.Checked == true)
            {
                HideOpenButton();
            }
            if (chkTurnOffPreviewButton.Checked == false)
            {
                ShowOpenButton();
            }
        }

        private void openTheRandomizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randomizer randomizerWindow = new Randomizer();
            randomizerWindow.ShowDialog();
        }
        byte[] posXSimpleObject;
        public void RandomizePositionXSimpleObject(object sender, EventArgs e)
        {
            List<byte> allSimpleObjects = new List<byte>();
            listBoxAssets.BeginUpdate();
            listBoxAssets.Items.Clear();
            if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
            {
                if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                {
                    foreach (var asset in psl.assets)
                    {
                        asset.data = x;
                        foreach (string currentString in listBoxAssets.Items)
                        {
                            currentString.Contains("SimpleObject");
                            var bytes = Encoding.Unicode.GetBytes(currentString);
                            allSimpleObjects.AddRange(bytes);
                        
                            Random randomFloatPosX = new Random();
                            var randomPosXFloatSimp = randomFloatPosX.NextDouble() * (20.5 - 1.0);
                            float parserandomFloatPosX = float.Parse(randomPosXFloatSimp.ToString());
                            float PosXRandomFloat = parserandomFloatPosX;
                            float allDataPosX = float.Parse(PosXRandomFloat.ToString());
                            posXSimpleObject = BitConverter.GetBytes(allDataPosX);

                            if (BitConverter.IsLittleEndian)
                            {
                                Array.Reverse(posXSimpleObject);
                            }
                            x = allSimpleObjects.ToArray();
                            posXSimpleObject.CopyTo(x, 0x2C);

                            ReplaceInEditableArray(asset.absoluteDataOffset, x, asset.totalDataSize);

                            asset.actualSize = x.Length;
                            WriteNewSizeInEditableArray(asset.absoluteActualSizeOffset, x.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }                        
                    }
                }
            }
            listBoxAssets.EndUpdate();
            listBoxAssets_SelectedIndexChanged(sender, e);
        }

        private void texturePreviewBox_Click(object sender, EventArgs e)
        {

        }
        public void saveNewCustomTexture(object sender, EventArgs e)
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            x = TextureViewer.customTextureData;


                            psl.assets[listBoxAssets.SelectedIndex].data = x;
                            ReplaceInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteDataOffset, x, psl.assets[listBoxAssets.SelectedIndex].totalDataSize);

                            psl.assets[listBoxAssets.SelectedIndex].actualSize = x.Length;
                            WriteNewSizeInEditableArray(psl.assets[listBoxAssets.SelectedIndex].absoluteActualSizeOffset, x.Length);

                            listBoxAssets_SelectedIndexChanged(sender, e);
                        }
        }
        public void refreshTextureViewerPreviewBox()
        {
            ulong assetID = GetSelectedAssetID();

            if (assetID != 0)
                if (listBoxLayers.SelectedIndex > -1 && listBoxLayers.SelectedIndex < hoFile.MAST.sectionSect2.layers.Count)
                    if (hoFile.MAST.sectionSect2.layers[listBoxLayers.SelectedIndex].subLayer is SubLayer_PSL psl)
                        if (listBoxAssets.SelectedIndex > -1 && listBoxAssets.SelectedIndex < psl.assets.Count)
                        {
                            if (listBoxAssets.SelectedIndex <= -1)
                            {
                                listBoxAssets.SelectedIndex = 0;
                            }
                            if (listBoxAssets.SelectedIndex > -1)
                            {
                                string isWhatItem = listBoxAssets.GetItemText(listBoxAssets.SelectedItem);
                                if (isWhatItem.Contains("BDE21A8D"))
                                {
                                    x = psl.assets[listBoxAssets.SelectedIndex].data;
                                    byte[] untrimmed = x;
                                    byte[] trimmed = untrimmed.Skip(32).ToArray();
                                    var bmp = TPL.Load(trimmed);
                                    Bitmap newbmp = new Bitmap(bmp.ExtractTexture());

                                    texturePreviewBox.Image = newbmp;
                                }
                                if (isWhatItem.Contains("GEN_RawBlob"))
                                {
                                    x = psl.assets[listBoxAssets.SelectedIndex].data;
                                    byte[] untrimmed = x;
                                    byte[] trimmed = untrimmed.Skip(32).ToArray();
                                    var bmp = TPL.Load(trimmed);
                                    Bitmap newbmp = new Bitmap(bmp.ExtractTexture());

                                    texturePreviewBox.Image = newbmp;
                                }
                            }
                        }
        }

        private void btnDumpTextures_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    hoFile.DumpTextures(folderBrowser.SelectedPath);                 
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            ExtraTextureOptionsWindow extraOptionsForTextures = new ExtraTextureOptionsWindow();
            extraOptionsForTextures.ShowDialog();
        }
        public void setColors()
        {
            ColorDialog colorChooser = new ColorDialog();
            if (colorChooser.ShowDialog() == DialogResult.OK)
            {
                hoFile.makeTexturesSolidColor(colorChooser.Color);
            }
        }
    }
}
