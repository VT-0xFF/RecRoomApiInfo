using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KNAOMEEHGKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float PPKJBBLLDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float DNLAFAJNNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NMBIKFNBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float ADKOJKPCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float BLLDMIJOJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float LNBOMLLGKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MEIDJHLDNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KJHOOJIFGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float PILLHIOGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HLCIIIBIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float LOGDJFDMDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float ADJIMMABHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float MHKBBBHCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float MCLHMGHLLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float HBLGJCDIDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float BAMALBOOPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 CLLOJFMFAEF(Vector3 FGHENCLBGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 GNBFBNCNBLE(Vector3 JMFFGIKDDDM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 GEAENKFGJMC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : KNAOMEEHGKJ
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
			[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4F10", VA = "0x1808A6510", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB7F4B0", Offset = "0xB7DEB0", VA = "0x180B7F4B0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD4D0", VA = "0x1808BEAD0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD490", VA = "0x1808BEA90", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAC0", Offset = "0x8BD4C0", VA = "0x1808BEAC0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAA0", Offset = "0x8BD4A0", VA = "0x1808BEAA0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA80", Offset = "0x8BD480", VA = "0x1808BEA80", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x882340", Offset = "0x880D40", VA = "0x180882340", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6782A40", Offset = "0x6781440", VA = "0x186782A40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA20", Offset = "0x8BD420", VA = "0x1808BEA20", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF240", Offset = "0x8BDC40", VA = "0x1808BF240", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA40", Offset = "0x8BD440", VA = "0x1808BEA40", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA50", Offset = "0x8BD450", VA = "0x1808BEA50", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8BF140", Offset = "0x8BDB40", VA = "0x1808BF140", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8BF130", Offset = "0x8BDB30", VA = "0x1808BF130", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6783050", Offset = "0x6781A50", VA = "0x186783050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1C0", Offset = "0x8BDBC0", VA = "0x1808BF1C0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BF210", Offset = "0x8BDC10", VA = "0x1808BF210", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1F0", Offset = "0x8BDBF0", VA = "0x1808BF1F0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x86D960", Offset = "0x86C360", VA = "0x18086D960", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67834B0", Offset = "0x6781EB0", VA = "0x1867834B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67834F0", Offset = "0x6781EF0", VA = "0x1867834F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67834D0", Offset = "0x6781ED0", VA = "0x1867834D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6783510", Offset = "0x6781F10", VA = "0x186783510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6783420", Offset = "0x6781E20", VA = "0x186783420")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6783070", Offset = "0x6781A70", VA = "0x186783070")]
		public GOLAHOGMBDI PLMKOMNOEAO(GOLAHOGMBDI MPLMFJMGIEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6783050", Offset = "0x6781A50", VA = "0x186783050", Slot = "25")]
		public Vector3 OJJMJCFFDBP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6782A40", Offset = "0x6781440", VA = "0x186782A40", Slot = "22")]
		public Vector3 GEAENKFGJMC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67828C0", Offset = "0x67812C0", VA = "0x1867828C0", Slot = "20")]
		public Vector3 CLLOJFMFAEF(Vector3 FGHENCLBGFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6782A60", Offset = "0x6781460", VA = "0x186782A60", Slot = "21")]
		public Vector3 GNBFBNCNBLE(Vector3 JMFFGIKDDDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6782930", Offset = "0x6781330", VA = "0x186782930", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6782B50", Offset = "0x6781550", VA = "0x186782B50")]
		protected bool KDJLOMMBFFK(AnchorParamsRestrictions OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6782AE0", Offset = "0x67814E0", VA = "0x186782AE0")]
		[CompilerGenerated]
		internal static bool IJOALGKLPIN(float MLFGLJKBOIG, float GANEOONFJPD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IDDBFDIIBIC
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NEPMABKJNOA
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DOLODLAIBPC
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NoPattern,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Curly,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Braid
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GPNFJCLHKIK
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DHAMOIAJLIP
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6783740", Offset = "0x6782140", VA = "0x186783740")]
	public static bool GJIBFOAPIEL(this IDDBFDIIBIC LKFGNGOMJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67836D0", Offset = "0x67820D0", VA = "0x1867836D0")]
	public static FCPIIIBEPDH BEKOHJOLEHE(this GPNFJCLHKIK BLIHMMPCOEE)
	{
		return default(FCPIIIBEPDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DPBKAJAMMON
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum KFHCNCLMBEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum JBNKIJKKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static JBNKIJKKBDP HPDNDCKIPBD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static JBNKIJKKBDP AHEBKFOKFMA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3BC0", Offset = "0x1DA25C0", VA = "0x181DA3BC0")]
	public static JBNKIJKKBDP AEOKPJAFLAB(JBNKIJKKBDP PHEKANDALGM, JBNKIJKKBDP DAJECGJENKC)
	{
		return default(JBNKIJKKBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3BD0", Offset = "0x1DA25D0", VA = "0x181DA3BD0")]
	public static JBNKIJKKBDP GOCBAOMPIJO(JBNKIJKKBDP HMLDKECCCBE, JBNKIJKKBDP BNCBANPBHJE)
	{
		return default(JBNKIJKKBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67837D0", Offset = "0x67821D0", VA = "0x1867837D0")]
	public static JBNKIJKKBDP DBILHJKLNGE(KFHCNCLMBEE BPLODFCBLBP, JBNKIJKKBDP LOCGPCNJDLF)
	{
		return default(JBNKIJKKBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67837C0", Offset = "0x67821C0", VA = "0x1867837C0")]
	public static JBNKIJKKBDP CLIKEIODBKE(KFHCNCLMBEE BPLODFCBLBP, JBNKIJKKBDP LOCGPCNJDLF)
	{
		return default(JBNKIJKKBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6783750", Offset = "0x6782150", VA = "0x186783750")]
	public static bool CIOLPOGCACN(this JBNKIJKKBDP LPNIGDLFGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67837E0", Offset = "0x67821E0", VA = "0x1867837E0")]
	public static bool NHCGGGBPOCA(this JBNKIJKKBDP LPNIGDLFGIN)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6784290", Offset = "0x6782C90", VA = "0x186784290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6784060", Offset = "0x6782A60", VA = "0x186784060")]
		public void PGOJAEAOGOP(FitMeshHemisphere DDNFLFDEOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6783CA0", Offset = "0x67826A0", VA = "0x186783CA0")]
		public Vector3 OHCLFMDOFHL(Vector2 ODLAMDMECAB, bool DLFJPCCMPEF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6783C40", Offset = "0x6782640", VA = "0x186783C40")]
		public Vector3 OGDLHPKAHFL(Vector2 ODLAMDMECAB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6783A20", Offset = "0x6782420", VA = "0x186783A20")]
		public Quaternion JKCFJCHKIEP(Vector2 ODLAMDMECAB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67838A0", Offset = "0x67822A0", VA = "0x1867838A0")]
		public Quaternion JKCFJCHKIEP(Vector2 ODLAMDMECAB, Vector3 HEHNBNFEJPN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6783BE0", Offset = "0x67825E0", VA = "0x186783BE0")]
		public Vector2 LIIFPDBNPGD(Vector2 IKMIIPIICMA)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67841E0", Offset = "0x6782BE0", VA = "0x1867841E0")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BMAAKMFNHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6783540", Offset = "0x6781F40", VA = "0x186783540")]
	public static bool CLBFNILIBMF(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6783560", Offset = "0x6781F60", VA = "0x186783560")]
	public static bool DJFNKOLNCMC(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6783590", Offset = "0x6781F90", VA = "0x186783590")]
	public static bool GCADJNILNNN(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67835A0", Offset = "0x6781FA0", VA = "0x1867835A0")]
	public static bool JDIICDABDIB(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6783530", Offset = "0x6781F30", VA = "0x186783530")]
	public static bool BAFAHICOEFH(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67835B0", Offset = "0x6781FB0", VA = "0x1867835B0")]
	public static bool KHGKFPHOONH(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67835F0", Offset = "0x6781FF0", VA = "0x1867835F0")]
	public static bool LNLJPLNEKNM(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6783580", Offset = "0x6781F80", VA = "0x186783580")]
	public static bool EGEJHHBGHEB(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67835D0", Offset = "0x6781FD0", VA = "0x1867835D0")]
	public static bool LMMDMLMBEPN(this OutfitType FFBODCLPMDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MOKAIPOJOMJ : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly MOKAIPOJOMJ MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67846E0", Offset = "0x67830E0", VA = "0x1867846E0", Slot = "4")]
	public bool Equals(OutfitType ELJIMJMJJDM, OutfitType CIDKODIEANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6784740", Offset = "0x6783140", VA = "0x186784740", Slot = "5")]
	public int GetHashCode(OutfitType NCMHJNKFAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MOKAIPOJOMJ()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IDDBFDIIBIC helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x67823D0", Offset = "0x6780DD0", VA = "0x1867823D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6781ED0", Offset = "0x67808D0", VA = "0x186781ED0", Slot = "8")]
		public override bool Equals(AdditionalHatData OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67820C0", Offset = "0x6780AC0", VA = "0x1867820C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6782220", Offset = "0x6780C20", VA = "0x186782220")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67828A0", Offset = "0x67812A0", VA = "0x1867828A0")]
		public static bool NFJDIHOJCNF(OutfitType NCMHJNKFAGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6782560", Offset = "0x6780F60", VA = "0x186782560")]
		public static AdditionalOutfitTypeData JGIIBNEOBDO(OutfitType NCMHJNKFAGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6782450", Offset = "0x6780E50", VA = "0x186782450", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData OKGBBGMIACH);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67824E0", Offset = "0x6780EE0", VA = "0x1867824E0", Slot = "6")]
		public virtual AdditionalOutfitTypeData IJDMAMHKEEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A090", Offset = "0x3F48A90", VA = "0x183F4A090", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T OKGBBGMIACH);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, PKHNJKHMHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DOLODLAIBPC beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x91FDB0", Offset = "0x91E7B0", VA = "0x18091FDB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public DOLODLAIBPC PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0", Slot = "10")]
			get
			{
				return default(DOLODLAIBPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6783600", Offset = "0x6782000", VA = "0x186783600", Slot = "8")]
		public override bool Equals(BeardData OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6783620", Offset = "0x6782020", VA = "0x186783620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6783690", Offset = "0x6782090", VA = "0x186783690")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, PKHNJKHMHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DOLODLAIBPC hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NEPMABKJNOA helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3B0", Offset = "0x9BADB0", VA = "0x1809BC3B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public DOLODLAIBPC PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x870760", Offset = "0x86F160", VA = "0x180870760", Slot = "10")]
			get
			{
				return default(DOLODLAIBPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6784650", Offset = "0x6783050", VA = "0x186784650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67842A0", Offset = "0x6782CA0", VA = "0x1867842A0", Slot = "8")]
		public override bool Equals(HairData OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6784490", Offset = "0x6782E90", VA = "0x186784490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6784590", Offset = "0x6782F90", VA = "0x186784590")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PKHNJKHMHAC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool OIKNBEOBLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DOLODLAIBPC CMIAHBMHBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
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
