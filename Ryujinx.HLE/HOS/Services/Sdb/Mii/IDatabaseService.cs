using Ryujinx.Common.Logging;
using Ryujinx.HLE.Exceptions;
using Ryujinx.HLE.HOS.Ipc;
using Ryujinx.HLE.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Ryujinx.HLE.HOS.Services.Sdb.Mii
{
    [Service("IDatabaseService")]
    class IDatabaseService : IpcService
    {


        enum Source
        {
            Database = 0,
            Default = 1,
            Account = 2,
            Friend = 3
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct CharInfo
        {
            public UInt128 MiiId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
            public string Nickname;
            public byte FontRegion;
            public byte FavoriteColor;
            public byte Gender;
            public byte Height;
            public byte Build;
            public byte Type;
            public byte RegionMove;
            public byte FacelineType;
            public byte FacelineColor;
            public byte FacelineWrinkle;
            public byte FacelineMake;
            public byte HairType;
            public byte HairColor;
            public byte IsHairFlip;
            public byte EyeType;
            public byte EyeColor;
            public byte EyeScale;
            public byte EyeAspect;
            public byte EyeRotate;
            public byte EyeX;
            public byte EyeY;
            public byte EyebrowType;
            public byte EyebrowColor;
            public byte EyebrowScale;
            public byte EyebrowAspect;
            public byte EyebrowRotate;
            public byte EyebrowX;
            public byte EyebrowY;
            public byte NoseType;
            public byte NoseScale;
            public byte NoseY;
            public byte MouthType;
            public byte MouthColor;
            public byte MouthScale;
            public byte MouthAspect;
            public byte MouthY;
            public byte BeardColor;
            public byte BeardType;
            public byte MustacheType;
            public byte MustacheScale;
            public byte MustacheY;
            public byte GlassTyp;
            public byte GlassColor;
            public byte GlassScale;
            public byte GlassY;
            public byte MoleType;
            public byte MoleScale;
            public byte MoleX;
            public byte MoleY;
            public byte Unknown1;
        }

        struct MiiInfoElement
        {
            public CharInfo info;
            public Source source;
        };

        public IDatabaseService(ServiceCtx context) { }

        [Command(0)]
        // IsUpdated(i32) -> bool
        public ResultCode IsUpdated(ServiceCtx context)
        {
            int Key = context.RequestData.ReadInt32();

           // Logger.PrintStub(LogClass.ServiceMii, new { Key });

            context.ResponseData.Write(false);

            return ResultCode.Success;
        }

        [Command(1)]
        // IsFullDatabase() -> bool
        public ResultCode IsFullDatabase(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(2)]
        // GetCount(i32) -> i32
        public ResultCode GetCount(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(3)]
        // Get(i32) -> (i32, array<nn::mii::CharInfoElement, 6>)
        public ResultCode Get(ServiceCtx context)
        {
            int key = context.RequestData.ReadInt32();

            Logger.PrintStub(LogClass.ServiceMii, new { key });
            // We stub as not returning anything for the time being

            var charInfo = new CharInfo
            {
                MiiId = new UInt128(0, 100),
                Nickname = "no name",
                FontRegion = 1,
                FavoriteColor = 1,
                Gender = 1,
                Height = 1,
                Build = 1,
                Type = 1,
                RegionMove = 1,
                FacelineType = 1,
                FacelineColor = 1,
                FacelineWrinkle = 1,
                FacelineMake = 1,
                HairType = 1,
                HairColor = 1,
                IsHairFlip = 1,
                EyeType = 1,
                EyeColor = 1,
                EyeScale = 1,
                EyeAspect = 1,
                EyeRotate = 1,
                EyeX = 1,
                EyeY = 1,
                EyebrowType = 1,
                EyebrowColor = 1,
                EyebrowScale = 1,
                EyebrowAspect = 1,
                EyebrowRotate = 1,
                EyebrowX = 1,
                EyebrowY = 1,
                NoseType = 1,
                NoseScale = 1,
                NoseY = 1,
                MouthType = 1,
                MouthColor = 1,
                MouthScale = 1,
                MouthAspect = 1,
                MouthY = 1,
                BeardColor = 1,
                BeardType = 1,
                MustacheType = 1,
                MustacheScale = 1,
                MustacheY = 1,
                GlassTyp = 1,
                GlassColor = 1,
                GlassScale = 1,
                GlassY = 1,
                MoleType = 1,
                MoleScale = 1,
                MoleX = 1,
                MoleY = 1,
                Unknown1 = 0
            };
            // nn::mii::CharInfo size is 88 bytes
            byte[] data = new byte[88];
            unsafe
            {
                fixed (byte* dataptr = data)
                {
                    Marshal.StructureToPtr(charInfo, (IntPtr)dataptr, false);
                }
            }


            //MiiInfoElement test;
            //test.info = charInfo;
            //test.source = Source.Default;
            //// nn::mii::CharInfo size is 88 bytes
            //byte[] data2 = new byte[1];
            //unsafe
            //{
            //    fixed (byte* dataptr = data)
            //    {
            //        Marshal.StructureToPtr(test.source, (IntPtr)dataptr, false);
            //    }
            //}


            context.ResponseData.Write(data);
            context.ResponseData.Write(1);
            context.ResponseData.Write(0);

            return ResultCode.Success;
        }

        [Command(4)]
        // Get1(i32) -> (i32, array<nn::mii::CharInfo, 6>)
        public ResultCode Get1(ServiceCtx context)
        {
            int key = context.RequestData.ReadInt32();
            var charInfo = new CharInfo
            {
                MiiId = new UInt128(0, 100),
                Nickname = "no name",
                FontRegion = 1,
                FavoriteColor = 1,
                Gender = 1,
                Height = 1,
                Build = 1,
                Type = 1,
                RegionMove = 1,
                FacelineType = 1,
                FacelineColor = 1,
                FacelineWrinkle = 1,
                FacelineMake = 1,
                HairType = 1,
                HairColor = 1,
                IsHairFlip = 1,
                EyeType = 1,
                EyeColor = 1,
                EyeScale = 1,
                EyeAspect = 1,
                EyeRotate = 1,
                EyeX = 1,
                EyeY = 1,
                EyebrowType = 1,
                EyebrowColor = 1,
                EyebrowScale = 1,
                EyebrowAspect = 1,
                EyebrowRotate = 1,
                EyebrowX = 1,
                EyebrowY = 1,
                NoseType = 1,
                NoseScale = 1,
                NoseY = 1,
                MouthType = 1,
                MouthColor = 1,
                MouthScale = 1,
                MouthAspect = 1,
                MouthY = 1,
                BeardColor = 1,
                BeardType = 1,
                MustacheType = 1,
                MustacheScale = 1,
                MustacheY = 1,
                GlassTyp = 1,
                GlassColor = 1,
                GlassScale = 1,
                GlassY = 1,
                MoleType = 1,
                MoleScale = 1,
                MoleX = 1,
                MoleY = 1,
                Unknown1 = 0
            };
            // nn::mii::CharInfo size is 88 bytes
            byte[] data = new byte[88];
            unsafe
            {
                fixed (byte* dataptr = data)
                {
                    Marshal.StructureToPtr(charInfo, (IntPtr)dataptr, false);
                }
            }

            Logger.PrintStub(LogClass.ServiceMii, new { key });

            // We stub as not returning anything for the time being
            context.ResponseData.Write(data);
            context.ResponseData.Write(0);

            return ResultCode.Success;
        }

        [Command(5)]
        public ResultCode UpdateLatest(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(6)]
        public ResultCode BuildRandom(ServiceCtx context)
        {
            int key = context.RequestData.ReadInt32();

            Logger.PrintStub(LogClass.ServiceMii, new { key });

            var charInfo = new CharInfo
            {
                MiiId = new UInt128(0, 100),
                Nickname = "no name",
                FontRegion = 1,
                FavoriteColor = 1,
                Gender = 1,
                Height = 1,
                Build = 1,
                Type = 1,
                RegionMove = 1,
                FacelineType = 1,
                FacelineColor = 1,
                FacelineWrinkle = 1,
                FacelineMake = 1,
                HairType = 1,
                HairColor = 1,
                IsHairFlip = 1,
                EyeType = 1,
                EyeColor = 1,
                EyeScale = 1,
                EyeAspect = 1,
                EyeRotate = 1,
                EyeX = 1,
                EyeY = 1,
                EyebrowType = 1,
                EyebrowColor = 1,
                EyebrowScale = 1,
                EyebrowAspect = 1,
                EyebrowRotate = 1,
                EyebrowX = 1,
                EyebrowY = 1,
                NoseType = 1,
                NoseScale = 1,
                NoseY = 1,
                MouthType = 1,
                MouthColor = 1,
                MouthScale = 1,
                MouthAspect = 1,
                MouthY = 1,
                BeardColor = 1,
                BeardType = 1,
                MustacheType = 1,
                MustacheScale = 1,
                MustacheY = 1,
                GlassTyp = 1,
                GlassColor = 1,
                GlassScale = 1,
                GlassY = 1,
                MoleType = 1,
                MoleScale = 1,
                MoleX = 1,
                MoleY = 1,
                Unknown1 = 0
            };

            // nn::mii::CharInfo size is 88 bytes
            byte[] data = new byte[88];
            unsafe
            {
                fixed (byte* dataptr = data)
                {
                    Marshal.StructureToPtr(charInfo, (IntPtr)dataptr, false);
                }
            }

            context.ResponseData.Write(data);

            return ResultCode.Success;
        }

        [Command(7)]
        // BuildDefault(i32) -> nn::mii::CharInfo
        public ResultCode BuildDefault(ServiceCtx context)
        {
            int key = context.RequestData.ReadInt32();

            Logger.PrintStub(LogClass.ServiceMii, new { key });

            var charInfo = new CharInfo
            {
                MiiId = new UInt128(0, 100),
                Nickname = "no name",
                FontRegion = 1,
                FavoriteColor = 1,
                Gender = 1,
                Height = 1,
                Build = 1,
                Type = 1,
                RegionMove = 1,
                FacelineType = 1,
                FacelineColor = 1,
                FacelineWrinkle = 1,
                FacelineMake = 1,
                HairType = 1,
                HairColor = 1,
                IsHairFlip = 1,
                EyeType = 1,
                EyeColor = 1,
                EyeScale = 1,
                EyeAspect = 1,
                EyeRotate = 1,
                EyeX = 1,
                EyeY = 1,
                EyebrowType = 1,
                EyebrowColor = 1,
                EyebrowScale = 1,
                EyebrowAspect = 1,
                EyebrowRotate = 1,
                EyebrowX = 1,
                EyebrowY = 1,
                NoseType = 1,
                NoseScale = 1,
                NoseY = 1,
                MouthType = 1,
                MouthColor = 1,
                MouthScale = 1,
                MouthAspect = 1,
                MouthY = 1,
                BeardColor = 1,
                BeardType = 1,
                MustacheType = 1,
                MustacheScale = 1,
                MustacheY = 1,
                GlassTyp = 1,
                GlassColor = 1,
                GlassScale = 1,
                GlassY = 1,
                MoleType = 1,
                MoleScale = 1,
                MoleX = 1,
                MoleY = 1,
                Unknown1 = 0
            };

            // nn::mii::CharInfo size is 88 bytes
            byte[] data = new byte[88];
            unsafe
            {
                fixed (byte* dataptr = data)
                {
                    Marshal.StructureToPtr(charInfo, (IntPtr)dataptr, false);
                }
            }

            context.ResponseData.Write(data);

            return ResultCode.Success;
        }

        [Command(8)]
        public ResultCode Get2(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(9)]
        public ResultCode Get3(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(10)]
        public ResultCode UpdateLatest1(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(11)]
        public ResultCode FindIndex(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(12)]
        public ResultCode Move(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(13)]
        public ResultCode AddOrReplace(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(14)]
        public ResultCode Delete(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(15)]
        public ResultCode DestroyFile(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(16)]
        public ResultCode DeleteFile(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(17)]
        public ResultCode Format(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(18)]
        public ResultCode Import(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(19)]
        public ResultCode Export(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(20)]
        public ResultCode IsBrokenDatabaseWithClearFlag(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(21)]
        public ResultCode GetIndex(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }

        [Command(22)]
        // SetInterfaceVersion(u32)
        public ResultCode SetInterfaceVersion(ServiceCtx context)
        {
            uint version = context.RequestData.ReadUInt32();

            Logger.PrintStub(LogClass.ServiceMii, new { version });

            return ResultCode.Success;
        }

        [Command(23)]
        public long Convert(ServiceCtx context)
        {
            throw new ServiceNotImplementedException(context);
        }
    }
}
