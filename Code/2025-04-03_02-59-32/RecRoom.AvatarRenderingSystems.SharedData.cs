using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NHCILBFLPCB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float GDDMBEDGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float IHFAGIBOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float LHAPFGDKOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float GGEJNKBOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float JIBLGLEKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float IEDINCLMIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float COEPOALDANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float PHNCPGEDKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BAIKMGMMEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float ODNHKKCBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float HONMKCDKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float OIGKEELAIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GIEEJEIMNME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LPMIDPDDGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float ANKMOLOOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PDANLLIOPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 EIELHGFFCEO(Vector3 CEGIKJLFFBF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 ICGLGIOICDE(Vector3 ELNIABCALLJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 IOPIJPKJGNN();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : NHCILBFLPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const float DEFAULT_MIN_OFFSET = -0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const float DEFAULT_MAX_OFFSET = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const float DEFAULT_ROTATION_FREEDOM = 180f;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const float DEFAULT_MIN_UV_COORDINATE = 0f;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const float DEFAULT_MAX_UV_COORDINATE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly Vector2 DEFAULT_UV_RANGE;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly Vector3 DEFAULT_MIN;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly Vector3 DEFAULT_MAX;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Vector3 DEFAULT_FREEDOM;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xBE3960", Offset = "0xBE2D60", VA = "0x180BE3960", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBE3600", Offset = "0xBE2A00", VA = "0x180BE3600", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE322F0", Offset = "0xE316F0", VA = "0x180E322F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC84750", VA = "0x180C85350", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF6EBB0", Offset = "0xF6DFB0", VA = "0x180F6EBB0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE58410", Offset = "0xE57810", VA = "0x180E58410", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB4A1A0", Offset = "0xB495A0", VA = "0x180B4A1A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9C4670", Offset = "0x9C3A70", VA = "0x1809C4670", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x770A8F0", Offset = "0x7709CF0", VA = "0x18770A8F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x770AB10", Offset = "0x7709F10", VA = "0x18770AB10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x770AAF0", Offset = "0x7709EF0", VA = "0x18770AAF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xFAB180", Offset = "0xFAA580", VA = "0x180FAB180", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF6EB50", Offset = "0xF6DF50", VA = "0x180F6EB50", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB45F90", Offset = "0xB45390", VA = "0x180B45F90", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB45BA0", Offset = "0xB44FA0", VA = "0x180B45BA0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE0D830", Offset = "0xE0CC30", VA = "0x180E0D830", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xFB44E0", Offset = "0xFB38E0", VA = "0x180FB44E0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x770A050", Offset = "0x7709450", VA = "0x18770A050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x770AB30", Offset = "0x7709F30", VA = "0x18770AB30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x770AAD0", Offset = "0x7709ED0", VA = "0x18770AAD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xFB4520", Offset = "0xFB3920", VA = "0x180FB4520", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBE45C0", Offset = "0xBE39C0", VA = "0x180BE45C0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBE35E0", Offset = "0xBE29E0", VA = "0x180BE35E0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AFA50", Offset = "0x9AEE50", VA = "0x1809AFA50", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x770AB50", Offset = "0x7709F50", VA = "0x18770AB50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x770AB90", Offset = "0x7709F90", VA = "0x18770AB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x770AB70", Offset = "0x7709F70", VA = "0x18770AB70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x770ABB0", Offset = "0x7709FB0", VA = "0x18770ABB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x770AA40", Offset = "0x7709E40", VA = "0x18770AA40")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7709BE0", Offset = "0x7708FE0", VA = "0x187709BE0")]
		public KGGLBONGBPM CIHIMBBAPAO(KGGLBONGBPM GCNLPCGNGPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x770A050", Offset = "0x7709450", VA = "0x18770A050", Slot = "25")]
		public Vector3 FPOCNKACAMH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x770A8F0", Offset = "0x7709CF0", VA = "0x18770A8F0", Slot = "22")]
		public Vector3 IOPIJPKJGNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7709ED0", Offset = "0x77092D0", VA = "0x187709ED0", Slot = "20")]
		public Vector3 EIELHGFFCEO(Vector3 CEGIKJLFFBF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x770A870", Offset = "0x7709C70", VA = "0x18770A870", Slot = "21")]
		public Vector3 ICGLGIOICDE(Vector3 ELNIABCALLJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7709F40", Offset = "0x7709340", VA = "0x187709F40", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x770A370", Offset = "0x7709770", VA = "0x18770A370")]
		protected bool HNBOIHPBBGL(AnchorParamsRestrictions KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x770A070", Offset = "0x7709470", VA = "0x18770A070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x770A910", Offset = "0x7709D10", VA = "0x18770A910")]
		[CompilerGenerated]
		internal static bool LDHNKFIBEBM(float PCMHLCLONGN, float IAJJOLNCJOI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GOFDEAPMMOI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14B3550", Offset = "0x14B2950", VA = "0x1814B3550")]
	public static bool CMPKBMAJGEM(this IDINMFOPJOG BNJHIIEDKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x770C4E0", Offset = "0x770B8E0", VA = "0x18770C4E0")]
	public static bool FBPNGMMPOBK(this IDINMFOPJOG BNJHIIEDKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x770C4C0", Offset = "0x770B8C0", VA = "0x18770C4C0")]
	public static bool CDBLDJEMOCM(this IDINMFOPJOG BNJHIIEDKCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NFCIPDBBDAM
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool LOMLNDIKJOB;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HelmetHairMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[InspectorName("Show Hair")]
		DoNotHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[InspectorName("Use Helmet Hair")]
		UseHelmetHair,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[InspectorName("Hide Hair (Always)")]
		AlwaysHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[InspectorName("Hide Hair (Optional)")]
		HideHairToggleable
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum HairPatternStyle
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		NoPattern,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Curly,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Braid
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum AvatarItemBodyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		BeanBody,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		FullBody,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		ModernBeanBody
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DOHKJHJLLAO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x770B920", Offset = "0x770AD20", VA = "0x18770B920")]
	public static bool EILHAGBLKNF(this HelmetHairMode LGJKFNJAAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x770B8A0", Offset = "0x770ACA0", VA = "0x18770B8A0")]
	public static GEHKDDKOMID CDAKHNGMMPP(this AvatarItemBodyType MBNOKBJPAMD)
	{
		return default(GEHKDDKOMID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x770B930", Offset = "0x770AD30", VA = "0x18770B930")]
	public static AvatarItemBodyType GBOFHMMEDGK(this GEHKDDKOMID MBNOKBJPAMD)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x770B7E0", Offset = "0x770ABE0", VA = "0x18770B7E0")]
	public static string APHBMEMEAOJ(this AvatarItemBodyType MBNOKBJPAMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CPOHAHDJHBG
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x770ADB0", Offset = "0x770A1B0", VA = "0x18770ADB0")]
	public static void NMELGANLCDC(Transform BKPJKOLHDCG, Transform EFJPADCKJGD, Transform MICGENDNAIJ, Transform LBJMDNHDBPN, float BEPKNIEDEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JBHNNEJDMMC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum CMFCJHIONHN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		DEPRECATED_SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		DEPRECATED_SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		DEPRECATED_PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		DEPRECATED_FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		DEPRECATED_ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		DEPRECATED_PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		DEPRECATED_Ears,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		DEPRECATED_FootHigh,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Neck,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		EarLeft,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		EarRight,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		SleevesShortLeft,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SleevesShortRight,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SleevesLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		SleevesLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PantsLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FootMidLeft,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		FootMidRight,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FootLowLeft,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		FootLowRight,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		PantsShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PantsShortRight,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		UpperThighLeft,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		UpperThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FootHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FootHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FootAnkleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FootAnkleRight,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		TorsoCrop,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		FingersOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		FingersOnlyRight,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		ArmpitLeft,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		ArmpitRight,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		TorsoTop,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Modesty,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ShortShorts,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		SleevesSuperShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		SleevesSuperShortRight,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SleevesMidLeft,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		SleevesMidRight,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		PantsKneeHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		PantsKneeHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		LowerThighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		LowerThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		HandsThumbOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		HandsThumbOnlyRight
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum KMAIJNBJDFP : long
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Head = 1L,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		TorsoAll = 2L,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		TorsoHigh = 4L,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		TorsoLow = 8L,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		SleevesShort = 0x10L,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		SleevesLong = 0x20L,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		DEPRECATED_Palm = 0x40L,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		DEPRECATED_HandsAll = 0x80L,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		PantsLong = 0x100L,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Shorts = 0x200L,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		FootMid = 0x400L,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		ShoeLow = 0x800L,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		PantsShort = 0x1000L,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		PalmL = 0x2000L,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		PalmR = 0x4000L,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		HandL = 0x8000L,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		HandR = 0x10000L,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Ears = 0x20000L,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		FootHigh = 0x40000L,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Neck = 0x80000L,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		EarLeft = 0x100000L,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		EarRight = 0x200000L,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		SleevesShortLeft = 0x400000L,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		SleevesShortRight = 0x800000L,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		SleevesLongLeft = 0x1000000L,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SleevesLongRight = 0x2000000L,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		PantsLongLeft = 0x4000000L,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		PantsLongRight = 0x8000000L,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		FootMidLeft = 0x10000000L,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		FootMidRight = 0x20000000L,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		FootLowLeft = 0x40000000L,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FootLowRight = 0x80000000L,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PantsShortLeft = 0x100000000L,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		PantsShortRight = 0x200000000L,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		UpperThighLeft = 0x400000000L,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		UpperThighRight = 0x800000000L,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		FootHighLeft = 0x1000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FootHighRight = 0x2000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FootAnkleLeft = 0x4000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FootAnkleRight = 0x8000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		TorsoCrop = 0x10000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		FingersOnlyLeft = 0x20000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		FingersOnlyRight = 0x40000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		ArmpitLeft = 0x80000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ArmpitRight = 0x100000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		TorsoTop = 0x200000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Modesty = 0x400000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		ShortShorts = 0x800000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		SleevesSuperShortLeft = 0x1000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		SleevesSuperShortRight = 0x2000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		SleevesMidLeft = 0x4000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		SleevesMidRight = 0x8000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		PantsKneeHighLeft = 0x10000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		PantsKneeHighRight = 0x20000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		LowerThighLeft = 0x40000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		LowerThighRight = 0x80000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		HandsThumbOnlyLeft = 0x100000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		HandsThumbOnlyRight = 0x200000000000000L
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<CMFCJHIONHN> DHOHNIHIHBB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<CMFCJHIONHN> GKCHABFAGFL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<CMFCJHIONHN> EIGODDPCOMA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly KMAIJNBJDFP KKCJCMINBMF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly KMAIJNBJDFP NHGGAGJJDIH;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly KMAIJNBJDFP DPBJODHDOPK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x770CA90", Offset = "0x770BE90", VA = "0x18770CA90")]
	public static KMAIJNBJDFP JHENFMKBMEE(KMAIJNBJDFP NNBNGGEAKKG, KMAIJNBJDFP JMNBEDFGKAH)
	{
		return default(KMAIJNBJDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x770CAB0", Offset = "0x770BEB0", VA = "0x18770CAB0")]
	public static KMAIJNBJDFP PJOEIMPEGBA(KMAIJNBJDFP NFOMMCJKBHG, KMAIJNBJDFP NNLDCKIHIOM)
	{
		return default(KMAIJNBJDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x770CAA0", Offset = "0x770BEA0", VA = "0x18770CAA0")]
	public static KMAIJNBJDFP KKIIGDKDIMM(CMFCJHIONHN JIAICICNBPG, KMAIJNBJDFP DJPNIKJLNDL)
	{
		return default(KMAIJNBJDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x770CA70", Offset = "0x770BE70", VA = "0x18770CA70")]
	public static KMAIJNBJDFP JDKMNOLPOBO(CMFCJHIONHN JIAICICNBPG, KMAIJNBJDFP DJPNIKJLNDL)
	{
		return default(KMAIJNBJDFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GKOEFNFCCHK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MIIPLMAMHMN : short
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x770C4B0", Offset = "0x770B8B0", VA = "0x18770C4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x770C220", Offset = "0x770B620", VA = "0x18770C220")]
		public void KMFKNNMGFJC(FitMeshHemisphere AJDCIANALDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x770BA00", Offset = "0x770AE00", VA = "0x18770BA00")]
		public Vector3 IBLELLFJJKI(Vector2 NEMCEGFJAMM, bool NGOPAMJGHED = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x770C270", Offset = "0x770B670", VA = "0x18770C270")]
		public Vector3 MDKGGIOKBPC(Vector2 NEMCEGFJAMM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x770BEF0", Offset = "0x770B2F0", VA = "0x18770BEF0")]
		public Quaternion KDOHGNIDMMF(Vector2 NEMCEGFJAMM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x770C0B0", Offset = "0x770B4B0", VA = "0x18770C0B0")]
		public Quaternion KDOHGNIDMMF(Vector2 NEMCEGFJAMM, Vector3 KIIAPJGINPB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x770B9B0", Offset = "0x770ADB0", VA = "0x18770B9B0")]
		public Vector2 CCGKMPGIFLJ(Vector2 DJPLNIDBKIO)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x770C400", Offset = "0x770B800", VA = "0x18770C400")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DMJNKPADFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x770B700", Offset = "0x770AB00", VA = "0x18770B700")]
	public static bool AFNBADJCBOB(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x770B720", Offset = "0x770AB20", VA = "0x18770B720")]
	public static bool DIGOKFBIDFM(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x770B7C0", Offset = "0x770ABC0", VA = "0x18770B7C0")]
	public static bool NMHPAFNDLDO(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x770B7D0", Offset = "0x770ABD0", VA = "0x18770B7D0")]
	public static bool OPPLNJEAIOK(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x770B770", Offset = "0x770AB70", VA = "0x18770B770")]
	public static bool IAHDHGIMMFP(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x770B740", Offset = "0x770AB40", VA = "0x18770B740")]
	public static bool DPMKKAGBGBN(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x770B7B0", Offset = "0x770ABB0", VA = "0x18770B7B0")]
	public static bool MHKIJMBLBLP(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x770B760", Offset = "0x770AB60", VA = "0x18770B760")]
	public static bool GHPEANIBFBC(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x770B790", Offset = "0x770AB90", VA = "0x18770B790")]
	public static bool LJNCPEGHACE(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x770B780", Offset = "0x770AB80", VA = "0x18770B780")]
	public static bool LFFHHNMGEEA(this OutfitType MHKBEDJHKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CBHBLKPMCFB : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly CBHBLKPMCFB DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x770ACA0", Offset = "0x770A0A0", VA = "0x18770ACA0", Slot = "4")]
	public bool Equals(OutfitType KLIIEAEKPIB, OutfitType EBDNAPAONMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x770AD00", Offset = "0x770A100", VA = "0x18770AD00", Slot = "5")]
	public int GetHashCode(OutfitType HAFNBBNOLPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public CBHBLKPMCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum PFJPJCKDAPI
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NFDLFPBHKED
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BMDLICOBDLK
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum BBBIKDINNPL
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum HFFMPENDMEE
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PPJFLGDEIOL
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77090F0", Offset = "0x77084F0", VA = "0x1877090F0", Slot = "7")]
		public override bool Equals(AdditionalFeetData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7709120", Offset = "0x7708520", VA = "0x187709120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77091A0", Offset = "0x77085A0", VA = "0x1877091A0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x77096E0", Offset = "0x7708AE0", VA = "0x1877096E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77091E0", Offset = "0x77085E0", VA = "0x1877091E0", Slot = "7")]
		public override bool Equals(AdditionalHatData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77093D0", Offset = "0x77087D0", VA = "0x1877093D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7709530", Offset = "0x7708930", VA = "0x187709530")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7709BB0", Offset = "0x7708FB0", VA = "0x187709BB0")]
		public static bool OAMABONLGEF(OutfitType HAFNBBNOLPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77097F0", Offset = "0x7708BF0", VA = "0x1877097F0")]
		public static AdditionalOutfitTypeData GNHEPACBJCH(OutfitType HAFNBBNOLPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7709760", Offset = "0x7708B60", VA = "0x187709760", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData KNCKFHOKGJM);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4CC0510", Offset = "0x4CBF910", VA = "0x184CC0510", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T KNCKFHOKGJM);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, ENPBFLBFDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1043BA0", Offset = "0x1042FA0", VA = "0x181043BA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x770ABD0", Offset = "0x7709FD0", VA = "0x18770ABD0", Slot = "7")]
		public override bool Equals(BeardData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x770ABF0", Offset = "0x7709FF0", VA = "0x18770ABF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x770AC60", Offset = "0x770A060", VA = "0x18770AC60")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, ENPBFLBFDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB583E0", Offset = "0xB577E0", VA = "0x180B583E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B27C0", Offset = "0x9B1BC0", VA = "0x1809B27C0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC71970", Offset = "0xC70D70", VA = "0x180C71970")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x770C9E0", Offset = "0x770BDE0", VA = "0x18770C9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x770C630", Offset = "0x770BA30", VA = "0x18770C630", Slot = "7")]
		public override bool Equals(HairData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x770C820", Offset = "0x770BC20", VA = "0x18770C820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x770C920", Offset = "0x770BD20", VA = "0x18770C920")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ENPBFLBFDGA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool ELHKKJPGFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle IAKKLPNGALL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HDFNICIBOHI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x770C560", Offset = "0x770B960", VA = "0x18770C560")]
	public static IDINMFOPJOG IAICBAMMNHD(this OutfitType MHKBEDJHKOJ, AvatarItemSidednessEquipType FBMKCIJLDBE = AvatarItemSidednessEquipType.Left)
	{
		return default(IDINMFOPJOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x770C5E0", Offset = "0x770B9E0", VA = "0x18770C5E0")]
	public static IDINMFOPJOG NBBLPPJDKNE(this IDINMFOPJOG OFBICLFFJFE)
	{
		return default(IDINMFOPJOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x770C4F0", Offset = "0x770B8F0", VA = "0x18770C4F0")]
	public static bool GAEOCACNMOL(this OutfitType MHKBEDJHKOJ, IDINMFOPJOG OFBICLFFJFE)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NAEOKFPNOMM
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x770CC90", Offset = "0x770C090", VA = "0x18770CC90")]
	public static bool KMNLLLGIMJI(this AvatarItemSidednessEquipType FBMKCIJLDBE, IDINMFOPJOG OFBICLFFJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x770CCC0", Offset = "0x770C0C0", VA = "0x18770CCC0")]
	public static bool MAMJCKPDKID(this AvatarItemSidednessEquipType MFJAFPKLIPA, IDINMFOPJOG OFBICLFFJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x770CC50", Offset = "0x770C050", VA = "0x18770CC50")]
	public static bool IPLJEEAFHAN(this AvatarItemSidednessEquipType JEHGCGBKCFP, AvatarItemSidednessEquipType IECLIFAIMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x770CC70", Offset = "0x770C070", VA = "0x18770CC70")]
	public static AvatarItemSidednessEquipType JCAAIJMLDIF(this AvatarItemSidednessEquipType JEHGCGBKCFP)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum FCLEDMNFPOK
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class PJCCKFNBHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x770CD00", Offset = "0x770C100", VA = "0x18770CD00")]
	private static FCLEDMNFPOK IIMJGGCPAAO(this OutfitType MHKBEDJHKOJ)
	{
		return default(FCLEDMNFPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x770CE70", Offset = "0x770C270", VA = "0x18770CE70")]
	public static OutfitSlotFlags KFFBBMBLDAJ(this OutfitType MHKBEDJHKOJ)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x770CCF0", Offset = "0x770C0F0", VA = "0x18770CCF0")]
	public static bool CIDIDPBNBBO(this OutfitSlotFlags IJBEGCIHFJC, OutfitSlotFlags IHCDMFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x770CFE0", Offset = "0x770C3E0", VA = "0x18770CFE0")]
	public static bool KMJJMJMCOCF(this OutfitType MHKBEDJHKOJ, OutfitSlotFlags NMKJMEJMIBA)
	{
		return default(bool);
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
