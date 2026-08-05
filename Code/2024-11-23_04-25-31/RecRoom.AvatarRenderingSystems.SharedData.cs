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
public interface ECGCIOHOBJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float GHJFBCLAMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float CPFEPJHDNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float FFCLGNHMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float KNEAFFNLKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float PNOKKMIOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float NPIBAICHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float LNJMAFBKNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KADOBBPHFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DAJNDJLDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PIMALOFDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float MLKGDFGMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float GLHNONIFHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float BIDLLCKJHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float GBIFLABPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float FLJJJOIMLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float LMPKAOKOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 MPMFDFFNMMC(Vector3 OAKFOCGNLNL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 JOPODOGCPJA(Vector3 GHICKDKPFGB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 FDOPOCKLHGJ();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : ECGCIOHOBJL
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
			[Cpp2IlInjected.Address(RVA = "0x930140", Offset = "0x92EB40", VA = "0x180930140", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xEB7490", Offset = "0xEB5E90", VA = "0x180EB7490", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA37C0", Offset = "0xAA21C0", VA = "0x180AA37C0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBF02D0", Offset = "0xBEECD0", VA = "0x180BF02D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xBB0070", Offset = "0xBAEA70", VA = "0x180BB0070", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAA7030", Offset = "0xAA5A30", VA = "0x180AA7030", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA881B0", Offset = "0xA86BB0", VA = "0x180A881B0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4C0", Offset = "0x8DAEC0", VA = "0x1808DC4C0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B960", Offset = "0x6C8A360", VA = "0x186C8B960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C3F0", Offset = "0x6C8ADF0", VA = "0x186C8C3F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C3D0", Offset = "0x6C8ADD0", VA = "0x186C8C3D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xBF02A0", Offset = "0xBEECA0", VA = "0x180BF02A0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBB0000", Offset = "0xBAEA00", VA = "0x180BB0000", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAA7010", Offset = "0xAA5A10", VA = "0x180AA7010", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xBB0090", Offset = "0xBAEA90", VA = "0x180BB0090", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA895E0", Offset = "0xA87FE0", VA = "0x180A895E0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBF08B0", Offset = "0xBEF2B0", VA = "0x180BF08B0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B4E0", Offset = "0x6C89EE0", VA = "0x186C8B4E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C410", Offset = "0x6C8AE10", VA = "0x186C8C410")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C3B0", Offset = "0x6C8ADB0", VA = "0x186C8C3B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBF08F0", Offset = "0xBEF2F0", VA = "0x180BF08F0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBF0920", Offset = "0xBEF320", VA = "0x180BF0920", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBF0910", Offset = "0xBEF310", VA = "0x180BF0910", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C79D0", Offset = "0x8C63D0", VA = "0x1808C79D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C430", Offset = "0x6C8AE30", VA = "0x186C8C430")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C470", Offset = "0x6C8AE70", VA = "0x186C8C470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C450", Offset = "0x6C8AE50", VA = "0x186C8C450")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8C490", Offset = "0x6C8AE90", VA = "0x186C8C490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C320", Offset = "0x6C8AD20", VA = "0x186C8C320")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B500", Offset = "0x6C89F00", VA = "0x186C8B500")]
		public IJDPLHMEMPG DMJLMNFHECM(IJDPLHMEMPG GEIHGKMHNNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B4E0", Offset = "0x6C89EE0", VA = "0x186C8B4E0", Slot = "25")]
		public Vector3 DIGGKEGCPOO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B960", Offset = "0x6C8A360", VA = "0x186C8B960", Slot = "22")]
		public Vector3 FDOPOCKLHGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C200", Offset = "0x6C8AC00", VA = "0x186C8C200", Slot = "20")]
		public Vector3 MPMFDFFNMMC(Vector3 OAKFOCGNLNL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BC80", Offset = "0x6C8A680", VA = "0x186C8BC80", Slot = "21")]
		public Vector3 JOPODOGCPJA(Vector3 GHICKDKPFGB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B7E0", Offset = "0x6C8A1E0", VA = "0x186C8B7E0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD00", Offset = "0x6C8A700", VA = "0x186C8BD00")]
		protected bool LLKODAGINCO(AnchorParamsRestrictions GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B980", Offset = "0x6C8A380", VA = "0x186C8B980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B8F0", Offset = "0x6C8A2F0", VA = "0x186C8B8F0")]
		[CompilerGenerated]
		internal static bool FDLBKJIPFBP(float PEMPEACEHBG, float FDDPOELCNDG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PLGEKOKLDLG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1115D00", Offset = "0x1114700", VA = "0x181115D00")]
	public static bool IJAJFAAKJID(this MMMGGPPGMJP PHNMLILNPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DBB0", Offset = "0x6C8C5B0", VA = "0x186C8DBB0")]
	public static bool EMGNGKFIPDD(this MMMGGPPGMJP PHNMLILNPFD)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum HelmetHairMode
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
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HairPatternStyle
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
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum AvatarItemBodyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		BeanBody,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		FullBody,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		ModernBeanBody
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CDDLDPIHGMK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C6C0", Offset = "0x6C8B0C0", VA = "0x186C8C6C0")]
	public static bool LBMNHNEFAEB(this HelmetHairMode AJBBGGLCIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C6D0", Offset = "0x6C8B0D0", VA = "0x186C8C6D0")]
	public static CNAPJFDNBAH PECFKGOOBEG(this AvatarItemBodyType OKEIHNNHJNC)
	{
		return default(CNAPJFDNBAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C640", Offset = "0x6C8B040", VA = "0x186C8C640")]
	public static AvatarItemBodyType ILMNGPLFJCC(this CNAPJFDNBAH OKEIHNNHJNC)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C580", Offset = "0x6C8AF80", VA = "0x186C8C580")]
	public static string GMHLNEBJPOF(this AvatarItemBodyType OKEIHNNHJNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NFCEEHLKBBE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum KKDGIFBCOCI
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

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum NIHDBPDBFFB
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
	public static NIHDBPDBFFB HMCLCNPFBBO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NIHDBPDBFFB BCINEMGIFNE;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA40", Offset = "0x6C8C440", VA = "0x186C8DA40")]
	public static NIHDBPDBFFB EDACGPGIMEF(NIHDBPDBFFB IMPBGIECNMG, NIHDBPDBFFB IEOEGOAFPMP)
	{
		return default(NIHDBPDBFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA60", Offset = "0x6C8C460", VA = "0x186C8DA60")]
	public static NIHDBPDBFFB FCACBCPAIJA(NIHDBPDBFFB DCCDFJKKECD, NIHDBPDBFFB PIIPDNFKJOC)
	{
		return default(NIHDBPDBFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA50", Offset = "0x6C8C450", VA = "0x186C8DA50")]
	public static NIHDBPDBFFB EPIDFIKCOPM(KKDGIFBCOCI FDHKPGHPJOD, NIHDBPDBFFB BDNKGIKLIFJ)
	{
		return default(NIHDBPDBFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DAE0", Offset = "0x6C8C4E0", VA = "0x186C8DAE0")]
	public static NIHDBPDBFFB LKPGDLFMMMH(KKDGIFBCOCI FDHKPGHPJOD, NIHDBPDBFFB BDNKGIKLIFJ)
	{
		return default(NIHDBPDBFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DAF0", Offset = "0x6C8C4F0", VA = "0x186C8DAF0")]
	public static bool MDLAEMGELHB(this NIHDBPDBFFB AEOGKBHENKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA70", Offset = "0x6C8C470", VA = "0x186C8DA70")]
	public static bool FOOGHDPDKMI(this NIHDBPDBFFB AEOGKBHENKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BJFNKBANEEA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum MPKJOBKELDF : short
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D370", Offset = "0x6C8BD70", VA = "0x186C8D370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CC20", Offset = "0x6C8B620", VA = "0x186C8CC20")]
		public void KKBKOPNMCJG(FitMeshHemisphere GCFLKDLMABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CC70", Offset = "0x6C8B670", VA = "0x186C8CC70")]
		public Vector3 NLHKOJEBODO(Vector2 EEEHNCAOKLP, bool EMLEJLOCCFI = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D150", Offset = "0x6C8BB50", VA = "0x186C8D150")]
		public Vector3 OLBLHDPCNAN(Vector2 EEEHNCAOKLP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C900", Offset = "0x6C8B300", VA = "0x186C8C900")]
		public Quaternion HDBAGEIJKNF(Vector2 EEEHNCAOKLP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CAB0", Offset = "0x6C8B4B0", VA = "0x186C8CAB0")]
		public Quaternion HDBAGEIJKNF(Vector2 EEEHNCAOKLP, Vector3 HGKOODEKKDM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C8B0", Offset = "0x6C8B2B0", VA = "0x186C8C8B0")]
		public Vector2 GAEAEHHDHAA(Vector2 PCPBDKGILKM)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D2D0", Offset = "0x6C8BCD0", VA = "0x186C8D2D0")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JBFNJIJMIEG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D950", Offset = "0x6C8C350", VA = "0x186C8D950")]
	public static bool NEGGKPNCGLC(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D8C0", Offset = "0x6C8C2C0", VA = "0x186C8D8C0")]
	public static bool BDAOAPAFBCL(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D990", Offset = "0x6C8C390", VA = "0x186C8D990")]
	public static bool PJAIOJGCFHG(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D8F0", Offset = "0x6C8C2F0", VA = "0x186C8D8F0")]
	public static bool FIGODAEAMPB(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D900", Offset = "0x6C8C300", VA = "0x186C8D900")]
	public static bool GBPHIIEKBFJ(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D970", Offset = "0x6C8C370", VA = "0x186C8D970")]
	public static bool OCKJEOINADJ(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D930", Offset = "0x6C8C330", VA = "0x186C8D930")]
	public static bool HGOGOELACCH(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D8E0", Offset = "0x6C8C2E0", VA = "0x186C8D8E0")]
	public static bool BGEDHLIJPFA(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D910", Offset = "0x6C8C310", VA = "0x186C8D910")]
	public static bool HDOIJHHNAOH(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D940", Offset = "0x6C8C340", VA = "0x186C8D940")]
	public static bool MLJPKECEGCK(this OutfitType JMCPJFDLMPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GCOMAJADHJC : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GCOMAJADHJC JOLICDCBKGF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D380", Offset = "0x6C8BD80", VA = "0x186C8D380", Slot = "4")]
	public bool Equals(OutfitType BLMFPCBNCCI, OutfitType FPFAMLJHEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D3E0", Offset = "0x6C8BDE0", VA = "0x186C8D3E0", Slot = "5")]
	public int GetHashCode(OutfitType BKKHBFLPOHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GCOMAJADHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum MMMGGPPGMJP
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum FGCECDFKMCC
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CLKLJGMJMAG
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum KEGLKCNJCJB
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BMHFKOAGLMC
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum CPGEBJEPEII
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DLMDJDKIMAD
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8A9A0", Offset = "0x6C893A0", VA = "0x186C8A9A0", Slot = "8")]
		public override bool Equals(AdditionalFeetData GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C8A9D0", Offset = "0x6C893D0", VA = "0x186C8A9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AA50", Offset = "0x6C89450", VA = "0x186C8AA50")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AF80", Offset = "0x6C89980", VA = "0x186C8AF80")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AA90", Offset = "0x6C89490", VA = "0x186C8AA90", Slot = "8")]
		public override bool Equals(AdditionalHatData GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC80", Offset = "0x6C89680", VA = "0x186C8AC80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ADE0", Offset = "0x6C897E0", VA = "0x186C8ADE0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B4B0", Offset = "0x6C89EB0", VA = "0x186C8B4B0")]
		public static bool MIDMIJOOFNE(OutfitType BKKHBFLPOHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B100", Offset = "0x6C89B00", VA = "0x186C8B100")]
		public static AdditionalOutfitTypeData LNCAGMGJJFK(OutfitType BKKHBFLPOHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B000", Offset = "0x6C89A00", VA = "0x186C8B000", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData GDOGPMPJPOO);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B090", Offset = "0x6C89A90", VA = "0x186C8B090", Slot = "6")]
		public virtual AdditionalOutfitTypeData JLKNNCHOGKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x45226F0", Offset = "0x45210F0", VA = "0x1845226F0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T GDOGPMPJPOO);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, MGBCHEEJHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC701F0", Offset = "0xC6EBF0", VA = "0x180C701F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C4B0", Offset = "0x6C8AEB0", VA = "0x186C8C4B0", Slot = "8")]
		public override bool Equals(BeardData GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C4D0", Offset = "0x6C8AED0", VA = "0x186C8C4D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C540", Offset = "0x6C8AF40", VA = "0x186C8C540")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class HairData : AdditionalOutfitTypeData<HairData>, MGBCHEEJHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x935D30", Offset = "0x934730", VA = "0x180935D30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8CA8B0", Offset = "0x8C92B0", VA = "0x1808CA8B0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA14640", Offset = "0xA13040", VA = "0x180A14640")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D830", Offset = "0x6C8C230", VA = "0x186C8D830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D480", Offset = "0x6C8BE80", VA = "0x186C8D480", Slot = "8")]
		public override bool Equals(HairData GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D670", Offset = "0x6C8C070", VA = "0x186C8D670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D770", Offset = "0x6C8C170", VA = "0x186C8D770")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MGBCHEEJHAE
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool BEIGAOPDIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle JCEONONMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DPHGMNKNLNE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C750", Offset = "0x6C8B150", VA = "0x186C8C750")]
	public static MMMGGPPGMJP FKFKFJJKBPJ(this OutfitType JMCPJFDLMPB, AvatarItemSidednessEquipType MJABJLLDEBM = AvatarItemSidednessEquipType.Left)
	{
		return default(MMMGGPPGMJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C7D0", Offset = "0x6C8B1D0", VA = "0x186C8C7D0")]
	public static MMMGGPPGMJP KIGIANFNGKJ(this MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(MMMGGPPGMJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C830", Offset = "0x6C8B230", VA = "0x186C8C830")]
	public static bool OMCNJGOEMJM(this OutfitType JMCPJFDLMPB, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JMDDKHGOCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D9C0", Offset = "0x6C8C3C0", VA = "0x186C8D9C0")]
	public static bool CNGOGBCDLMN(this AvatarItemSidednessEquipType MJABJLLDEBM, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA10", Offset = "0x6C8C410", VA = "0x186C8DA10")]
	public static bool LOFAKBOFDJJ(this AvatarItemSidednessEquipType LMGJINPLPID, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D9F0", Offset = "0x6C8C3F0", VA = "0x186C8D9F0")]
	public static bool LJIICIOOLLA(this AvatarItemSidednessEquipType DIMKJLDNHIK, AvatarItemSidednessEquipType IBLOHFKAJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D9A0", Offset = "0x6C8C3A0", VA = "0x186C8D9A0")]
	public static AvatarItemSidednessEquipType BLOBEGJKAMH(this AvatarItemSidednessEquipType DIMKJLDNHIK)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal enum JNOLKJBAMJD
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AJBJBNLKABL
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A4C0", Offset = "0x6C88EC0", VA = "0x186C8A4C0")]
	private static JNOLKJBAMJD COCBDLIMLLP(this OutfitType JMCPJFDLMPB)
	{
		return default(JNOLKJBAMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A820", Offset = "0x6C89220", VA = "0x186C8A820")]
	public static OutfitSlotFlags HCEGMHGECBP(this OutfitType JMCPJFDLMPB)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A990", Offset = "0x6C89390", VA = "0x186C8A990")]
	public static bool IBKHGFOJOOK(this OutfitSlotFlags EKCGEKMEEDG, OutfitSlotFlags AFHJPHDMCAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A630", Offset = "0x6C89030", VA = "0x186C8A630")]
	public static bool DFHALHPOPFP(this OutfitType JMCPJFDLMPB, OutfitSlotFlags MFELGIEDBFM)
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
