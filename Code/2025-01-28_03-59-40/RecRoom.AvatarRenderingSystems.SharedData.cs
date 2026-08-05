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
public interface CHPMJKCNFKD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float ABAHAFKOKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float ONANEHIJOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float JKICCMLBEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AIFAMFPBMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float IOHGIANJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float ALDBIFMLGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NGLNKIOMKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OEDNBLPGLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FFDLJMFCNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float LJIIELLGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DBBBEBEJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float OAMNHPJGFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DLFHLGHHPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DDKOGOILFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float HOIBAPAIOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HMODCINAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 CBCBDPKPIKH(Vector3 ELFEKCNNJNG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 FLLBJPHIFIN(Vector3 PBEKPALMIHC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 FNNPELLBAOE();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : CHPMJKCNFKD
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
			[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB24E20", Offset = "0xB24020", VA = "0x180B24E20", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD59F40", Offset = "0xD59140", VA = "0x180D59F40", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBCFDE0", Offset = "0xBCEFE0", VA = "0x180BCFDE0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE8C830", Offset = "0xE8BA30", VA = "0x180E8C830", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD67050", VA = "0x180D67E50", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB8C0", Offset = "0xAAAAC0", VA = "0x180AAB8C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x923AC0", Offset = "0x922CC0", VA = "0x180923AC0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x70BA540", Offset = "0x70B9740", VA = "0x1870BA540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x70BB200", Offset = "0x70BA400", VA = "0x1870BB200")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x70BB1E0", Offset = "0x70BA3E0", VA = "0x1870BB1E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xECC6A0", Offset = "0xECB8A0", VA = "0x180ECC6A0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xE8C7D0", Offset = "0xE8B9D0", VA = "0x180E8C7D0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAA2840", Offset = "0xAA1A40", VA = "0x180AA2840", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAA2980", Offset = "0xAA1B80", VA = "0x180AA2980", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5D0", Offset = "0xD4C7D0", VA = "0x180D4D5D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xED5870", Offset = "0xED4A70", VA = "0x180ED5870", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x70BAD60", Offset = "0x70B9F60", VA = "0x1870BAD60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x70BB220", Offset = "0x70BA420", VA = "0x1870BB220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x70BB1C0", Offset = "0x70BA3C0", VA = "0x1870BB1C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xED58B0", Offset = "0xED4AB0", VA = "0x180ED58B0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB24E00", Offset = "0xB24000", VA = "0x180B24E00", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB24E30", Offset = "0xB24030", VA = "0x180B24E30", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x90E6F0", Offset = "0x90D8F0", VA = "0x18090E6F0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x70BB240", Offset = "0x70BA440", VA = "0x1870BB240")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x70BB280", Offset = "0x70BA480", VA = "0x1870BB280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x70BB260", Offset = "0x70BA460", VA = "0x1870BB260")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x70BB2A0", Offset = "0x70BA4A0", VA = "0x1870BB2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70BB130", Offset = "0x70BA330", VA = "0x1870BB130")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x70BAD80", Offset = "0x70B9F80", VA = "0x1870BAD80")]
		public APGOBKHECLL OHEANHBJJFO(APGOBKHECLL BDGOGEKNCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x70BAD60", Offset = "0x70B9F60", VA = "0x1870BAD60", Slot = "25")]
		public Vector3 HICELNAILDK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70BA540", Offset = "0x70B9740", VA = "0x1870BA540", Slot = "22")]
		public Vector3 FNNPELLBAOE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x70BA340", Offset = "0x70B9540", VA = "0x1870BA340", Slot = "20")]
		public Vector3 CBCBDPKPIKH(Vector3 ELFEKCNNJNG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70BA4C0", Offset = "0x70B96C0", VA = "0x1870BA4C0", Slot = "21")]
		public Vector3 FLLBJPHIFIN(Vector3 PBEKPALMIHC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70BA3B0", Offset = "0x70B95B0", VA = "0x1870BA3B0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70BA560", Offset = "0x70B9760", VA = "0x1870BA560")]
		protected bool GJGFPDJPFKG(AnchorParamsRestrictions JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70BAA60", Offset = "0x70B9C60", VA = "0x1870BAA60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x70BA2D0", Offset = "0x70B94D0", VA = "0x1870BA2D0")]
		[CompilerGenerated]
		internal static bool ADJAGNBHMAP(float KKLLOEEDINO, float NHCGDJCFKIC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IFOIHOIEDEB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x141E7D0", Offset = "0x141D9D0", VA = "0x18141E7D0")]
	public static bool ENLJPGGGALK(this IEPCDHHNEOA OPHDJMPDDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70BC800", Offset = "0x70BBA00", VA = "0x1870BC800")]
	public static bool JGBFBEOFFHM(this IEPCDHHNEOA OPHDJMPDDFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCMOKOCOFNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool PDKNBPFPJNH;
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
public static class HKHOCJGBKEE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70BC1F0", Offset = "0x70BB3F0", VA = "0x1870BC1F0")]
	public static bool BKKIPDNPPOJ(this HelmetHairMode NEGKDIJFFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70BC280", Offset = "0x70BB480", VA = "0x1870BC280")]
	public static HCLDEAEBCAG KKHDMNMBOAM(this AvatarItemBodyType BMNGGJOPDFI)
	{
		return default(HCLDEAEBCAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70BC200", Offset = "0x70BB400", VA = "0x1870BC200")]
	public static AvatarItemBodyType DOBHDDJHBIK(this HCLDEAEBCAG BMNGGJOPDFI)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70BC300", Offset = "0x70BB500", VA = "0x1870BC300")]
	public static string LAHOMEEDGBF(this AvatarItemBodyType BMNGGJOPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NDCDKDDAPHL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x70BCA40", Offset = "0x70BBC40", VA = "0x1870BCA40")]
	public static void BCHKBAMOJAJ(Transform NPLGKCDPIFD, Transform ELKOMAAEMAE, Transform EOIHOJGGAOK, Transform OKBNCMDPINB, float MKPODEJNPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LJLGCMOEKHG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum CKPDPGPNKKM
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
	public enum AMEKCHAHPFE
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
	public static readonly AMEKCHAHPFE OJNGLJMCJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly AMEKCHAHPFE EBKNDNKOMAK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly AMEKCHAHPFE GBEELJOPIBF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70BC890", Offset = "0x70BBA90", VA = "0x1870BC890")]
	public static AMEKCHAHPFE KBMINHABHJG(AMEKCHAHPFE KEFMLJNELGO, AMEKCHAHPFE GHPBJJHIBBO)
	{
		return default(AMEKCHAHPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70BC920", Offset = "0x70BBB20", VA = "0x1870BC920")]
	public static AMEKCHAHPFE OLIFAGIHFNA(AMEKCHAHPFE AGCJMFJBOGC, AMEKCHAHPFE JLEFHFJLAEH)
	{
		return default(AMEKCHAHPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x70BC8A0", Offset = "0x70BBAA0", VA = "0x1870BC8A0")]
	public static AMEKCHAHPFE KHEEKEMNFNA(CKPDPGPNKKM OLJFLFKBGEM, AMEKCHAHPFE GCPLDNIFINO)
	{
		return default(AMEKCHAHPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70BC810", Offset = "0x70BBA10", VA = "0x1870BC810")]
	public static AMEKCHAHPFE BICBANMDAIB(CKPDPGPNKKM OLJFLFKBGEM, AMEKCHAHPFE GCPLDNIFINO)
	{
		return default(AMEKCHAHPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70BC8B0", Offset = "0x70BBAB0", VA = "0x1870BC8B0")]
	public static bool NOEDBNJPGLK(this AMEKCHAHPFE JGMICABELHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70BC820", Offset = "0x70BBA20", VA = "0x1870BC820")]
	public static bool INHLEEBNBHE(this AMEKCHAHPFE JGMICABELHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ICKLLJAMGLG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DDFKMHJCEFL : short
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
			[Cpp2IlInjected.Address(RVA = "0x70BBFF0", Offset = "0x70BB1F0", VA = "0x1870BBFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70BBD10", Offset = "0x70BAF10", VA = "0x1870BBD10")]
		public void MCEOOMJHPCG(FitMeshHemisphere LFGNIJFHLEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x70BB4F0", Offset = "0x70BA6F0", VA = "0x1870BB4F0")]
		public Vector3 DKCBFMMEPAA(Vector2 GNOFMOJODPJ, bool NGNIALHELPE = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70BBDB0", Offset = "0x70BAFB0", VA = "0x1870BBDB0")]
		public Vector3 PADHMBMEHGE(Vector2 GNOFMOJODPJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x70BBB50", Offset = "0x70BAD50", VA = "0x1870BBB50")]
		public Quaternion JINGBADJEGA(Vector2 GNOFMOJODPJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70BB9E0", Offset = "0x70BABE0", VA = "0x1870BB9E0")]
		public Quaternion JINGBADJEGA(Vector2 GNOFMOJODPJ, Vector3 KACJDMEEHKA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70BBD60", Offset = "0x70BAF60", VA = "0x1870BBD60")]
		public Vector2 OIDOPEFEFBP(Vector2 HFKFBLDGLJE)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70BBF40", Offset = "0x70BB140", VA = "0x1870BBF40")]
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
public static class GDBCHDMILGD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70BC040", Offset = "0x70BB240", VA = "0x1870BC040")]
	public static bool EMMPFBPPPDG(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70BC0C0", Offset = "0x70BB2C0", VA = "0x1870BC0C0")]
	public static bool NIBOMLCDKGO(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70BC070", Offset = "0x70BB270", VA = "0x1870BC070")]
	public static bool JOCKPNEGCCM(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x70BC060", Offset = "0x70BB260", VA = "0x1870BC060")]
	public static bool HELKBCOLHBH(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x70BC0B0", Offset = "0x70BB2B0", VA = "0x1870BC0B0")]
	public static bool MKICKGOKKBO(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70BC020", Offset = "0x70BB220", VA = "0x1870BC020")]
	public static bool EDHGNOCIEGG(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70BC080", Offset = "0x70BB280", VA = "0x1870BC080")]
	public static bool KGHOBBIPFBK(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70BC090", Offset = "0x70BB290", VA = "0x1870BC090")]
	public static bool KICBOMFMCAH(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70BC000", Offset = "0x70BB200", VA = "0x1870BC000")]
	public static bool BPNMAMJINGM(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70BC0A0", Offset = "0x70BB2A0", VA = "0x1870BC0A0")]
	public static bool MFBCBGGFPMB(this OutfitType JLMKKDGCFEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HGKGAEENOFD : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly HGKGAEENOFD CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70BC0E0", Offset = "0x70BB2E0", VA = "0x1870BC0E0", Slot = "4")]
	public bool Equals(OutfitType EDDNGKIFOKB, OutfitType NNCGDJHHKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x70BC140", Offset = "0x70BB340", VA = "0x1870BC140", Slot = "5")]
	public int GetHashCode(OutfitType MDOOANEGCAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public HGKGAEENOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JIGNMKLEPID
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
public enum IEEDDENAPDI
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IGJDKHOAHLJ
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
public enum OPICNNMDPNH
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
public enum COLMEPMMNCE
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
public enum HPBHKOBDHLA
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
		[Cpp2IlInjected.Address(RVA = "0x70B97E0", Offset = "0x70B89E0", VA = "0x1870B97E0", Slot = "7")]
		public override bool Equals(AdditionalFeetData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70B9810", Offset = "0x70B8A10", VA = "0x1870B9810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70B9890", Offset = "0x70B8A90", VA = "0x1870B9890")]
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
			[Cpp2IlInjected.Address(RVA = "0x70B9DD0", Offset = "0x70B8FD0", VA = "0x1870B9DD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x70B98D0", Offset = "0x70B8AD0", VA = "0x1870B98D0", Slot = "7")]
		public override bool Equals(AdditionalHatData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x70B9AC0", Offset = "0x70B8CC0", VA = "0x1870B9AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70B9C20", Offset = "0x70B8E20", VA = "0x1870B9C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x70BA2A0", Offset = "0x70B94A0", VA = "0x1870BA2A0")]
		public static bool MJGEPHFMJEH(OutfitType MDOOANEGCAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70B9EE0", Offset = "0x70B90E0", VA = "0x1870B9EE0")]
		public static AdditionalOutfitTypeData LHPCDDMHIBB(OutfitType MDOOANEGCAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70B9E50", Offset = "0x70B9050", VA = "0x1870B9E50", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData JAINJPLCLDO);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4801D20", Offset = "0x4800F20", VA = "0x184801D20", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T JAINJPLCLDO);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, BEKLGDLALCI
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
			[Cpp2IlInjected.Address(RVA = "0xF4D9F0", Offset = "0xF4CBF0", VA = "0x180F4D9F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x70BB2C0", Offset = "0x70BA4C0", VA = "0x1870BB2C0", Slot = "7")]
		public override bool Equals(BeardData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x70BB2E0", Offset = "0x70BA4E0", VA = "0x1870BB2E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70BB350", Offset = "0x70BA550", VA = "0x1870BB350")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, BEKLGDLALCI
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
			[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x911460", Offset = "0x910660", VA = "0x180911460", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA86BE0", Offset = "0xA85DE0", VA = "0x180A86BE0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x70BC770", Offset = "0x70BB970", VA = "0x1870BC770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70BC3C0", Offset = "0x70BB5C0", VA = "0x1870BC3C0", Slot = "7")]
		public override bool Equals(HairData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70BC5B0", Offset = "0x70BB7B0", VA = "0x1870BC5B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x70BC6B0", Offset = "0x70BB8B0", VA = "0x1870BC6B0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BEKLGDLALCI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool BEPPGGLICLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle OLEFFJFPMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class CABAFBBDKJC
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70BB470", Offset = "0x70BA670", VA = "0x1870BB470")]
	public static IEPCDHHNEOA OOFIOMEBHHG(this OutfitType JLMKKDGCFEI, AvatarItemSidednessEquipType BFIOEOEOJPG = AvatarItemSidednessEquipType.Left)
	{
		return default(IEPCDHHNEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x70BB390", Offset = "0x70BA590", VA = "0x1870BB390")]
	public static IEPCDHHNEOA DCHCIGIGAFG(this IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(IEPCDHHNEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x70BB3F0", Offset = "0x70BA5F0", VA = "0x1870BB3F0")]
	public static bool NDHNKCOCJIF(this OutfitType JLMKKDGCFEI, IEPCDHHNEOA EFKLNALJCMF)
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
public static class MILKMBNOFOD
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x70BCA10", Offset = "0x70BBC10", VA = "0x1870BCA10")]
	public static bool LAGDNAOCELF(this AvatarItemSidednessEquipType BFIOEOEOJPG, IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x70BC9E0", Offset = "0x70BBBE0", VA = "0x1870BC9E0")]
	public static bool KGCAEFKDPKK(this AvatarItemSidednessEquipType JJFMPKIJCLA, IEPCDHHNEOA EFKLNALJCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70BC9C0", Offset = "0x70BBBC0", VA = "0x1870BC9C0")]
	public static bool COKNIIENNHK(this AvatarItemSidednessEquipType ADOOMNGHDKO, AvatarItemSidednessEquipType EKEJANOFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x70BC9A0", Offset = "0x70BBBA0", VA = "0x1870BC9A0")]
	public static AvatarItemSidednessEquipType CAELIEHEIAF(this AvatarItemSidednessEquipType ADOOMNGHDKO)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum BEJHHBGGIOI
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
public static class PEALMICAGIB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x70BD510", Offset = "0x70BC710", VA = "0x1870BD510")]
	private static BEJHHBGGIOI ICFNEIJONOK(this OutfitType JLMKKDGCFEI)
	{
		return default(BEJHHBGGIOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70BD3A0", Offset = "0x70BC5A0", VA = "0x1870BD3A0")]
	public static OutfitSlotFlags GMNHDJOHHBM(this OutfitType JLMKKDGCFEI)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x70BD390", Offset = "0x70BC590", VA = "0x1870BD390")]
	public static bool CMFCKAHJIPI(this OutfitSlotFlags EFACDBJPDNN, OutfitSlotFlags FNGBFAJJIFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x70BD680", Offset = "0x70BC880", VA = "0x1870BD680")]
	public static bool OGCHAGOCAGK(this OutfitType JLMKKDGCFEI, OutfitSlotFlags ABBLANIBDLG)
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
