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
public interface JCELHDLFJOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float HJEOHDGEGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float PLNNJBCEOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float MIMMKPONJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float JGDMIBKGPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float ODDCOLFCIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float LNDCMKEKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NLJNPNIJCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LBJLKJJDBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JGIAKHIMHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HBNCDECKCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float JLIGMMJIMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float MEDILMOEACN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float ELIHAECOODB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float KPGFDDIADOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float HKEGJCLGEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float GMJMOEGHHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 MNFIIFNAOAH(Vector3 MAICEANCLKF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 KILLOOIGEEC(Vector3 DNPCFDPKGJJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 GDDABEGKFDP();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : JCELHDLFJOA
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
			[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F70D0", VA = "0x1809F86D0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD03B10", Offset = "0xD02510", VA = "0x180D03B10", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x91E840", Offset = "0x91D240", VA = "0x18091E840", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA35360", Offset = "0xA33D60", VA = "0x180A35360", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD10", Offset = "0x9EB710", VA = "0x1809ECD10", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x923030", Offset = "0x921A30", VA = "0x180923030", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8F4510", Offset = "0x8F2F10", VA = "0x1808F4510", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B39A0", Offset = "0x8B23A0", VA = "0x1808B39A0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A4FEE0", Offset = "0x6A4E8E0", VA = "0x186A4FEE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA35330", Offset = "0xA33D30", VA = "0x180A35330", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9ECC90", Offset = "0x9EB690", VA = "0x1809ECC90", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x923010", Offset = "0x921A10", VA = "0x180923010", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD30", Offset = "0x9EB730", VA = "0x1809ECD30", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x907940", Offset = "0x906340", VA = "0x180907940", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2B0", Offset = "0xA3CCB0", VA = "0x180A3E2B0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F8B0", Offset = "0x6A4E2B0", VA = "0x186A4F8B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA3E320", Offset = "0xA3CD20", VA = "0x180A3E320", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA3E360", Offset = "0xA3CD60", VA = "0x180A3E360", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA3E350", Offset = "0xA3CD50", VA = "0x180A3E350", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6A50480", Offset = "0x6A4EE80", VA = "0x186A50480")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6A504C0", Offset = "0x6A4EEC0", VA = "0x186A504C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6A504A0", Offset = "0x6A4EEA0", VA = "0x186A504A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6A504E0", Offset = "0x6A4EEE0", VA = "0x186A504E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A503F0", Offset = "0x6A4EDF0", VA = "0x186A503F0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FF00", Offset = "0x6A4E900", VA = "0x186A4FF00")]
		public IDDKLPOMBMA JJMNCCDGNGO(IDDKLPOMBMA EAHPLDCDPLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F8B0", Offset = "0x6A4E2B0", VA = "0x186A4F8B0", Slot = "25")]
		public Vector3 CDLGDKLEGFF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FEE0", Offset = "0x6A4E8E0", VA = "0x186A4FEE0", Slot = "22")]
		public Vector3 GDDABEGKFDP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A502D0", Offset = "0x6A4ECD0", VA = "0x186A502D0", Slot = "20")]
		public Vector3 MNFIIFNAOAH(Vector3 MAICEANCLKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A501E0", Offset = "0x6A4EBE0", VA = "0x186A501E0", Slot = "21")]
		public Vector3 KILLOOIGEEC(Vector3 DNPCFDPKGJJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F8D0", Offset = "0x6A4E2D0", VA = "0x186A4F8D0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F9E0", Offset = "0x6A4E3E0", VA = "0x186A4F9E0")]
		protected bool FNBPDCLIINK(AnchorParamsRestrictions AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A50260", Offset = "0x6A4EC60", VA = "0x186A50260")]
		[CompilerGenerated]
		internal static bool MKOEMGPIFGC(float GPKBBMJKBAE, float AAMOGMLMOOI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FHCKECJEKJH
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
public enum MNJHFLENAKB
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HKINHDPIENF
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
public enum JBFBPEMCFCB
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ModernBeanBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HNEBDPCIMBB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A51180", Offset = "0x6A4FB80", VA = "0x186A51180")]
	public static bool LOAEADAFNNE(this FHCKECJEKJH LIJAGIJAJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A51080", Offset = "0x6A4FA80", VA = "0x186A51080")]
	public static LJIAAKKJMFC GHKIKKMIFAB(this JBFBPEMCFCB ILDPBGPGAJP)
	{
		return default(LJIAAKKJMFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A51100", Offset = "0x6A4FB00", VA = "0x186A51100")]
	public static JBFBPEMCFCB LNAMCMKDPNK(this LJIAAKKJMFC ILDPBGPGAJP)
	{
		return default(JBFBPEMCFCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MJONKEEGKHL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IMJMLAAIFLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum OANEACHHLDN
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static OANEACHHLDN DJMEBNGLEON;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static OANEACHHLDN HLPONFDLEEC;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A51770", Offset = "0x6A50170", VA = "0x186A51770")]
	public static OANEACHHLDN MGANNFFFLJB(OANEACHHLDN MCNFHCGPJEC, OANEACHHLDN LAFIFMKHGAH)
	{
		return default(OANEACHHLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A516D0", Offset = "0x6A500D0", VA = "0x186A516D0")]
	public static OANEACHHLDN ABJPBAEADOJ(OANEACHHLDN GMNMMBIPLEE, OANEACHHLDN LDKHGBECKJJ)
	{
		return default(OANEACHHLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A516E0", Offset = "0x6A500E0", VA = "0x186A516E0")]
	public static OANEACHHLDN FJDLAEEEEFO(IMJMLAAIFLG EIBLCHCPLOB, OANEACHHLDN CICIJINDELD)
	{
		return default(OANEACHHLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A516F0", Offset = "0x6A500F0", VA = "0x186A516F0")]
	public static OANEACHHLDN LMCGBCAHMMM(IMJMLAAIFLG EIBLCHCPLOB, OANEACHHLDN CICIJINDELD)
	{
		return default(OANEACHHLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A51780", Offset = "0x6A50180", VA = "0x186A51780")]
	public static bool ODLCJJCACID(this OANEACHHLDN NOHDHBENFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A51700", Offset = "0x6A50100", VA = "0x186A51700")]
	public static bool MFBOBMEFGAM(this OANEACHHLDN NOHDHBENFGP)
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
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6A51070", Offset = "0x6A4FA70", VA = "0x186A51070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A506B0", Offset = "0x6A4F0B0", VA = "0x186A506B0")]
		public void GIFCHLFNMML(FitMeshHemisphere DLAHMDPMNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A50700", Offset = "0x6A4F100", VA = "0x186A50700")]
		public Vector3 IBDCFFGNLFJ(Vector2 NEOEJHMBGMN, bool GKJGCICDBOK = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A50AB0", Offset = "0x6A4F4B0", VA = "0x186A50AB0")]
		public Vector3 IHAMNJCMFIK(Vector2 NEOEJHMBGMN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A50CF0", Offset = "0x6A4F6F0", VA = "0x186A50CF0")]
		public Quaternion PGOPCBEIHIG(Vector2 NEOEJHMBGMN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A50B70", Offset = "0x6A4F570", VA = "0x186A50B70")]
		public Quaternion PGOPCBEIHIG(Vector2 NEOEJHMBGMN, Vector3 HLMOJEMPEHG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A50B10", Offset = "0x6A4F510", VA = "0x186A50B10")]
		public Vector2 MNMELKOFBJC(Vector2 JCMOOBJCHNG)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A50FD0", Offset = "0x6A4F9D0", VA = "0x186A50FD0")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CKHPBDHOELP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A50630", Offset = "0x6A4F030", VA = "0x186A50630")]
	public static bool INCPCJHGODI(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A50610", Offset = "0x6A4F010", VA = "0x186A50610")]
	public static bool IFDCICOCCKE(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A50680", Offset = "0x6A4F080", VA = "0x186A50680")]
	public static bool PBMPBEKOLLC(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A50650", Offset = "0x6A4F050", VA = "0x186A50650")]
	public static bool MLOBLBNGEBN(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A505E0", Offset = "0x6A4EFE0", VA = "0x186A505E0")]
	public static bool BONJKMDEFCG(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A505F0", Offset = "0x6A4EFF0", VA = "0x186A505F0")]
	public static bool FBLOGCLPKCI(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A50660", Offset = "0x6A4F060", VA = "0x186A50660")]
	public static bool OGGGHHGBIKI(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A505D0", Offset = "0x6A4EFD0", VA = "0x186A505D0")]
	public static bool BIEHGCECBKD(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A50690", Offset = "0x6A4F090", VA = "0x186A50690")]
	public static bool PNAEIAINCKO(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A50670", Offset = "0x6A4F070", VA = "0x186A50670")]
	public static bool PAFANJFMHNP(this OutfitType HHHAICHCELH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JPHAEDIMBCH : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly JPHAEDIMBCH LPENGNKGBMO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A515D0", Offset = "0x6A4FFD0", VA = "0x186A515D0", Slot = "4")]
	public bool Equals(OutfitType AAKJJNHFIOH, OutfitType PHLJHJEHEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A51630", Offset = "0x6A50030", VA = "0x186A51630", Slot = "5")]
	public int GetHashCode(OutfitType NNCMOPPBEEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public JPHAEDIMBCH()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FHCKECJEKJH helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F3D0", Offset = "0x6A4DDD0", VA = "0x186A4F3D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EEE0", Offset = "0x6A4D8E0", VA = "0x186A4EEE0", Slot = "8")]
		public override bool Equals(AdditionalHatData AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F0D0", Offset = "0x6A4DAD0", VA = "0x186A4F0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F230", Offset = "0x6A4DC30", VA = "0x186A4F230")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F4E0", Offset = "0x6A4DEE0", VA = "0x186A4F4E0")]
		public static bool GBNBLNLGBIL(OutfitType NNCMOPPBEEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F500", Offset = "0x6A4DF00", VA = "0x186A4F500")]
		public static AdditionalOutfitTypeData IFAFEFDLIPC(OutfitType NNCMOPPBEEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F450", Offset = "0x6A4DE50", VA = "0x186A4F450", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData AIPFCMFLDKG);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F830", Offset = "0x6A4E230", VA = "0x186A4F830", Slot = "6")]
		public virtual AdditionalOutfitTypeData LNLMPMKCFAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x412C430", Offset = "0x412AE30", VA = "0x18412C430", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T AIPFCMFLDKG);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, IHLHPIIEFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HKINHDPIENF beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xACC530", Offset = "0xACAF30", VA = "0x180ACC530", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public HKINHDPIENF PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "10")]
			get
			{
				return default(HKINHDPIENF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A50500", Offset = "0x6A4EF00", VA = "0x186A50500", Slot = "8")]
		public override bool Equals(BeardData AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A50520", Offset = "0x6A4EF20", VA = "0x186A50520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A50590", Offset = "0x6A4EF90", VA = "0x186A50590")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, IHLHPIIEFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public HKINHDPIENF hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MNJHFLENAKB helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x912E40", Offset = "0x911840", VA = "0x180912E40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public HKINHDPIENF PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8A2530", Offset = "0x8A0F30", VA = "0x1808A2530", Slot = "10")]
			get
			{
				return default(HKINHDPIENF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6A51540", Offset = "0x6A4FF40", VA = "0x186A51540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A51190", Offset = "0x6A4FB90", VA = "0x186A51190", Slot = "8")]
		public override bool Equals(HairData AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A51380", Offset = "0x6A4FD80", VA = "0x186A51380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A51480", Offset = "0x6A4FE80", VA = "0x186A51480")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IHLHPIIEFAO
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FMJPGOLIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HKINHDPIENF LENMGMMFALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
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
