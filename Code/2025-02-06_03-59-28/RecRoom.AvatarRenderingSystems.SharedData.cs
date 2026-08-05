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
public interface DLJLECMBPJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float HJMHJLOANND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NDCEOPNHLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NJOBHGKCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float OGPAKGIPNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float NKKLJAJILBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float BBENENAICPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KHNGCLOILMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BFGCCLKNNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JMAOIFPMCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HJOMKECEPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KDCLHBEEKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KJLDJPIGDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float BDBLIHGMMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float FDMEIEPBBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float OKJFOMIMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float KMFEMKFOCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 AGCJAGFCOAA(Vector3 AODCFFHHAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 FEPPHEDJAHF(Vector3 CIMBEAIGALE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 PLMDCFLMDJK();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : DLJLECMBPJI
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
			[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB4A970", Offset = "0xB49770", VA = "0x180B4A970", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD9F810", Offset = "0xD9E610", VA = "0x180D9F810", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBF1C10", Offset = "0xBF0A10", VA = "0x180BF1C10", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEB2C20", Offset = "0xEB1A20", VA = "0x180EB2C20", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xDA62D0", Offset = "0xDA50D0", VA = "0x180DA62D0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xACB6B0", Offset = "0xACA4B0", VA = "0x180ACB6B0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9254B0", Offset = "0x9242B0", VA = "0x1809254B0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7118670", Offset = "0x7117470", VA = "0x187118670")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7118820", Offset = "0x7117620", VA = "0x187118820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7118800", Offset = "0x7117600", VA = "0x187118800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xEF1490", Offset = "0xEF0290", VA = "0x180EF1490", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xEB2BC0", Offset = "0xEB19C0", VA = "0x180EB2BC0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAC7DA0", Offset = "0xAC6BA0", VA = "0x180AC7DA0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAC8400", Offset = "0xAC7200", VA = "0x180AC8400", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD674A0", Offset = "0xD662A0", VA = "0x180D674A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xEFA730", Offset = "0xEF9530", VA = "0x180EFA730", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71178F0", Offset = "0x71166F0", VA = "0x1871178F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7118840", Offset = "0x7117640", VA = "0x187118840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71187E0", Offset = "0x71175E0", VA = "0x1871187E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEFA770", Offset = "0xEF9570", VA = "0x180EFA770", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB20", Offset = "0xB49920", VA = "0x180B4AB20", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB10", Offset = "0xB49910", VA = "0x180B4AB10", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x910E80", Offset = "0x90FC80", VA = "0x180910E80", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7118860", Offset = "0x7117660", VA = "0x187118860")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71188A0", Offset = "0x71176A0", VA = "0x1871188A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7118880", Offset = "0x7117680", VA = "0x187118880")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71188C0", Offset = "0x71176C0", VA = "0x1871188C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7118750", Offset = "0x7117550", VA = "0x187118750")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7118310", Offset = "0x7117110", VA = "0x187118310")]
		public PACDKMEJBDN HLEBKDKJCKG(PACDKMEJBDN OGPKMECCHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71178F0", Offset = "0x71166F0", VA = "0x1871178F0", Slot = "25")]
		public Vector3 ACFNHFEKHDB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7118670", Offset = "0x7117470", VA = "0x187118670", Slot = "22")]
		public Vector3 PLMDCFLMDJK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7117910", Offset = "0x7116710", VA = "0x187117910", Slot = "20")]
		public Vector3 AGCJAGFCOAA(Vector3 AODCFFHHAIJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7117F90", Offset = "0x7116D90", VA = "0x187117F90", Slot = "21")]
		public Vector3 FEPPHEDJAHF(Vector3 CIMBEAIGALE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7117E80", Offset = "0x7116C80", VA = "0x187117E80", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7117980", Offset = "0x7116780", VA = "0x187117980")]
		protected bool DJBOHCAMMCM(AnchorParamsRestrictions LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7118010", Offset = "0x7116E10", VA = "0x187118010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7118600", Offset = "0x7117400", VA = "0x187118600")]
		[CompilerGenerated]
		internal static bool KLEGKHBIEEI(float HJGGLHBFMKO, float AGAPPIBJJBC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NBPLEAMHJGI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1437720", Offset = "0x1436520", VA = "0x181437720")]
	public static bool OFKANOEDOML(this GKHPEMHLGJO IIMJDGJFDCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x711ACB0", Offset = "0x7119AB0", VA = "0x18711ACB0")]
	public static bool EECEKCCCPLJ(this GKHPEMHLGJO IIMJDGJFDCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GDEBGFBMGLN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool AFFAFMIMBMH;
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
public static class OKEBGNGKABI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x711AD80", Offset = "0x7119B80", VA = "0x18711AD80")]
	public static bool HHMLDAJNIPN(this HelmetHairMode JPLPCJHNPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x711AD90", Offset = "0x7119B90", VA = "0x18711AD90")]
	public static ENGPMKLLDHI JMOGEHCEECG(this AvatarItemBodyType PFHDLGLIBDB)
	{
		return default(ENGPMKLLDHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x711AE10", Offset = "0x7119C10", VA = "0x18711AE10")]
	public static AvatarItemBodyType PHBPJEKJGCE(this ENGPMKLLDHI PFHDLGLIBDB)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x711ACC0", Offset = "0x7119AC0", VA = "0x18711ACC0")]
	public static string HBEICPNNCMH(this AvatarItemBodyType PFHDLGLIBDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EDAHBNMNMLC
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7118BB0", Offset = "0x71179B0", VA = "0x187118BB0")]
	public static void EEDEPEBPABH(Transform GKHMBPCNMFK, Transform MINMPFCAEMM, Transform EJCPGOEJDND, Transform JCHFNDLJHAG, float AODNIIEOKJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HFBLFLDOFLG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum JPGHNPDOAAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum KLFEKKPPLNK
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KLFEKKPPLNK GGFJBNMMFNK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly KLFEKKPPLNK EANMCMGPFOM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly KLFEKKPPLNK LJJDGLLHEJG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x711A010", Offset = "0x7118E10", VA = "0x18711A010")]
	public static KLFEKKPPLNK BKELHFNEMNB(KLFEKKPPLNK PCBKMOPIOPG, KLFEKKPPLNK FCAGJNEDDPD)
	{
		return default(KLFEKKPPLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x711A120", Offset = "0x7118F20", VA = "0x18711A120")]
	public static KLFEKKPPLNK PIGPMKHEMLB(KLFEKKPPLNK GNJLOFOBPNK, KLFEKKPPLNK IEHHFFOGMKO)
	{
		return default(KLFEKKPPLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x711A090", Offset = "0x7118E90", VA = "0x18711A090")]
	public static KLFEKKPPLNK GLJJGIJDBLB(JPGHNPDOAAI GNCLNNOLAHL, KLFEKKPPLNK NHHBADEFEIN)
	{
		return default(KLFEKKPPLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x711A0A0", Offset = "0x7118EA0", VA = "0x18711A0A0")]
	public static KLFEKKPPLNK HHELHKDDBDE(JPGHNPDOAAI GNCLNNOLAHL, KLFEKKPPLNK NHHBADEFEIN)
	{
		return default(KLFEKKPPLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x711A020", Offset = "0x7118E20", VA = "0x18711A020")]
	public static bool DMEEKCLPPIO(this KLFEKKPPLNK JCPICEBMIAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x711A0B0", Offset = "0x7118EB0", VA = "0x18711A0B0")]
	public static bool HPKOFIPFBOD(this KLFEKKPPLNK JCPICEBMIAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JEHENHGBMFI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum GLEHJFEDLEM : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x711A000", Offset = "0x7118E00", VA = "0x18711A000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71199F0", Offset = "0x71187F0", VA = "0x1871199F0")]
		public void EODICAJDAKB(FitMeshHemisphere LFFPIAEBBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7119500", Offset = "0x7118300", VA = "0x187119500")]
		public Vector3 BICFHNJPLAB(Vector2 CICKNJJCJAA, bool MGAAADMPGLO = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7119DC0", Offset = "0x7118BC0", VA = "0x187119DC0")]
		public Vector3 JHHNCHJBBJA(Vector2 CICKNJJCJAA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7119C00", Offset = "0x7118A00", VA = "0x187119C00")]
		public Quaternion IGOEGFJPHNP(Vector2 CICKNJJCJAA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7119A90", Offset = "0x7118890", VA = "0x187119A90")]
		public Quaternion IGOEGFJPHNP(Vector2 CICKNJJCJAA, Vector3 CBOKIJAIIIE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7119A40", Offset = "0x7118840", VA = "0x187119A40")]
		public Vector2 FJCJBHBPKFD(Vector2 BBOBCMBLKLG)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7119F50", Offset = "0x7118D50", VA = "0x187119F50")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HGHEKBKGDOF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x711A230", Offset = "0x7119030", VA = "0x18711A230")]
	public static bool MMCHPEFPAAN(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x711A1D0", Offset = "0x7118FD0", VA = "0x18711A1D0")]
	public static bool GEODDIFJEAF(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x711A1F0", Offset = "0x7118FF0", VA = "0x18711A1F0")]
	public static bool HJGONBJDOFA(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x711A1A0", Offset = "0x7118FA0", VA = "0x18711A1A0")]
	public static bool CDPCLDANGHP(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x711A250", Offset = "0x7119050", VA = "0x18711A250")]
	public static bool OGJNCKGCFDP(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x711A260", Offset = "0x7119060", VA = "0x18711A260")]
	public static bool PBFIHCDHCAK(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x711A1B0", Offset = "0x7118FB0", VA = "0x18711A1B0")]
	public static bool FJJAGIJHHIP(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x711A200", Offset = "0x7119000", VA = "0x18711A200")]
	public static bool JHLILBIPFBB(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x711A210", Offset = "0x7119010", VA = "0x18711A210")]
	public static bool JJMGHEANGKP(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x711A1C0", Offset = "0x7118FC0", VA = "0x18711A1C0")]
	public static bool FKLBBLEEJOH(this OutfitType BFOOEKHPMJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IEJAAMGOLBI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IEJAAMGOLBI GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x711A6C0", Offset = "0x71194C0", VA = "0x18711A6C0", Slot = "4")]
	public bool Equals(OutfitType DBKOMOLILMK, OutfitType PKNLHKDBNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x711A720", Offset = "0x7119520", VA = "0x18711A720", Slot = "5")]
	public int GetHashCode(OutfitType OBDHBADPJNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public IEJAAMGOLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NPEDNBNAKGC
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum EGHHDCHNKOL
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OEFGHLPBFDF
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum IMOIFEKEDED
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EBGAKLBCDPI
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KPICGBGFHFC
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7116E00", Offset = "0x7115C00", VA = "0x187116E00", Slot = "7")]
		public override bool Equals(AdditionalFeetData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7116E30", Offset = "0x7115C30", VA = "0x187116E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7116EB0", Offset = "0x7115CB0", VA = "0x187116EB0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x71173F0", Offset = "0x71161F0", VA = "0x1871173F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7116EF0", Offset = "0x7115CF0", VA = "0x187116EF0", Slot = "7")]
		public override bool Equals(AdditionalHatData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71170E0", Offset = "0x7115EE0", VA = "0x1871170E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7117240", Offset = "0x7116040", VA = "0x187117240")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71178C0", Offset = "0x71166C0", VA = "0x1871178C0")]
		public static bool JADNPDFLFGC(OutfitType OBDHBADPJNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7117470", Offset = "0x7116270", VA = "0x187117470")]
		public static AdditionalOutfitTypeData DCMOGLEGFAE(OutfitType OBDHBADPJNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7117830", Offset = "0x7116630", VA = "0x187117830", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LHMPMCLNOPG);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x47F56B0", Offset = "0x47F44B0", VA = "0x1847F56B0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T LHMPMCLNOPG);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, BEDLJLHICHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xF8F6F0", Offset = "0xF8E4F0", VA = "0x180F8F6F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7118A40", Offset = "0x7117840", VA = "0x187118A40", Slot = "7")]
		public override bool Equals(BeardData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7118A60", Offset = "0x7117860", VA = "0x187118A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7118AD0", Offset = "0x71178D0", VA = "0x187118AD0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, BEDLJLHICHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xADD5B0", Offset = "0xADC3B0", VA = "0x180ADD5B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x914110", Offset = "0x912F10", VA = "0x180914110", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA79C0", Offset = "0xAA67C0", VA = "0x180AA79C0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x711A630", Offset = "0x7119430", VA = "0x18711A630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x711A280", Offset = "0x7119080", VA = "0x18711A280", Slot = "7")]
		public override bool Equals(HairData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x711A470", Offset = "0x7119270", VA = "0x18711A470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x711A570", Offset = "0x7119370", VA = "0x18711A570")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BEDLJLHICHP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool MPFOEDDHLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle ODPOPPIKAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class BIJIKGGBDLH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7118940", Offset = "0x7117740", VA = "0x187118940")]
	public static GKHPEMHLGJO EDDBAACDBLA(this OutfitType BFOOEKHPMJD, AvatarItemSidednessEquipType JMEBNHJJKAB = AvatarItemSidednessEquipType.Left)
	{
		return default(GKHPEMHLGJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71188E0", Offset = "0x71176E0", VA = "0x1871188E0")]
	public static GKHPEMHLGJO CCJKINPELJJ(this GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(GKHPEMHLGJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71189C0", Offset = "0x71177C0", VA = "0x1871189C0")]
	public static bool EINCMAEOPIN(this OutfitType BFOOEKHPMJD, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CDNLBEPIMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7118B10", Offset = "0x7117910", VA = "0x187118B10")]
	public static bool BJGIJDGDKLJ(this AvatarItemSidednessEquipType JMEBNHJJKAB, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7118B60", Offset = "0x7117960", VA = "0x187118B60")]
	public static bool KNHJOFOOABF(this AvatarItemSidednessEquipType NNFLGPFCMKC, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7118B40", Offset = "0x7117940", VA = "0x187118B40")]
	public static bool EKBLONGOGJK(this AvatarItemSidednessEquipType HJHPGIOMEHH, AvatarItemSidednessEquipType JJBOCDOKPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7118B90", Offset = "0x7117990", VA = "0x187118B90")]
	public static AvatarItemSidednessEquipType LNOOCNHNCDL(this AvatarItemSidednessEquipType HJHPGIOMEHH)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum IMILNEGIDFL
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IJMOAICBOKB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x711AB40", Offset = "0x7119940", VA = "0x18711AB40")]
	private static IMILNEGIDFL LEMPNJGBAFP(this OutfitType BFOOEKHPMJD)
	{
		return default(IMILNEGIDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x711A7D0", Offset = "0x71195D0", VA = "0x18711A7D0")]
	public static OutfitSlotFlags BLEHCMPPMCE(this OutfitType BFOOEKHPMJD)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x711AB30", Offset = "0x7119930", VA = "0x18711AB30")]
	public static bool HNLNHNFDHFC(this OutfitSlotFlags BIAOIBLCNGK, OutfitSlotFlags OOBLJDEFMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x711A940", Offset = "0x7119740", VA = "0x18711A940")]
	public static bool BPBPLNMGFGA(this OutfitType BFOOEKHPMJD, OutfitSlotFlags HIIEGKPNBFC)
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
