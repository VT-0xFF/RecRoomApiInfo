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
public interface BBLFEOKPNJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float IDAKNGGNIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float MDJDAGCFOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float ODINLPDJNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float FBOJCANPCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float JFLFMJIAPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float NGIPKBIHFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BMGMKDIONAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ENNLJBMECDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float HPAFHLFNOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PFJCPBGAEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float MNNFPKDFDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float OHKOBCNBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float EGNMACDJGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LJNDCEBGJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float COIMMFCKLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float DBPOOJDNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 KAICPJIEAHH(Vector3 MHENPFCKHON);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 OKFJEKEFNBJ(Vector3 CPPLEGJKGDK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 DBAGMJEGKFO();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : BBLFEOKPNJH
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
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB72670", Offset = "0xB70C70", VA = "0x180B72670", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFC0", Offset = "0xAEC5C0", VA = "0x180AEDFC0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD657B0", Offset = "0xD63DB0", VA = "0x180D657B0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAC6200", Offset = "0xAC4800", VA = "0x180AC6200", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x82D0D80", Offset = "0x82CF380", VA = "0x1882D0D80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x82D1CB0", Offset = "0x82D02B0", VA = "0x1882D1CB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82D1C90", Offset = "0x82D0290", VA = "0x1882D1C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAE7030", Offset = "0xAE5630", VA = "0x180AE7030", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF2EA00", Offset = "0xF2D000", VA = "0x180F2EA00", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAE9940", Offset = "0xAE7F40", VA = "0x180AE9940", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD5D9C0", Offset = "0xD5BFC0", VA = "0x180D5D9C0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x106F840", Offset = "0x106DE40", VA = "0x18106F840", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x128CC90", Offset = "0x128B290", VA = "0x18128CC90", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x82D1A10", Offset = "0x82D0010", VA = "0x1882D1A10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82D1CD0", Offset = "0x82D02D0", VA = "0x1882D1CD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82D1C70", Offset = "0x82D0270", VA = "0x1882D1C70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x128CCD0", Offset = "0x128B2D0", VA = "0x18128CCD0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xE15B30", Offset = "0xE14130", VA = "0x180E15B30", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE14FE0", Offset = "0xE135E0", VA = "0x180E14FE0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0990", Offset = "0xAAEF90", VA = "0x180AB0990", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82D1CF0", Offset = "0x82D02F0", VA = "0x1882D1CF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82D1D30", Offset = "0x82D0330", VA = "0x1882D1D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82D1D10", Offset = "0x82D0310", VA = "0x1882D1D10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82D1D50", Offset = "0x82D0350", VA = "0x1882D1D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82D1BE0", Offset = "0x82D01E0", VA = "0x1882D1BE0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82D16B0", Offset = "0x82CFCB0", VA = "0x1882D16B0")]
		public NKKOKKMIKCN JDDOEHOHFFE(NKKOKKMIKCN NHLACENEFKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82D1A10", Offset = "0x82D0010", VA = "0x1882D1A10", Slot = "25")]
		public Vector3 MFCFHODGKJO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82D0D80", Offset = "0x82CF380", VA = "0x1882D0D80", Slot = "22")]
		public Vector3 DBAGMJEGKFO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82D19A0", Offset = "0x82CFFA0", VA = "0x1882D19A0", Slot = "20")]
		public Vector3 KAICPJIEAHH(Vector3 MHENPFCKHON)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82D1AA0", Offset = "0x82D00A0", VA = "0x1882D1AA0", Slot = "21")]
		public Vector3 OKFJEKEFNBJ(Vector3 CPPLEGJKGDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82D0DA0", Offset = "0x82CF3A0", VA = "0x1882D0DA0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82D11B0", Offset = "0x82CF7B0", VA = "0x1882D11B0")]
		protected bool HILCECGHHLN(AnchorParamsRestrictions IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82D0EB0", Offset = "0x82CF4B0", VA = "0x1882D0EB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82D1A30", Offset = "0x82D0030", VA = "0x1882D1A30")]
		[CompilerGenerated]
		internal static bool NLHNJFJIKKJ(float IAFDMJDNHDH, float DFKKOPOBCBA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JIBODIBCCDB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x18C3A50", Offset = "0x18C2050", VA = "0x1818C3A50")]
	public static bool JOODENBOPKE(this CNFLLNFLBIO ODAFEHBHNNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82D2FF0", Offset = "0x82D15F0", VA = "0x1882D2FF0")]
	public static bool ACPBINFOOIA(this CNFLLNFLBIO ODAFEHBHNNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82D3000", Offset = "0x82D1600", VA = "0x1882D3000")]
	public static bool FDCMENACLPE(this CNFLLNFLBIO ODAFEHBHNNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82D3020", Offset = "0x82D1620", VA = "0x1882D3020")]
	public static bool OGNCFMOPJII(this CNFLLNFLBIO ODAFEHBHNNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ONJLKEOLIJO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool DPFAHNCNCGO;
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
public static class NJEFBOKCGEE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82D4570", Offset = "0x82D2B70", VA = "0x1882D4570")]
	public static bool ILKBJJLIONB(this HelmetHairMode NPBLMDAMKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82D4580", Offset = "0x82D2B80", VA = "0x1882D4580")]
	public static GAPGDDKJAHD MIFEMLFLHOH(this AvatarItemBodyType JPMNEABEAJJ)
	{
		return default(GAPGDDKJAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82D4600", Offset = "0x82D2C00", VA = "0x1882D4600")]
	public static AvatarItemBodyType PINONDAGGDO(this GAPGDDKJAHD JPMNEABEAJJ)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82D44B0", Offset = "0x82D2AB0", VA = "0x1882D44B0")]
	public static string HCNNGOMLCOH(this AvatarItemBodyType JPMNEABEAJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LBDNOKBKJIH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82D30C0", Offset = "0x82D16C0", VA = "0x1882D30C0")]
	public static void BKDJFNPMFGC(Transform EHJBJKIBKNF, Transform EACPFFFAALP, Transform JAEANILHPHO, Transform JJFABIAOPAP, float PGFAAOFDDEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LINIKLIADHK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum BICPFDBOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		DEPRECATED_SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DEPRECATED_SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		DEPRECATED_PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		DEPRECATED_FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		DEPRECATED_ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		DEPRECATED_PantsShort,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		DEPRECATED_Ears,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		DEPRECATED_FootHigh,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Neck,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		EarLeft,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		EarRight,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SleevesShortLeft,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SleevesShortRight,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		SleevesLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		SleevesLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PantsLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		FootMidLeft,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FootMidRight,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		FootLowLeft,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FootLowRight,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PantsShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		PantsShortRight,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		UpperThighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		UpperThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FootHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FootHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FootAnkleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		FootAnkleRight,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		TorsoCrop,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		FingersOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		FingersOnlyRight,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		ArmpitLeft,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		ArmpitRight,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		TorsoTop,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Modesty,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		ShortShorts,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		SleevesSuperShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SleevesSuperShortRight,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		SleevesMidLeft,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		SleevesMidRight,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		PantsKneeHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		PantsKneeHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		LowerThighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		LowerThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		HandsThumbOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		HandsThumbOnlyRight
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum NMCDOKKFLGH : long
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Head = 1L,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		TorsoAll = 2L,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		TorsoHigh = 4L,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		TorsoLow = 8L,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		SleevesShort = 0x10L,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		SleevesLong = 0x20L,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		DEPRECATED_Palm = 0x40L,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		DEPRECATED_HandsAll = 0x80L,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		PantsLong = 0x100L,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shorts = 0x200L,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		FootMid = 0x400L,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		ShoeLow = 0x800L,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		PantsShort = 0x1000L,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		PalmL = 0x2000L,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		PalmR = 0x4000L,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		HandL = 0x8000L,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		HandR = 0x10000L,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Ears = 0x20000L,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		FootHigh = 0x40000L,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Neck = 0x80000L,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		EarLeft = 0x100000L,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		EarRight = 0x200000L,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		SleevesShortLeft = 0x400000L,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		SleevesShortRight = 0x800000L,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SleevesLongLeft = 0x1000000L,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		SleevesLongRight = 0x2000000L,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		PantsLongLeft = 0x4000000L,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		PantsLongRight = 0x8000000L,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		FootMidLeft = 0x10000000L,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		FootMidRight = 0x20000000L,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FootLowLeft = 0x40000000L,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FootLowRight = 0x80000000L,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		PantsShortLeft = 0x100000000L,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		PantsShortRight = 0x200000000L,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		UpperThighLeft = 0x400000000L,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		UpperThighRight = 0x800000000L,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FootHighLeft = 0x1000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FootHighRight = 0x2000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FootAnkleLeft = 0x4000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		FootAnkleRight = 0x8000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		TorsoCrop = 0x10000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		FingersOnlyLeft = 0x20000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		FingersOnlyRight = 0x40000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ArmpitLeft = 0x80000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		ArmpitRight = 0x100000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		TorsoTop = 0x200000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Modesty = 0x400000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		ShortShorts = 0x800000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		SleevesSuperShortLeft = 0x1000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		SleevesSuperShortRight = 0x2000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		SleevesMidLeft = 0x4000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		SleevesMidRight = 0x8000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		PantsKneeHighLeft = 0x10000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		PantsKneeHighRight = 0x20000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		LowerThighLeft = 0x40000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		LowerThighRight = 0x80000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		HandsThumbOnlyLeft = 0x100000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		HandsThumbOnlyRight = 0x200000000000000L
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<BICPFDBOLLB> BFMKJICGLDO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<BICPFDBOLLB> FFGLIJNPLFN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<BICPFDBOLLB> HCBCFKELGPA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IReadOnlyList<BICPFDBOLLB> APIKPKDFFOJ;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly NMCDOKKFLGH BMLAIDCFDFH;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly NMCDOKKFLGH BEIECOKPDHM;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly NMCDOKKFLGH KFOHEOPCADN;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82D4080", Offset = "0x82D2680", VA = "0x1882D4080")]
	public static NMCDOKKFLGH GNJFLGCDJKC(NMCDOKKFLGH JAFHBOMDIHH, NMCDOKKFLGH GDNJCBEDDDC)
	{
		return default(NMCDOKKFLGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82D4070", Offset = "0x82D2670", VA = "0x1882D4070")]
	public static NMCDOKKFLGH GJHFOMNKLGE(NMCDOKKFLGH BCCFEJEIOIA, NMCDOKKFLGH GPEFGPGOMLN)
	{
		return default(NMCDOKKFLGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82D40B0", Offset = "0x82D26B0", VA = "0x1882D40B0")]
	public static NMCDOKKFLGH PLNJGCNMLBL(BICPFDBOLLB IJKEHJNCOFB, NMCDOKKFLGH JDEGGPFBJPG)
	{
		return default(NMCDOKKFLGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82D4090", Offset = "0x82D2690", VA = "0x1882D4090")]
	public static NMCDOKKFLGH KCLGEHCEMGF(BICPFDBOLLB IJKEHJNCOFB, NMCDOKKFLGH JDEGGPFBJPG)
	{
		return default(NMCDOKKFLGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BGGDANJGGNE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NFEMHKKOOOD : short
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x82D2AF0", Offset = "0x82D10F0", VA = "0x1882D2AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82D2860", Offset = "0x82D0E60", VA = "0x1882D2860")]
		public void IDBCNPANPLI(FitMeshHemisphere DINNKMBKBAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82D2320", Offset = "0x82D0920", VA = "0x1882D2320")]
		public Vector3 EDJLBCLJINE(Vector2 HPMBAPLIPOG, bool IEKBDNFOEMH = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82D28B0", Offset = "0x82D0EB0", VA = "0x1882D28B0")]
		public Vector3 LDFBHGMFPNL(Vector2 HPMBAPLIPOG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82D2160", Offset = "0x82D0760", VA = "0x1882D2160")]
		public Quaternion BLDMMEFJDMB(Vector2 HPMBAPLIPOG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82D1FF0", Offset = "0x82D05F0", VA = "0x1882D1FF0")]
		public Quaternion BLDMMEFJDMB(Vector2 HPMBAPLIPOG, Vector3 IPMPPDJCNOG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82D2810", Offset = "0x82D0E10", VA = "0x1882D2810")]
		public Vector2 HEINNJBEGIH(Vector2 NIADOHFPFMP)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82D2A40", Offset = "0x82D1040", VA = "0x1882D2A40")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Feet = 301,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Roomie_Hat = 500,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Roomie_Waist = 501,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Roomie_Eye = 502,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Roomie_Mouth = 503,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Roomie_Equipment = 504
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OPJKALFAEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82D4770", Offset = "0x82D2D70", VA = "0x1882D4770")]
	public static bool NAFDOAGKFPP(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82D4690", Offset = "0x82D2C90", VA = "0x1882D4690")]
	public static bool CKNGCCFBMOF(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82D46C0", Offset = "0x82D2CC0", VA = "0x1882D46C0")]
	public static bool KCIHDEOINAJ(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82D4740", Offset = "0x82D2D40", VA = "0x1882D4740")]
	public static bool MHNFDJCKNHJ(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82D4710", Offset = "0x82D2D10", VA = "0x1882D4710")]
	public static bool LMBAKHBHLNL(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82D4750", Offset = "0x82D2D50", VA = "0x1882D4750")]
	public static bool MOAAPAKEPDI(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82D4680", Offset = "0x82D2C80", VA = "0x1882D4680")]
	public static bool BKPDCCAOFCB(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82D46B0", Offset = "0x82D2CB0", VA = "0x1882D46B0")]
	public static bool EFBLFOFJHNA(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82D4720", Offset = "0x82D2D20", VA = "0x1882D4720")]
	public static bool MABIICNGLJI(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82D46D0", Offset = "0x82D2CD0", VA = "0x1882D46D0")]
	public static bool KPGGAHAGPCK(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82D46E0", Offset = "0x82D2CE0", VA = "0x1882D46E0")]
	public static bool LEBAMFIPEIP(this OutfitType FPGBMFMFODG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DFHIFBMDAPI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static readonly DFHIFBMDAPI DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EE0", Offset = "0x82D04E0", VA = "0x1882D1EE0", Slot = "4")]
	public bool Equals(OutfitType JNMDJGLICGG, OutfitType BFMGMEMBOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82D1F40", Offset = "0x82D0540", VA = "0x1882D1F40", Slot = "5")]
	public int GetHashCode(OutfitType EHLAHNIAPLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DFHIFBMDAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IIPBNGJJJBD
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BLPLKKCPBII
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FGAMIEKEMIN
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum AJKPMNIKDDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ADFCGNJBKIO
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DNBLNCAFAFK
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum RoomieEquipmentType
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Quest_Sword_1 = 0,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Quest_Crossbow_1 = 10
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82D0070", Offset = "0x82CE670", VA = "0x1882D0070", Slot = "7")]
		public override bool Equals(AdditionalFeetData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82D00A0", Offset = "0x82CE6A0", VA = "0x1882D00A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82D0120", Offset = "0x82CE720", VA = "0x1882D0120")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82D05F0", Offset = "0x82CEBF0", VA = "0x1882D05F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82D0160", Offset = "0x82CE760", VA = "0x1882D0160", Slot = "7")]
		public override bool Equals(AdditionalHatData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82D0350", Offset = "0x82CE950", VA = "0x1882D0350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82D04B0", Offset = "0x82CEAB0", VA = "0x1882D04B0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82D0670", Offset = "0x82CEC70", VA = "0x1882D0670")]
		public static bool DBOLKCGPMFJ(OutfitType EHLAHNIAPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82D06C0", Offset = "0x82CECC0", VA = "0x1882D06C0")]
		public static AdditionalOutfitTypeData EEPJBIPIECL(OutfitType EHLAHNIAPLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82D0CF0", Offset = "0x82CF2F0", VA = "0x1882D0CF0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData IBCMCOKAJEM);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x57E2140", Offset = "0x57E0740", VA = "0x1857E2140", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T IBCMCOKAJEM);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JFLEENLOFJG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82D2F40", Offset = "0x82D1540", VA = "0x1882D2F40")]
	public static bool NMIFIEMGCKH(this AdditionalOutfitTypeData AHHMCPBDCKE)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, BDLKPMEILHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130C300", VA = "0x18130DD00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x82D1D70", Offset = "0x82D0370", VA = "0x1882D1D70", Slot = "7")]
		public override bool Equals(BeardData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82D1D90", Offset = "0x82D0390", VA = "0x1882D1D90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82D1E00", Offset = "0x82D0400", VA = "0x1882D1E00")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HairData : AdditionalOutfitTypeData<HairData>, BDLKPMEILHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD946A0", Offset = "0xD92CA0", VA = "0x180D946A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB3890", Offset = "0xAB1E90", VA = "0x180AB3890", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xEAD280", Offset = "0xEAB880", VA = "0x180EAD280")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x82D2EB0", Offset = "0x82D14B0", VA = "0x1882D2EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82D2B00", Offset = "0x82D1100", VA = "0x1882D2B00", Slot = "7")]
		public override bool Equals(HairData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82D2CF0", Offset = "0x82D12F0", VA = "0x1882D2CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82D2DF0", Offset = "0x82D13F0", VA = "0x1882D2DF0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KHALJEIFAPO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool JOMLIJHJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GPNGNEJBKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AnchorParamsRestrictions AHCBAHOLFPM();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BDLKPMEILHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MGIEOLNKCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HairPatternStyle HLFFNMCEGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DIIFJJNJLDF
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	const string ENONHDKGABE = "FFFFFF";

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KFCEGGGBGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string PKNLBOPAADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RoomieEquipmentData : AdditionalOutfitTypeData<RoomieEquipmentData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public RoomieEquipmentType equipmentType;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public RoomieEquipmentType EquipmentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
			get
			{
				return default(RoomieEquipmentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CB16D0", Offset = "0x7CAFCD0", VA = "0x187CB16D0", Slot = "7")]
		public override bool Equals(RoomieEquipmentData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82D4790", Offset = "0x82D2D90", VA = "0x1882D4790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x82D47F0", Offset = "0x82D2DF0", VA = "0x1882D47F0")]
		public RoomieEquipmentData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RoomieEyeData : AdditionalOutfitTypeData<RoomieEyeData>, DIIFJJNJLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x82D4830", Offset = "0x82D2E30", VA = "0x1882D4830", Slot = "7")]
		public override bool Equals(RoomieEyeData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82D4860", Offset = "0x82D2E60", VA = "0x1882D4860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x82D48D0", Offset = "0x82D2ED0", VA = "0x1882D48D0")]
		public RoomieEyeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RoomieHatData : AdditionalOutfitTypeData<RoomieHatData>, DIIFJJNJLDF, KHALJEIFAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsTranslatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x82D4B00", Offset = "0x82D3100", VA = "0x1882D4B00", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x82D4AE0", Offset = "0x82D30E0", VA = "0x1882D4AE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82D4940", Offset = "0x82D2F40", VA = "0x1882D4940", Slot = "7")]
		public override bool Equals(RoomieHatData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82D49B0", Offset = "0x82D2FB0", VA = "0x1882D49B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "12")]
		public AnchorParamsRestrictions AHCBAHOLFPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82D4A30", Offset = "0x82D3030", VA = "0x1882D4A30")]
		public RoomieHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RoomieMouthData : AdditionalOutfitTypeData<RoomieMouthData>, DIIFJJNJLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82D4830", Offset = "0x82D2E30", VA = "0x1882D4830", Slot = "7")]
		public override bool Equals(RoomieMouthData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82D4B20", Offset = "0x82D3120", VA = "0x1882D4B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82D4B90", Offset = "0x82D3190", VA = "0x1882D4B90")]
		public RoomieMouthData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class RoomieWaistData : AdditionalOutfitTypeData<RoomieWaistData>, DIIFJJNJLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82D4830", Offset = "0x82D2E30", VA = "0x1882D4830", Slot = "7")]
		public override bool Equals(RoomieWaistData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82D4C00", Offset = "0x82D3200", VA = "0x1882D4C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82D4C70", Offset = "0x82D3270", VA = "0x1882D4C70")]
		public RoomieWaistData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class ACEILBOHGLG
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x82CFF90", Offset = "0x82CE590", VA = "0x1882CFF90")]
	public static CNFLLNFLBIO DBLDKIDPCEC(this OutfitType FPGBMFMFODG, AvatarItemSidednessEquipType CIMNFNAMIMG = AvatarItemSidednessEquipType.Left)
	{
		return default(CNFLLNFLBIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x82CFEC0", Offset = "0x82CE4C0", VA = "0x1882CFEC0")]
	public static FJIDOAJCOFJ ABHKGOOMDNA(this OutfitType FPGBMFMFODG, AvatarItemSidednessEquipType CIMNFNAMIMG = AvatarItemSidednessEquipType.Left)
	{
		return default(FJIDOAJCOFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82D0020", Offset = "0x82CE620", VA = "0x1882D0020")]
	public static CNFLLNFLBIO INEMJFIHMBD(this CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(CNFLLNFLBIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82CFEF0", Offset = "0x82CE4F0", VA = "0x1882CFEF0")]
	public static bool BHPCKJHMKIK(this OutfitType FPGBMFMFODG, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CKALGECDIIL
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82D1EB0", Offset = "0x82D04B0", VA = "0x1882D1EB0")]
	public static bool HMPMFAAONCA(this AvatarItemSidednessEquipType CIMNFNAMIMG, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82D1E40", Offset = "0x82D0440", VA = "0x1882D1E40")]
	public static bool ANELBHKMFPP(this AvatarItemSidednessEquipType FICMFBAINKM, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82D1E70", Offset = "0x82D0470", VA = "0x1882D1E70")]
	public static bool BBJCIIIMKEE(this AvatarItemSidednessEquipType NOAOJBHMIMC, AvatarItemSidednessEquipType PFLHHCDPOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82D1E90", Offset = "0x82D0490", VA = "0x1882D1E90")]
	public static AvatarItemSidednessEquipType HICDILFEDHB(this AvatarItemSidednessEquipType NOAOJBHMIMC)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IPGCKCECEGD
{
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Wrist = 10,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Roomie_Head = 20,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Roomie_Waist = 21,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Roomie_Eye = 22,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Roomie_Mouth = 23,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Roomie_Tool = 24
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Roomie_Head = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Roomie_Waist = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Roomie_Eye = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LHAMFGNDDLO
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82D3A10", Offset = "0x82D2010", VA = "0x1882D3A10")]
	private static IPGCKCECEGD AHHHLPLOOHJ(this OutfitType FPGBMFMFODG)
	{
		return default(IPGCKCECEGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82D3BF0", Offset = "0x82D21F0", VA = "0x1882D3BF0")]
	public static OutfitSlotFlags KHFKCOFDMNC(this OutfitType FPGBMFMFODG)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82D4060", Offset = "0x82D2660", VA = "0x1882D4060")]
	public static bool POLEHBHMLHP(this OutfitSlotFlags KNBCEHBLCLP, OutfitSlotFlags MOLFIOKFGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x82D3DD0", Offset = "0x82D23D0", VA = "0x1882D3DD0")]
	public static bool LPGGEPCMKGO(this OutfitType FPGBMFMFODG, OutfitSlotFlags ABDFGPFHKKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NBNMALPKJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Vector4 OOBJAHENJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4 GJDNMHPEEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4 GGAPJNIHNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4 EPJKKIGHJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4 GAMHFNMNKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4 KCFFAOFOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4 ADMOCMAADDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4 DKDFBLPHLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4 GFNCECMNHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Vector4 PMEKPFCBOAC;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82D42B0", Offset = "0x82D28B0", VA = "0x1882D42B0")]
	public void MGBJPEOFIAI(Material PFCMAMCIDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LANCEJILHOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public Texture2D NMJCPKCIOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public Texture2D JIHEMNLICAL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82D3040", Offset = "0x82D1640", VA = "0x1882D3040")]
	public void MGBJPEOFIAI(Material PFCMAMCIDIC)
	{
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
