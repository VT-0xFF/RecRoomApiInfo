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
public interface DDKEHICHJJN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float CECHLEMOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float OJDKJDECLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float DDHHELEHCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float JKIGLOLDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float MALNOHMAKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float MLAHFNDDFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float OODHHHPDKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float AAKHIBECFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EJJOIPNHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float FIAMCEGMLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float LOHLNIICEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float EGFEPIFNCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float EABGCHLALAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float BNLOAPLCHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float KPDOMFFIBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HGPEOOAJGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 MIGOGIGGDMA(Vector3 NAMBHOOINPM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 FDMGMCLOPOL(Vector3 MKHAFPJKJLF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 EMHKCINEPPH();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : DDKEHICHJJN
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
			[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB2CE50", Offset = "0xB2BC50", VA = "0x180B2CE50", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB1B70", VA = "0x180AB2D70", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAB30B0", Offset = "0xAB1EB0", VA = "0x180AB30B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAAE470", Offset = "0xAAD270", VA = "0x180AAE470", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xFA7260", Offset = "0xFA6060", VA = "0x180FA7260", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD15830", Offset = "0xD14630", VA = "0x180D15830", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA88C90", Offset = "0xA87A90", VA = "0x180A88C90", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F36410", Offset = "0x7F35210", VA = "0x187F36410")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F37320", Offset = "0x7F36120", VA = "0x187F37320")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F37300", Offset = "0x7F36100", VA = "0x187F37300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1169E20", Offset = "0x1168C20", VA = "0x181169E20", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xE93C60", Offset = "0xE92A60", VA = "0x180E93C60", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAA8EF0", Offset = "0xAA7CF0", VA = "0x180AA8EF0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD06540", Offset = "0xD05340", VA = "0x180D06540", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFEFDD0", Offset = "0xFEEBD0", VA = "0x180FEFDD0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x11F3CB0", Offset = "0x11F2AB0", VA = "0x1811F3CB0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F363F0", Offset = "0x7F351F0", VA = "0x187F363F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F37340", Offset = "0x7F36140", VA = "0x187F37340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7F372E0", Offset = "0x7F360E0", VA = "0x187F372E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x11F3CF0", Offset = "0x11F2AF0", VA = "0x1811F3CF0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xDA1B60", Offset = "0xDA0960", VA = "0x180DA1B60", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDA13F0", Offset = "0xDA01F0", VA = "0x180DA13F0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA73970", Offset = "0xA72770", VA = "0x180A73970", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7F37360", Offset = "0x7F36160", VA = "0x187F37360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F373A0", Offset = "0x7F361A0", VA = "0x187F373A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F37380", Offset = "0x7F36180", VA = "0x187F37380")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F373C0", Offset = "0x7F361C0", VA = "0x187F373C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F37250", Offset = "0x7F36050", VA = "0x187F37250")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F36EA0", Offset = "0x7F35CA0", VA = "0x187F36EA0")]
		public BHJLPMKOMMK NEEPMANGNIC(BHJLPMKOMMK LNHDCCDHIDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F363F0", Offset = "0x7F351F0", VA = "0x187F363F0", Slot = "25")]
		public Vector3 DJJAFOPNFMJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F36410", Offset = "0x7F35210", VA = "0x187F36410", Slot = "22")]
		public Vector3 EMHKCINEPPH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F36E30", Offset = "0x7F35C30", VA = "0x187F36E30", Slot = "20")]
		public Vector3 MIGOGIGGDMA(Vector3 NAMBHOOINPM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F36540", Offset = "0x7F35340", VA = "0x187F36540", Slot = "21")]
		public Vector3 FDMGMCLOPOL(Vector3 MKHAFPJKJLF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F36430", Offset = "0x7F35230", VA = "0x187F36430", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F368C0", Offset = "0x7F356C0", VA = "0x187F368C0")]
		protected bool IDJKLHLFCIN(AnchorParamsRestrictions LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F365C0", Offset = "0x7F353C0", VA = "0x187F365C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F36DC0", Offset = "0x7F35BC0", VA = "0x187F36DC0")]
		[CompilerGenerated]
		internal static bool IOEPEDDAPLJ(float LKPLCEODICL, float MANCHAKPLNN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DPFJGFHOBHH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1808420", Offset = "0x1807220", VA = "0x181808420")]
	public static bool HDNOLKDDAAE(this EEPOCEICAIB JJKILOJLKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F37E00", Offset = "0x7F36C00", VA = "0x187F37E00")]
	public static bool CMBBBCBNHCG(this EEPOCEICAIB JJKILOJLKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F37E30", Offset = "0x7F36C30", VA = "0x187F37E30")]
	public static bool NBGJHANNBNO(this EEPOCEICAIB JJKILOJLKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F37E10", Offset = "0x7F36C10", VA = "0x187F37E10")]
	public static bool JHAGPOALDFB(this EEPOCEICAIB JJKILOJLKCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OEGMBKOOKDE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool EEPKDOHFNOB;
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
public static class FOIKCOBADGP
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F37ED0", Offset = "0x7F36CD0", VA = "0x187F37ED0")]
	public static bool KCMEBLINPKC(this HelmetHairMode AJFICFDMFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F37E50", Offset = "0x7F36C50", VA = "0x187F37E50")]
	public static PKNFPGJAIIB AGMCPDLKBNG(this AvatarItemBodyType ACFNDMMKHAL)
	{
		return default(PKNFPGJAIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F37FA0", Offset = "0x7F36DA0", VA = "0x187F37FA0")]
	public static AvatarItemBodyType OHPDHLEIMPH(this PKNFPGJAIIB ACFNDMMKHAL)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F37EE0", Offset = "0x7F36CE0", VA = "0x187F37EE0")]
	public static string MLGILELMLKO(this AvatarItemBodyType ACFNDMMKHAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DIDHBJJPDPM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F374B0", Offset = "0x7F362B0", VA = "0x187F374B0")]
	public static void IJDMLIDGJJL(Transform HOHHILEHAHA, Transform BHEIEEDBBHK, Transform FCIKLAOAIFN, Transform FOBEEBNHGIO, float LDBCDCMCDGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KIECLADILAP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum KIEMNLHBDDK
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
	public enum NMBEIOMGMML : long
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
	public static readonly IReadOnlyList<KIEMNLHBDDK> PJAPEOFJMAM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<KIEMNLHBDDK> JPDEKNNAABK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<KIEMNLHBDDK> OGNLDOKMAGD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IReadOnlyList<KIEMNLHBDDK> GPEPBFLGEGP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly NMBEIOMGMML CHAABPHFHNL;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly NMBEIOMGMML CIIPJKCLLGA;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly NMBEIOMGMML NOOHKCNEIGD;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F39050", Offset = "0x7F37E50", VA = "0x187F39050")]
	public static NMBEIOMGMML BDDEKLGALOO(NMBEIOMGMML HGIBFNANPGK, NMBEIOMGMML EFDJABOCLML)
	{
		return default(NMBEIOMGMML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F39060", Offset = "0x7F37E60", VA = "0x187F39060")]
	public static NMBEIOMGMML DFAOJGHBNIG(NMBEIOMGMML EMBAANBIJHP, NMBEIOMGMML OJDFDNKNFPP)
	{
		return default(NMBEIOMGMML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F39070", Offset = "0x7F37E70", VA = "0x187F39070")]
	public static NMBEIOMGMML ELAPJPNKDPK(KIEMNLHBDDK BHEBGLCGIPD, NMBEIOMGMML FCAIGPGKOKF)
	{
		return default(NMBEIOMGMML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F39080", Offset = "0x7F37E80", VA = "0x187F39080")]
	public static NMBEIOMGMML JKAIFODGDGP(KIEMNLHBDDK BHEBGLCGIPD, NMBEIOMGMML FCAIGPGKOKF)
	{
		return default(NMBEIOMGMML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LBLHCCCPDJA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum HFLFPLIMCIA : short
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
			[Cpp2IlInjected.Address(RVA = "0x7F38B20", Offset = "0x7F37920", VA = "0x187F38B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F388F0", Offset = "0x7F376F0", VA = "0x187F388F0")]
		public void NLPFBFFGJLN(FitMeshHemisphere FABHMCKJDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F38400", Offset = "0x7F37200", VA = "0x187F38400")]
		public Vector3 MHNBAIJMHBD(Vector2 JCMIDJDOHLA, bool ICAIANPLIGP = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7F38020", Offset = "0x7F36E20", VA = "0x187F38020")]
		public Vector3 BMEIMBEBIEP(Vector2 JCMIDJDOHLA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F38080", Offset = "0x7F36E80", VA = "0x187F38080")]
		public Quaternion HCPHGOEAIHL(Vector2 JCMIDJDOHLA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F38240", Offset = "0x7F37040", VA = "0x187F38240")]
		public Quaternion HCPHGOEAIHL(Vector2 JCMIDJDOHLA, Vector3 KEKFCGCJLGL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F383B0", Offset = "0x7F371B0", VA = "0x187F383B0")]
		public Vector2 JIGJELINLJA(Vector2 NBIHODMAPPI)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F38A70", Offset = "0x7F37870", VA = "0x187F38A70")]
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
		Roomie_Hat = 500
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JOKLAAKBBOM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F39020", Offset = "0x7F37E20", VA = "0x187F39020")]
	public static bool NLHGBECNNJM(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F38FF0", Offset = "0x7F37DF0", VA = "0x187F38FF0")]
	public static bool HAHFEDGDNDK(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F39010", Offset = "0x7F37E10", VA = "0x187F39010")]
	public static bool IGMPLDLFBHF(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F38FD0", Offset = "0x7F37DD0", VA = "0x187F38FD0")]
	public static bool CPICMGDBNFG(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F38FA0", Offset = "0x7F37DA0", VA = "0x187F38FA0")]
	public static bool BAMDCCNBAFL(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F38F80", Offset = "0x7F37D80", VA = "0x187F38F80")]
	public static bool APPLLBNPPCD(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F39040", Offset = "0x7F37E40", VA = "0x187F39040")]
	public static bool PCBLIOMCAND(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F38F70", Offset = "0x7F37D70", VA = "0x187F38F70")]
	public static bool ABGGMIFCJFP(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F38FB0", Offset = "0x7F37DB0", VA = "0x187F38FB0")]
	public static bool BGDFFCGIEPD(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F38FE0", Offset = "0x7F37DE0", VA = "0x187F38FE0")]
	public static bool GIPDDIACEJM(this OutfitType LGFKMEIIJCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OMCKGCPFJHF : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly OMCKGCPFJHF ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F397E0", Offset = "0x7F385E0", VA = "0x187F397E0", Slot = "4")]
	public bool Equals(OutfitType NEJEBKPBMJP, OutfitType CGDIPCNEKPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F39840", Offset = "0x7F38640", VA = "0x187F39840", Slot = "5")]
	public int GetHashCode(OutfitType DGPNPBEKOOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OMCKGCPFJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CIFKFNNENFH
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum EPOJPLJLNGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MGDCHFMJKNI
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OCJFAFENDPC
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum JPLNFBHFPMI
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BDLLACEJLDO
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F35900", Offset = "0x7F34700", VA = "0x187F35900", Slot = "7")]
		public override bool Equals(AdditionalFeetData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F35930", Offset = "0x7F34730", VA = "0x187F35930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F359B0", Offset = "0x7F347B0", VA = "0x187F359B0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F35EF0", Offset = "0x7F34CF0", VA = "0x187F35EF0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F359F0", Offset = "0x7F347F0", VA = "0x187F359F0", Slot = "7")]
		public override bool Equals(AdditionalHatData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F35BE0", Offset = "0x7F349E0", VA = "0x187F35BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F35D40", Offset = "0x7F34B40", VA = "0x187F35D40")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F36000", Offset = "0x7F34E00", VA = "0x187F36000")]
		public static bool HHEPOPPAMDO(OutfitType DGPNPBEKOOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F36030", Offset = "0x7F34E30", VA = "0x187F36030")]
		public static AdditionalOutfitTypeData LDFHHMLGJNG(OutfitType DGPNPBEKOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F70", Offset = "0x7F34D70", VA = "0x187F35F70", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LOKLFHKEJPC);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x53DD550", Offset = "0x53DC350", VA = "0x1853DD550", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T LOKLFHKEJPC);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, LNGBOMALDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1272A30", Offset = "0x1271830", VA = "0x181272A30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F373E0", Offset = "0x7F361E0", VA = "0x187F373E0", Slot = "7")]
		public override bool Equals(BeardData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F37400", Offset = "0x7F36200", VA = "0x187F37400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F37470", Offset = "0x7F36270", VA = "0x187F37470")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, LNGBOMALDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD238E0", Offset = "0xD226E0", VA = "0x180D238E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA76760", Offset = "0xA75560", VA = "0x180A76760", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE41720", Offset = "0xE40520", VA = "0x180E41720")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F38EE0", Offset = "0x7F37CE0", VA = "0x187F38EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F38B30", Offset = "0x7F37930", VA = "0x187F38B30", Slot = "7")]
		public override bool Equals(HairData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F38D20", Offset = "0x7F37B20", VA = "0x187F38D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F38E20", Offset = "0x7F37C20", VA = "0x187F38E20")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LNGBOMALDBC
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool KMOBJOIFEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle FCBFIFDBCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class PDBNCIMPBJM
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F398F0", Offset = "0x7F386F0", VA = "0x187F398F0")]
	public static EEPOCEICAIB AFFJOOMEPLH(this OutfitType LGFKMEIIJCG, AvatarItemSidednessEquipType BLPHLHIILHI = AvatarItemSidednessEquipType.Left)
	{
		return default(EEPOCEICAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F39A10", Offset = "0x7F38810", VA = "0x187F39A10")]
	public static EEPOCEICAIB NIIMMMHHOEN(this EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(EEPOCEICAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F39980", Offset = "0x7F38780", VA = "0x187F39980")]
	public static bool MIBDLLHIDMG(this OutfitType LGFKMEIIJCG, EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class POBENALILBF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F39A60", Offset = "0x7F38860", VA = "0x187F39A60")]
	public static bool APLPPOIGDOH(this AvatarItemSidednessEquipType BLPHLHIILHI, EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F39A90", Offset = "0x7F38890", VA = "0x187F39A90")]
	public static bool GOANECOHPOA(this AvatarItemSidednessEquipType JLCOKIDLIMN, EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F39AC0", Offset = "0x7F388C0", VA = "0x187F39AC0")]
	public static bool HBMGAIJKDOG(this AvatarItemSidednessEquipType FPEEMJNIOMC, AvatarItemSidednessEquipType HACHNIIMJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F39AE0", Offset = "0x7F388E0", VA = "0x187F39AE0")]
	public static AvatarItemSidednessEquipType IDDPEKCEOFI(this AvatarItemSidednessEquipType FPEEMJNIOMC)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum AKCHPOPBDMP
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Wrist = 10,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Roomie_Head = 20
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Roomie_Head = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NADMFEPBHOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F39650", Offset = "0x7F38450", VA = "0x187F39650")]
	private static AKCHPOPBDMP PGDFIIPHOHF(this OutfitType LGFKMEIIJCG)
	{
		return default(AKCHPOPBDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F39290", Offset = "0x7F38090", VA = "0x187F39290")]
	public static OutfitSlotFlags CKFJACNNELJ(this OutfitType LGFKMEIIJCG)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F39640", Offset = "0x7F38440", VA = "0x187F39640")]
	public static bool OENDLJDJNFJ(this OutfitSlotFlags LHFPHLLFHKD, OutfitSlotFlags FMMNOPHOCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F39420", Offset = "0x7F38220", VA = "0x187F39420")]
	public static bool KJEOLHNIMDC(this OutfitType LGFKMEIIJCG, OutfitSlotFlags NKFFFFNKPMB)
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
