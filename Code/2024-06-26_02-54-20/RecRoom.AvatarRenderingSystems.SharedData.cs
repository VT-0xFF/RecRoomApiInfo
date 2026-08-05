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
public interface IJPBHNFONGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float BBALIAPAKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float MNJHPHAFGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float HMKBHKJNGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float MEJMPGNFOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float LHLLCLMHGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float BLFGACDMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float APHDNELOHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float HCJGEEAMNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CJJHHFHKPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float OHGJINIIFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float FAGOKHADGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KAPCALKGBED
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float IEMIHLIAJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float MBHHKJILMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float EOLICLHFEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float DLFNEBMHDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 NJOMKEABCHL(Vector3 DIPLBFGLHMA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 NDFNGMMIBLO(Vector3 OJPHCGNGCNC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 EIEPNCMJEID();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : IJPBHNFONGH
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
			[Cpp2IlInjected.Address(RVA = "0x8B5660", Offset = "0x8B3C60", VA = "0x1808B5660", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB8B450", Offset = "0xB89A50", VA = "0x180B8B450", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC420", VA = "0x1808CDE20", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDE0", Offset = "0x8CC3E0", VA = "0x1808CDDE0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CDE10", Offset = "0x8CC410", VA = "0x1808CDE10", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDF0", Offset = "0x8CC3F0", VA = "0x1808CDDF0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDD0", Offset = "0x8CC3D0", VA = "0x1808CDDD0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x892660", Offset = "0x890C60", VA = "0x180892660", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67F12B0", Offset = "0x67EF8B0", VA = "0x1867F12B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8CDD70", Offset = "0x8CC370", VA = "0x1808CDD70", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CE590", Offset = "0x8CCB90", VA = "0x1808CE590", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8CDD90", Offset = "0x8CC390", VA = "0x1808CDD90", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDA0", Offset = "0x8CC3A0", VA = "0x1808CDDA0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8CE490", Offset = "0x8CCA90", VA = "0x1808CE490", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CE480", Offset = "0x8CCA80", VA = "0x1808CE480", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67F16D0", Offset = "0x67EFCD0", VA = "0x1867F16D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8CE510", Offset = "0x8CCB10", VA = "0x1808CE510", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8CE560", Offset = "0x8CCB60", VA = "0x1808CE560", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8CE540", Offset = "0x8CCB40", VA = "0x1808CE540", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87BEF0", VA = "0x18087D8F0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67F19A0", Offset = "0x67EFFA0", VA = "0x1867F19A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67F19E0", Offset = "0x67EFFE0", VA = "0x1867F19E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67F19C0", Offset = "0x67EFFC0", VA = "0x1867F19C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x67F1A00", Offset = "0x67F0000", VA = "0x1867F1A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67F1910", Offset = "0x67EFF10", VA = "0x1867F1910")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67F13E0", Offset = "0x67EF9E0", VA = "0x1867F13E0")]
		public MPNIGMOKBGH KEFHKGNCCPL(MPNIGMOKBGH OIPHDLABBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67F16D0", Offset = "0x67EFCD0", VA = "0x1867F16D0", Slot = "25")]
		public Vector3 KEMFHAOFIPC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67F12B0", Offset = "0x67EF8B0", VA = "0x1867F12B0", Slot = "22")]
		public Vector3 EIEPNCMJEID()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67F17E0", Offset = "0x67EFDE0", VA = "0x1867F17E0", Slot = "20")]
		public Vector3 NJOMKEABCHL(Vector3 DIPLBFGLHMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67F16F0", Offset = "0x67EFCF0", VA = "0x1867F16F0", Slot = "21")]
		public Vector3 NDFNGMMIBLO(Vector3 OJPHCGNGCNC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67F12D0", Offset = "0x67EF8D0", VA = "0x1867F12D0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67F0DB0", Offset = "0x67EF3B0", VA = "0x1867F0DB0")]
		protected bool EHCCFIAHGOE(AnchorParamsRestrictions LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67F1770", Offset = "0x67EFD70", VA = "0x1867F1770")]
		[CompilerGenerated]
		internal static bool NHJFOKNCIBL(float FAGKOOGCGBH, float HEOHCJKCOLM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FPDBCNOHKKM
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
public enum AHBOGPIGBGE
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HAGIKPAIDHM
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
public enum FLHLKBBPLLO
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AGJBHFBFCMG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67F03C0", Offset = "0x67EE9C0", VA = "0x1867F03C0")]
	public static bool DGPMBOLAFNG(this FPDBCNOHKKM KCALHPCNGAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BIMEIEHNBAC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FOAMPLAHPBO
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
	public enum FNGDOONFPID
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
	public static FNGDOONFPID MKFHDNDNLPD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static FNGDOONFPID IEIAAFICPEB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A570", Offset = "0x1D98B70", VA = "0x181D9A570")]
	public static FNGDOONFPID KADFJAKPEFB(FNGDOONFPID EBHBPOMBICN, FNGDOONFPID BOHFBMDEGMK)
	{
		return default(FNGDOONFPID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A560", Offset = "0x1D98B60", VA = "0x181D9A560")]
	public static FNGDOONFPID ILEJJGOCAFD(FNGDOONFPID NEECAIFFOFI, FNGDOONFPID OAKONJIAKJA)
	{
		return default(FNGDOONFPID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67F1A20", Offset = "0x67F0020", VA = "0x1867F1A20")]
	public static FNGDOONFPID DFAAHGLLKOL(FOAMPLAHPBO GOHJHKPEKKC, FNGDOONFPID NBLMHNLAOKE)
	{
		return default(FNGDOONFPID);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67F1AA0", Offset = "0x67F00A0", VA = "0x1867F1AA0")]
	public static FNGDOONFPID GDDKJEMBPOF(FOAMPLAHPBO GOHJHKPEKKC, FNGDOONFPID NBLMHNLAOKE)
	{
		return default(FNGDOONFPID);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67F1AB0", Offset = "0x67F00B0", VA = "0x1867F1AB0")]
	public static bool PJHEHPGALHI(this FNGDOONFPID AFPLHBFNDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67F1A30", Offset = "0x67F0030", VA = "0x1867F1A30")]
	public static bool EJKHLOFILCE(this FNGDOONFPID AFPLHBFNDBM)
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
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x67F2630", Offset = "0x67F0C30", VA = "0x1867F2630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67F1FE0", Offset = "0x67F05E0", VA = "0x1867F1FE0")]
		public void KLFLNGFKHJO(FitMeshHemisphere KJNNGLCGEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67F2090", Offset = "0x67F0690", VA = "0x1867F2090")]
		public Vector3 LPLEFOELHBP(Vector2 NLOAKGCNEMF, bool LGJIOAEPNON = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67F1F80", Offset = "0x67F0580", VA = "0x1867F1F80")]
		public Vector3 GNKAMBLHEKP(Vector2 NLOAKGCNEMF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67F1DC0", Offset = "0x67F03C0", VA = "0x1867F1DC0")]
		public Quaternion EFJJIOKHNME(Vector2 NLOAKGCNEMF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67F1C40", Offset = "0x67F0240", VA = "0x1867F1C40")]
		public Quaternion EFJJIOKHNME(Vector2 NLOAKGCNEMF, Vector3 LCOFBNBBIFD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67F2030", Offset = "0x67F0630", VA = "0x1867F2030")]
		public Vector2 LGOAHDPBNHO(Vector2 KEJKHPLGJIB)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x67F2580", Offset = "0x67F0B80", VA = "0x1867F2580")]
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
public static class IGKJJFABJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67F2B30", Offset = "0x67F1130", VA = "0x1867F2B30")]
	public static bool KOGLOBGLAAO(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AA0", Offset = "0x67F10A0", VA = "0x1867F2AA0")]
	public static bool AIKMOIEAOIE(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AF0", Offset = "0x67F10F0", VA = "0x1867F2AF0")]
	public static bool FKLEMFMPBGE(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2B00", Offset = "0x67F1100", VA = "0x1867F2B00")]
	public static bool IIFKNNAMDMH(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AC0", Offset = "0x67F10C0", VA = "0x1867F2AC0")]
	public static bool BBHEEEPJCJA(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67F2A80", Offset = "0x67F1080", VA = "0x1867F2A80")]
	public static bool AACDODDGGDE(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AD0", Offset = "0x67F10D0", VA = "0x1867F2AD0")]
	public static bool CEJANCMPJCL(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AE0", Offset = "0x67F10E0", VA = "0x1867F2AE0")]
	public static bool FEKBFIOGHIF(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67F2B10", Offset = "0x67F1110", VA = "0x1867F2B10")]
	public static bool KMNGKBAGJAA(this OutfitType OLLAIFGKOPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PELNDAHCOMJ : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly PELNDAHCOMJ IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67F2B50", Offset = "0x67F1150", VA = "0x1867F2B50", Slot = "4")]
	public bool Equals(OutfitType PKIOKGCGCAD, OutfitType JLFALPMGIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67F2BB0", Offset = "0x67F11B0", VA = "0x1867F2BB0", Slot = "5")]
	public int GetHashCode(OutfitType PBLNJHEPKAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public PELNDAHCOMJ()
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
		public FPDBCNOHKKM helmetHairMode;

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
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x67F08D0", Offset = "0x67EEED0", VA = "0x1867F08D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67F03D0", Offset = "0x67EE9D0", VA = "0x1867F03D0", Slot = "8")]
		public override bool Equals(AdditionalHatData LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67F05C0", Offset = "0x67EEBC0", VA = "0x1867F05C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67F0720", Offset = "0x67EED20", VA = "0x1867F0720")]
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

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67F0A50", Offset = "0x67EF050", VA = "0x1867F0A50")]
		public static bool FIDJEHPGKKM(OutfitType PBLNJHEPKAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67F0A70", Offset = "0x67EF070", VA = "0x1867F0A70")]
		public static AdditionalOutfitTypeData GIGNPOIHFIA(OutfitType PBLNJHEPKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67F0950", Offset = "0x67EEF50", VA = "0x1867F0950", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LJAAPFIIPOF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x67F09E0", Offset = "0x67EEFE0", VA = "0x1867F09E0", Slot = "6")]
		public virtual AdditionalOutfitTypeData FCBOIHHPCCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4132830", Offset = "0x4130E30", VA = "0x184132830", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T LJAAPFIIPOF);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, GEKKLMIFDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HAGIKPAIDHM beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x92FCB0", Offset = "0x92E2B0", VA = "0x18092FCB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public HAGIKPAIDHM PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0", Slot = "10")]
			get
			{
				return default(HAGIKPAIDHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67F1B70", Offset = "0x67F0170", VA = "0x1867F1B70", Slot = "8")]
		public override bool Equals(BeardData LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x67F1B90", Offset = "0x67F0190", VA = "0x1867F1B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x67F1C00", Offset = "0x67F0200", VA = "0x1867F1C00")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, GEKKLMIFDDL
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
		public HAGIKPAIDHM hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AHBOGPIGBGE helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9C78B0", Offset = "0x9C5EB0", VA = "0x1809C78B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public HAGIKPAIDHM PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x880980", Offset = "0x87EF80", VA = "0x180880980", Slot = "10")]
			get
			{
				return default(HAGIKPAIDHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x67F29F0", Offset = "0x67F0FF0", VA = "0x1867F29F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67F2640", Offset = "0x67F0C40", VA = "0x1867F2640", Slot = "8")]
		public override bool Equals(HairData LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67F2830", Offset = "0x67F0E30", VA = "0x1867F2830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67F2930", Offset = "0x67F0F30", VA = "0x1867F2930")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GEKKLMIFDDL
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FCNBDANJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HAGIKPAIDHM HGEOPHHMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
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
