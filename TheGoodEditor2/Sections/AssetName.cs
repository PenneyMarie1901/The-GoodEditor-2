using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodEditor2.Sections
{
    class AssetName
    {
        public string assetName;

        public AssetName(BinaryReader binaryReader, int localoffset)
        {
            assetName = binaryReader.ReadString();

            binaryReader.BaseStream.Position = localoffset;
            var position = binaryReader.BaseStream.Position;
            binaryReader.BaseStream.Position = position;
        }
    }
}
