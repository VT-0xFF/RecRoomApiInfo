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
public interface ELFKCADAIPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float HDLBKGHIKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float GJDLOFFNKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float CFHMGDBPHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float IHNNNGNHCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float MFPNGDLBKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float CKHOAAIHHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PINLFMEMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BMFENHMCMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CCBJJIGDKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float EIJCGKPFLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GKBGMGJBMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float IKLGAPPKAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float KCALKMPMENC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float FFLHBFJDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float NMDDIKEKFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float EJPMOLMIDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 AHGLHMLCIEC(Vector3 NFIDKIBCEOJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 OJJPDPLGGGM(Vector3 HKJBPCFKHJE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 PHGNNKJHEHO();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : ELFKCADAIPA
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
			[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB97590", Offset = "0xB96790", VA = "0x180B97590", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xC30C00", Offset = "0xC2FE00", VA = "0x180C30C00", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEFE640", Offset = "0xEFD840", VA = "0x180EFE640", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xDEFA00", Offset = "0xDEEC00", VA = "0x180DEFA00", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAF7320", Offset = "0xAF6520", VA = "0x180AF7320", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x992670", Offset = "0x991870", VA = "0x180992670", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7489580", Offset = "0x7488780", VA = "0x187489580")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7489720", Offset = "0x7488920", VA = "0x187489720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7489700", Offset = "0x7488900", VA = "0x187489700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xF358E0", Offset = "0xF34AE0", VA = "0x180F358E0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xEFE5E0", Offset = "0xEFD7E0", VA = "0x180EFE5E0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAE4090", Offset = "0xAE3290", VA = "0x180AE4090", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAE4140", Offset = "0xAE3340", VA = "0x180AE4140", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDB1CC0", Offset = "0xDB0EC0", VA = "0x180DB1CC0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xF3EC20", Offset = "0xF3DE20", VA = "0x180F3EC20", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x74894E0", Offset = "0x74886E0", VA = "0x1874894E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7489740", Offset = "0x7488940", VA = "0x187489740")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x74896E0", Offset = "0x74888E0", VA = "0x1874896E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF3EC60", Offset = "0xF3DE60", VA = "0x180F3EC60", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB974F0", Offset = "0xB966F0", VA = "0x180B974F0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB97500", Offset = "0xB96700", VA = "0x180B97500", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x97DAA0", Offset = "0x97CCA0", VA = "0x18097DAA0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7489760", Offset = "0x7488960", VA = "0x187489760")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x74897A0", Offset = "0x74889A0", VA = "0x1874897A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7489780", Offset = "0x7488980", VA = "0x187489780")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74897C0", Offset = "0x74889C0", VA = "0x1874897C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7489650", Offset = "0x7488850", VA = "0x187489650")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7488D80", Offset = "0x7487F80", VA = "0x187488D80")]
		public FJJMJDFJPJG DNKLFAFGNKC(FJJMJDFJPJG HLLJCMDOLKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74894E0", Offset = "0x74886E0", VA = "0x1874894E0", Slot = "25")]
		public Vector3 LOKACIAADMI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7489580", Offset = "0x7488780", VA = "0x187489580", Slot = "22")]
		public Vector3 PHGNNKJHEHO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7488810", Offset = "0x7487A10", VA = "0x187488810", Slot = "20")]
		public Vector3 AHGLHMLCIEC(Vector3 NFIDKIBCEOJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7489500", Offset = "0x7488700", VA = "0x187489500", Slot = "21")]
		public Vector3 OJJPDPLGGGM(Vector3 HKJBPCFKHJE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7489060", Offset = "0x7488260", VA = "0x187489060", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7488880", Offset = "0x7487A80", VA = "0x187488880")]
		protected bool DIOHPIOIANM(AnchorParamsRestrictions LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7489170", Offset = "0x7488370", VA = "0x187489170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7489470", Offset = "0x7488670", VA = "0x187489470")]
		[CompilerGenerated]
		internal static bool KBPLLBDOEEA(float IHGFIECIOLJ, float FHOBAJOBBGC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PLGNHIINMFN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14331F0", Offset = "0x14323F0", VA = "0x1814331F0")]
	public static bool FKBPJGENCBD(this OCHNHLJBAPP MAEDABBOOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x748B3F0", Offset = "0x748A5F0", VA = "0x18748B3F0")]
	public static bool BJNCNAIPDFB(this OCHNHLJBAPP MAEDABBOOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x748B400", Offset = "0x748A600", VA = "0x18748B400")]
	public static bool CMEBEFOIIKD(this OCHNHLJBAPP MAEDABBOOIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IHNEABEBDOM
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool LGKHIFPACFC;
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
public static class LENONAMJOID
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x748AF00", Offset = "0x748A100", VA = "0x18748AF00")]
	public static bool GBOBHPKOMBN(this HelmetHairMode HLEAICKOLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x748AFD0", Offset = "0x748A1D0", VA = "0x18748AFD0")]
	public static KJAEMCJAGMO PPNJJEBLFHA(this AvatarItemBodyType FPNGNOPBJOG)
	{
		return default(KJAEMCJAGMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x748AE80", Offset = "0x748A080", VA = "0x18748AE80")]
	public static AvatarItemBodyType DLIMPPFJFIH(this KJAEMCJAGMO FPNGNOPBJOG)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x748AF10", Offset = "0x748A110", VA = "0x18748AF10")]
	public static string GIBOHJDOMCB(this AvatarItemBodyType FPNGNOPBJOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AKIMKCKFALB
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74873F0", Offset = "0x74865F0", VA = "0x1874873F0")]
	public static void ILGLGPIBIID(Transform HCCPPCKPEKJ, Transform NANLFMHJPOA, Transform MBCPBAEGOBC, Transform FGGPDCPIKKN, float KINKABDPELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHOPHOECLDF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum PMFIJAGMILF
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
	public enum PDNJAPAFAJM : long
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
	public static readonly IReadOnlyList<PMFIJAGMILF> AJAEJKCEEAG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<PMFIJAGMILF> MCKAJHBDONN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<PMFIJAGMILF> HIFHNDLINAM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly PDNJAPAFAJM LPBNLFLBBHG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly PDNJAPAFAJM DNHMKCDHHJN;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly PDNJAPAFAJM FHDCOHGJEBK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x748B090", Offset = "0x748A290", VA = "0x18748B090")]
	public static PDNJAPAFAJM OGDOLBAPCHO(PDNJAPAFAJM IDDHCEAMDKD, PDNJAPAFAJM LEGANFOBEJD)
	{
		return default(PDNJAPAFAJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x748B080", Offset = "0x748A280", VA = "0x18748B080")]
	public static PDNJAPAFAJM LALLFBGKGCJ(PDNJAPAFAJM CGFBIAHKBNB, PDNJAPAFAJM EEDKDCKAOBL)
	{
		return default(PDNJAPAFAJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x748B050", Offset = "0x748A250", VA = "0x18748B050")]
	public static PDNJAPAFAJM ELAJIAIEACF(PMFIJAGMILF BJAFEBCPEPK, PDNJAPAFAJM JPNLAAJCKLH)
	{
		return default(PDNJAPAFAJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x748B060", Offset = "0x748A260", VA = "0x18748B060")]
	public static PDNJAPAFAJM GENJLPGAGIB(PMFIJAGMILF BJAFEBCPEPK, PDNJAPAFAJM JPNLAAJCKLH)
	{
		return default(PDNJAPAFAJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DBLEPMOEFKC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum KHDAOMFDEGN : short
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
			[Cpp2IlInjected.Address(RVA = "0x748A550", Offset = "0x7489750", VA = "0x18748A550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7489AE0", Offset = "0x7488CE0", VA = "0x187489AE0")]
		public void DBGCANDCECN(FitMeshHemisphere LMOONICKAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7489B30", Offset = "0x7488D30", VA = "0x187489B30")]
		public Vector3 IPJMEPKLNDF(Vector2 JIHHAGGDEOO, bool MHFGOAAJHGL = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x748A010", Offset = "0x7489210", VA = "0x18748A010")]
		public Vector3 LCDNEGPCAMH(Vector2 JIHHAGGDEOO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x748A070", Offset = "0x7489270", VA = "0x18748A070")]
		public Quaternion MJMJNMBIGBF(Vector2 JIHHAGGDEOO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x748A220", Offset = "0x7489420", VA = "0x18748A220")]
		public Quaternion MJMJNMBIGBF(Vector2 JIHHAGGDEOO, Vector3 LFAIIDDHIAH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7489A90", Offset = "0x7488C90", VA = "0x187489A90")]
		public Vector2 BDLBGIHIFMG(Vector2 COELIICNKMG)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x748A4B0", Offset = "0x74896B0", VA = "0x18748A4B0")]
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
public static class PDPNJNCOKFC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x748B3D0", Offset = "0x748A5D0", VA = "0x18748B3D0")]
	public static bool PDFMFJNLFMH(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x748B360", Offset = "0x748A560", VA = "0x18748B360")]
	public static bool EHBHAHNMIED(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x748B380", Offset = "0x748A580", VA = "0x18748B380")]
	public static bool FFGDBHEJAMA(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x748B3B0", Offset = "0x748A5B0", VA = "0x18748B3B0")]
	public static bool NILKNFFOBBP(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x748B3C0", Offset = "0x748A5C0", VA = "0x18748B3C0")]
	public static bool OLHPBOCDKPC(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x748B390", Offset = "0x748A590", VA = "0x18748B390")]
	public static bool LKPPLIDOEPK(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x748B320", Offset = "0x748A520", VA = "0x18748B320")]
	public static bool CEGGAONAEFI(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x748B350", Offset = "0x748A550", VA = "0x18748B350")]
	public static bool EBOGPHMDANO(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x748B330", Offset = "0x748A530", VA = "0x18748B330")]
	public static bool CJOBAJOCNGH(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x748B310", Offset = "0x748A510", VA = "0x18748B310")]
	public static bool AKGIIHJAJDL(this OutfitType GFOBCJGOIFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NPAJEDBDHLI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly NPAJEDBDHLI JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x748B210", Offset = "0x748A410", VA = "0x18748B210", Slot = "4")]
	public bool Equals(OutfitType LMOMIKIFAMH, OutfitType IAEJEHKMEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x748B270", Offset = "0x748A470", VA = "0x18748B270", Slot = "5")]
	public int GetHashCode(OutfitType NNILCBOLNDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NPAJEDBDHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum PMIBLKPEJKC
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
public enum GOIEIHKFCEA
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KIIFJEJNJJE
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
public enum NAFNGOKLEPP
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
public enum BLMBBPOKJAO
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
public enum MKBBPKEHLCL
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
		[Cpp2IlInjected.Address(RVA = "0x7487D40", Offset = "0x7486F40", VA = "0x187487D40", Slot = "7")]
		public override bool Equals(AdditionalFeetData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7487D70", Offset = "0x7486F70", VA = "0x187487D70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7487DF0", Offset = "0x7486FF0", VA = "0x187487DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7488320", Offset = "0x7487520", VA = "0x187488320")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7487E30", Offset = "0x7487030", VA = "0x187487E30", Slot = "7")]
		public override bool Equals(AdditionalHatData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7488020", Offset = "0x7487220", VA = "0x187488020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7488180", Offset = "0x7487380", VA = "0x187488180")]
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
		[Cpp2IlInjected.Address(RVA = "0x7488430", Offset = "0x7487630", VA = "0x187488430")]
		public static bool IJHAHPEHFPI(OutfitType NNILCBOLNDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7488460", Offset = "0x7487660", VA = "0x187488460")]
		public static AdditionalOutfitTypeData JENMMFKNHKF(OutfitType NNILCBOLNDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74883A0", Offset = "0x74875A0", VA = "0x1874883A0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LDKNLBHIGFL);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4AE8E60", Offset = "0x4AE8060", VA = "0x184AE8E60", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T LDKNLBHIGFL);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, MNLLCKAEJGC
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
			[Cpp2IlInjected.Address(RVA = "0xFD7FB0", Offset = "0xFD71B0", VA = "0x180FD7FB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x74897E0", Offset = "0x74889E0", VA = "0x1874897E0", Slot = "7")]
		public override bool Equals(BeardData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7489800", Offset = "0x7488A00", VA = "0x187489800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7489870", Offset = "0x7488A70", VA = "0x187489870")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, MNLLCKAEJGC
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
			[Cpp2IlInjected.Address(RVA = "0xB05420", Offset = "0xB04620", VA = "0x180B05420", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x980840", Offset = "0x97FA40", VA = "0x180980840", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC1E1D0", Offset = "0xC1D3D0", VA = "0x180C1E1D0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x748A910", Offset = "0x7489B10", VA = "0x18748A910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x748A560", Offset = "0x7489760", VA = "0x18748A560", Slot = "7")]
		public override bool Equals(HairData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x748A750", Offset = "0x7489950", VA = "0x18748A750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x748A850", Offset = "0x7489A50", VA = "0x18748A850")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MNLLCKAEJGC
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool DCOIDCNJLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle HPMBCAOMNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKLCFNEHNFA
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7489920", Offset = "0x7488B20", VA = "0x187489920")]
	public static OCHNHLJBAPP GDCMKMJFNPO(this OutfitType GFOBCJGOIFM, AvatarItemSidednessEquipType HBEENIJPOJB = AvatarItemSidednessEquipType.Left)
	{
		return default(OCHNHLJBAPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74899A0", Offset = "0x7488BA0", VA = "0x1874899A0")]
	public static OCHNHLJBAPP KJNBHCGPJPD(this OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(OCHNHLJBAPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74898B0", Offset = "0x7488AB0", VA = "0x1874898B0")]
	public static bool ADJGOHHHCGC(this OutfitType GFOBCJGOIFM, OCHNHLJBAPP GPIHEODLCOO)
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
public static class FOKACLPHMBM
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7489A10", Offset = "0x7488C10", VA = "0x187489A10")]
	public static bool FHGHAKBPAOO(this AvatarItemSidednessEquipType HBEENIJPOJB, OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7489A40", Offset = "0x7488C40", VA = "0x187489A40")]
	public static bool LJJAKHDBGEP(this AvatarItemSidednessEquipType PKGFJAJMEBA, OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7489A70", Offset = "0x7488C70", VA = "0x187489A70")]
	public static bool MPKIKHHHDBF(this AvatarItemSidednessEquipType NGGEIBFNBMD, AvatarItemSidednessEquipType HEAIHPKHAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74899F0", Offset = "0x7488BF0", VA = "0x1874899F0")]
	public static AvatarItemSidednessEquipType BKJLDEDLFJC(this AvatarItemSidednessEquipType NGGEIBFNBMD)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum COGPJEOLEHE
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
public static class KFJDIINODNG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x748ABA0", Offset = "0x7489DA0", VA = "0x18748ABA0")]
	private static COGPJEOLEHE LAHODMBHMME(this OutfitType GFOBCJGOIFM)
	{
		return default(COGPJEOLEHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x748AD10", Offset = "0x7489F10", VA = "0x18748AD10")]
	public static OutfitSlotFlags PMGPEBFACMN(this OutfitType GFOBCJGOIFM)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x748AB90", Offset = "0x7489D90", VA = "0x18748AB90")]
	public static bool KAOJJLPBGAN(this OutfitSlotFlags LOJFODJADLK, OutfitSlotFlags JOIGONBEHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x748A9A0", Offset = "0x7489BA0", VA = "0x18748A9A0")]
	public static bool GMIMAEPJAOC(this OutfitType GFOBCJGOIFM, OutfitSlotFlags GPOJKGGABJD)
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
