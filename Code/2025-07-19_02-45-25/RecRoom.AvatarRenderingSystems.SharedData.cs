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
public interface JOFBOADHHGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float EGMCANMLJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float PNMBIMMNKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float LFBFBBGNFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float PPOEPHMABHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float ILNGAKEFKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float LDLMDIELMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float HKHGBDPBPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float HHOMKACDMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DMNFDPIPIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HCHDHNALGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float NALJMCNKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float LMNEOLJFCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float FPHPCLFBINO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float CMMHOBLMLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float GJLAPAIICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float OEIKJOBLAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 OOCOHJIAHEA(Vector3 FHACMMGNAAD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 IJLNBKFMDFC(Vector3 LPKDHCJJDBN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 OLPNALCCNKC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : JOFBOADHHGM
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
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB3C180", Offset = "0xB3B180", VA = "0x180B3C180", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xABF1F0", Offset = "0xABE1F0", VA = "0x180ABF1F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xABF200", Offset = "0xABE200", VA = "0x180ABF200", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAADEE0", Offset = "0xAACEE0", VA = "0x180AADEE0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xFA6CB0", Offset = "0xFA5CB0", VA = "0x180FA6CB0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD16D90", Offset = "0xD15D90", VA = "0x180D16D90", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA90920", Offset = "0xA8F920", VA = "0x180A90920", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3840", Offset = "0x7FE2840", VA = "0x187FE3840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A60", Offset = "0x7FE2A60", VA = "0x187FE3A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A40", Offset = "0x7FE2A40", VA = "0x187FE3A40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1170DB0", Offset = "0x116FDB0", VA = "0x181170DB0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xEC2860", Offset = "0xEC1860", VA = "0x180EC2860", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F20", Offset = "0xAB1F20", VA = "0x180AB2F20", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD09AA0", Offset = "0xD08AA0", VA = "0x180D09AA0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1006500", Offset = "0x1005500", VA = "0x181006500", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x122F470", Offset = "0x122E470", VA = "0x18122F470", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3820", Offset = "0x7FE2820", VA = "0x187FE3820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A80", Offset = "0x7FE2A80", VA = "0x187FE3A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A20", Offset = "0x7FE2A20", VA = "0x187FE3A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x122F4B0", Offset = "0x122E4B0", VA = "0x18122F4B0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xDB0B00", Offset = "0xDAFB00", VA = "0x180DB0B00", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDB0980", Offset = "0xDAF980", VA = "0x180DB0980", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA7B750", Offset = "0xA7A750", VA = "0x180A7B750", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3AA0", Offset = "0x7FE2AA0", VA = "0x187FE3AA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3AE0", Offset = "0x7FE2AE0", VA = "0x187FE3AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3AC0", Offset = "0x7FE2AC0", VA = "0x187FE3AC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3B00", Offset = "0x7FE2B00", VA = "0x187FE3B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3990", Offset = "0x7FE2990", VA = "0x187FE3990")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7FE30A0", Offset = "0x7FE20A0", VA = "0x187FE30A0")]
		public KCJIIMMAEMJ CMKHJMBDIJO(KCJIIMMAEMJ PNMCOJJOHKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3820", Offset = "0x7FE2820", VA = "0x187FE3820", Slot = "25")]
		public Vector3 INBMJFDHDDN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3840", Offset = "0x7FE2840", VA = "0x187FE3840", Slot = "22")]
		public Vector3 OLPNALCCNKC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3860", Offset = "0x7FE2860", VA = "0x187FE3860", Slot = "20")]
		public Vector3 OOCOHJIAHEA(Vector3 FHACMMGNAAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FE37A0", Offset = "0x7FE27A0", VA = "0x187FE37A0", Slot = "21")]
		public Vector3 IJLNBKFMDFC(Vector3 LPKDHCJJDBN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3390", Offset = "0x7FE2390", VA = "0x187FE3390", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2B30", Offset = "0x7FE1B30", VA = "0x187FE2B30")]
		protected bool AENKCNBBPNI(AnchorParamsRestrictions EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FE34A0", Offset = "0x7FE24A0", VA = "0x187FE34A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3030", Offset = "0x7FE2030", VA = "0x187FE3030")]
		[CompilerGenerated]
		internal static bool APOCLPFNHBM(float JDINPJIAKOC, float LDPKBPICKKH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OKDBDOHGJNE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x18319B0", Offset = "0x18309B0", VA = "0x1818319B0")]
	public static bool FFKIEDMIEEM(this IJELGOILOGJ CEEJOHHKIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE62C0", Offset = "0x7FE52C0", VA = "0x187FE62C0")]
	public static bool FPLNAMMJAIF(this IJELGOILOGJ CEEJOHHKIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE62A0", Offset = "0x7FE52A0", VA = "0x187FE62A0")]
	public static bool ANCMBGNLEGP(this IJELGOILOGJ CEEJOHHKIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE62D0", Offset = "0x7FE52D0", VA = "0x187FE62D0")]
	public static bool HBODNAGNFKD(this IJELGOILOGJ CEEJOHHKIKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LPHEHKKFIEE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool FKPEPMLAPGD;
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
public static class KGPDHNGLLEH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE61D0", Offset = "0x7FE51D0", VA = "0x187FE61D0")]
	public static bool NIDBCIDFFEG(this HelmetHairMode GNGDJOEJFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6150", Offset = "0x7FE5150", VA = "0x187FE6150")]
	public static NOKGHIEMFJK MAINKHDGPPI(this AvatarItemBodyType KAAFKPPFGAL)
	{
		return default(NOKGHIEMFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FE60D0", Offset = "0x7FE50D0", VA = "0x187FE60D0")]
	public static AvatarItemBodyType JDOJAPHJOEH(this NOKGHIEMFJK KAAFKPPFGAL)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FE61E0", Offset = "0x7FE51E0", VA = "0x187FE61E0")]
	public static string OPNAHMHPNIB(this AvatarItemBodyType KAAFKPPFGAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DANNPLEKHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FE41D0", Offset = "0x7FE31D0", VA = "0x187FE41D0")]
	public static void FLNBIODKMHO(Transform NKDDOFKFOKG, Transform CNLKKMAIFJN, Transform BPMCKNFCHBM, Transform MKGCHMOMIOG, float FLHNOGANANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GJIEMCFIFPN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum FOBMCAHJKCF
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
	public enum OHDBKEAJCKP : long
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
	public static readonly IReadOnlyList<FOBMCAHJKCF> HMOHBNNDOJL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<FOBMCAHJKCF> OGNOPFLDMGA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<FOBMCAHJKCF> NAFKHPICICE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IReadOnlyList<FOBMCAHJKCF> EABDHPMGLPD;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly OHDBKEAJCKP DCOHIFHDOJM;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly OHDBKEAJCKP FEMCEKLACAI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly OHDBKEAJCKP OHBOOOGPHLP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5A50", Offset = "0x7FE4A50", VA = "0x187FE5A50")]
	public static OHDBKEAJCKP CCMKKELFIIK(OHDBKEAJCKP OJPGDMBPFPN, OHDBKEAJCKP OIJBBDMAJCB)
	{
		return default(OHDBKEAJCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5A60", Offset = "0x7FE4A60", VA = "0x187FE5A60")]
	public static OHDBKEAJCKP JENNPDJBHPI(OHDBKEAJCKP BHNAEDJALCL, OHDBKEAJCKP CENHAKNBOGH)
	{
		return default(OHDBKEAJCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5A70", Offset = "0x7FE4A70", VA = "0x187FE5A70")]
	public static OHDBKEAJCKP KKOOJPGMHKN(FOBMCAHJKCF CLJEHMOJEEH, OHDBKEAJCKP KGBCFMELIJL)
	{
		return default(OHDBKEAJCKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5A80", Offset = "0x7FE4A80", VA = "0x187FE5A80")]
	public static OHDBKEAJCKP LOBJAGGBPCK(FOBMCAHJKCF CLJEHMOJEEH, OHDBKEAJCKP KGBCFMELIJL)
	{
		return default(OHDBKEAJCKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FKJKGLGGLAF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum KCPACIJMGPB : short
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
			[Cpp2IlInjected.Address(RVA = "0x7FE5A40", Offset = "0x7FE4A40", VA = "0x187FE5A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4FF0", Offset = "0x7FE3FF0", VA = "0x187FE4FF0")]
		public void FOAIJIBABEA(FitMeshHemisphere CJFBKGCECHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5370", Offset = "0x7FE4370", VA = "0x187FE5370")]
		public Vector3 KHDOELEEJFI(Vector2 EHKBJKMBDHB, bool HPIKNLHIMCP = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F90", Offset = "0x7FE3F90", VA = "0x187FE4F90")]
		public Vector3 DOOKBCGNHOE(Vector2 EHKBJKMBDHB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5040", Offset = "0x7FE4040", VA = "0x187FE5040")]
		public Quaternion HEONLFLDIEI(Vector2 EHKBJKMBDHB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5200", Offset = "0x7FE4200", VA = "0x187FE5200")]
		public Quaternion HEONLFLDIEI(Vector2 EHKBJKMBDHB, Vector3 ALEJFDDKFFE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4F40", Offset = "0x7FE3F40", VA = "0x187FE4F40")]
		public Vector2 BAKPPAGDCAK(Vector2 LOIJPHFHCCL)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5990", Offset = "0x7FE4990", VA = "0x187FE5990")]
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
		Roomie_Eye = 502
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DDCCMCEJCEH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B20", Offset = "0x7FE3B20", VA = "0x187FE4B20")]
	public static bool BDFIGNDKGGK(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4BD0", Offset = "0x7FE3BD0", VA = "0x187FE4BD0")]
	public static bool MDJEIAHFEHJ(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4BB0", Offset = "0x7FE3BB0", VA = "0x187FE4BB0")]
	public static bool JEEOKFGJOJG(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B70", Offset = "0x7FE3B70", VA = "0x187FE4B70")]
	public static bool EJDOBFJAGBG(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B40", Offset = "0x7FE3B40", VA = "0x187FE4B40")]
	public static bool DIJKHHIADGF(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B50", Offset = "0x7FE3B50", VA = "0x187FE4B50")]
	public static bool EBCKJEPNFNE(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4C10", Offset = "0x7FE3C10", VA = "0x187FE4C10")]
	public static bool PECBFPMNAND(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4BC0", Offset = "0x7FE3BC0", VA = "0x187FE4BC0")]
	public static bool KJLCMOFKGFD(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B80", Offset = "0x7FE3B80", VA = "0x187FE4B80")]
	public static bool ILKFNEMBKHJ(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4BA0", Offset = "0x7FE3BA0", VA = "0x187FE4BA0")]
	public static bool JBMLGJGKIMG(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4BF0", Offset = "0x7FE3BF0", VA = "0x187FE4BF0")]
	public static bool MHHKOAEDNIF(this OutfitType HNEBPDAGPDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PMBHNGGJBEP : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly PMBHNGGJBEP KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE62F0", Offset = "0x7FE52F0", VA = "0x187FE62F0", Slot = "4")]
	public bool Equals(OutfitType MNOKMNEGPOL, OutfitType EEGKHIPJBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6350", Offset = "0x7FE5350", VA = "0x187FE6350", Slot = "5")]
	public int GetHashCode(OutfitType BJLNCBFOGNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PMBHNGGJBEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NJIJBJFOPON
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum AFINAFOMFNA
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum JJMECFFEICE
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OCCOLDBFJCE
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ANMDKMAFHBE
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DJJBHOIMIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1F20", Offset = "0x7FE0F20", VA = "0x187FE1F20", Slot = "7")]
		public override bool Equals(AdditionalFeetData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1F50", Offset = "0x7FE0F50", VA = "0x187FE1F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1FD0", Offset = "0x7FE0FD0", VA = "0x187FE1FD0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7FE24A0", Offset = "0x7FE14A0", VA = "0x187FE24A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2010", Offset = "0x7FE1010", VA = "0x187FE2010", Slot = "7")]
		public override bool Equals(AdditionalHatData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2200", Offset = "0x7FE1200", VA = "0x187FE2200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2360", Offset = "0x7FE1360", VA = "0x187FE2360")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2520", Offset = "0x7FE1520", VA = "0x187FE2520")]
		public static bool ACJCCGNHMKI(OutfitType BJLNCBFOGNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE25F0", Offset = "0x7FE15F0", VA = "0x187FE25F0")]
		public static AdditionalOutfitTypeData MEFBGKEPBLF(OutfitType BJLNCBFOGNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2560", Offset = "0x7FE1560", VA = "0x187FE2560", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData EDJHHGMLKFA);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5523130", Offset = "0x5522130", VA = "0x185523130", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T EDJHHGMLKFA);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DMMODDKGDOL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4C20", Offset = "0x7FE3C20", VA = "0x187FE4C20")]
	public static bool JDEHJKHIPNM(this AdditionalOutfitTypeData LICAMCEEHPB)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, NBIGFDABFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1290C40", Offset = "0x128FC40", VA = "0x181290C40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4100", Offset = "0x7FE3100", VA = "0x187FE4100", Slot = "7")]
		public override bool Equals(BeardData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4120", Offset = "0x7FE3120", VA = "0x187FE4120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4190", Offset = "0x7FE3190", VA = "0x187FE4190")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HairData : AdditionalOutfitTypeData<HairData>, NBIGFDABFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD243D0", Offset = "0xD233D0", VA = "0x180D243D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA7E580", Offset = "0xA7D580", VA = "0x180A7E580", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE60240", Offset = "0xE5F240", VA = "0x180E60240")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE6040", Offset = "0x7FE5040", VA = "0x187FE6040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5C90", Offset = "0x7FE4C90", VA = "0x187FE5C90", Slot = "7")]
		public override bool Equals(HairData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5E80", Offset = "0x7FE4E80", VA = "0x187FE5E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5F80", Offset = "0x7FE4F80", VA = "0x187FE5F80")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AHNFNOAOBPL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool JIDGFGMOIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KFFCIFICKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AnchorParamsRestrictions CODPMCBFAOC();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NBIGFDABFHD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool JHHBKDBHKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HairPatternStyle MJODLPFPCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DIHNCAEIJAD
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	const string AOMKHBEAJDB = "FFFFFF";

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JJGFGLDFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string MKEFEMEFMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RoomieEyeData : AdditionalOutfitTypeData<RoomieEyeData>, DIHNCAEIJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6400", Offset = "0x7FE5400", VA = "0x187FE6400", Slot = "7")]
		public override bool Equals(RoomieEyeData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6430", Offset = "0x7FE5430", VA = "0x187FE6430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FE64A0", Offset = "0x7FE54A0", VA = "0x187FE64A0")]
		public RoomieEyeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RoomieHatData : AdditionalOutfitTypeData<RoomieHatData>, DIHNCAEIJAD, AHNFNOAOBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsTranslatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE66D0", Offset = "0x7FE56D0", VA = "0x187FE66D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE66B0", Offset = "0x7FE56B0", VA = "0x187FE66B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6510", Offset = "0x7FE5510", VA = "0x187FE6510", Slot = "7")]
		public override bool Equals(RoomieHatData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6580", Offset = "0x7FE5580", VA = "0x187FE6580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "12")]
		public AnchorParamsRestrictions CODPMCBFAOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6600", Offset = "0x7FE5600", VA = "0x187FE6600")]
		public RoomieHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RoomieWaistData : AdditionalOutfitTypeData<RoomieWaistData>, DIHNCAEIJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6400", Offset = "0x7FE5400", VA = "0x187FE6400", Slot = "7")]
		public override bool Equals(RoomieWaistData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7FE66F0", Offset = "0x7FE56F0", VA = "0x187FE66F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6760", Offset = "0x7FE5760", VA = "0x187FE6760")]
		public RoomieWaistData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ENEIOHMFLFP
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4DA0", Offset = "0x7FE3DA0", VA = "0x187FE4DA0")]
	public static IJELGOILOGJ KKBFJDINLPD(this OutfitType HNEBPDAGPDP, AvatarItemSidednessEquipType OBBJFPODAIE = AvatarItemSidednessEquipType.Left)
	{
		return default(IJELGOILOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4CD0", Offset = "0x7FE3CD0", VA = "0x187FE4CD0")]
	public static OOMOBMPOMPL IKLNHIIJDBJ(this OutfitType HNEBPDAGPDP, AvatarItemSidednessEquipType OBBJFPODAIE = AvatarItemSidednessEquipType.Left)
	{
		return default(OOMOBMPOMPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4E50", Offset = "0x7FE3E50", VA = "0x187FE4E50")]
	public static IJELGOILOGJ LOLGHLGAGKM(this IJELGOILOGJ MOINPJHGPMM)
	{
		return default(IJELGOILOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4CF0", Offset = "0x7FE3CF0", VA = "0x187FE4CF0")]
	public static bool JDKMAPJLGDF(this OutfitType HNEBPDAGPDP, IJELGOILOGJ MOINPJHGPMM)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FDCGCPCOFJP
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F10", Offset = "0x7FE3F10", VA = "0x187FE4F10")]
	public static bool NOCMIBHICLI(this AvatarItemSidednessEquipType OBBJFPODAIE, IJELGOILOGJ MOINPJHGPMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4EC0", Offset = "0x7FE3EC0", VA = "0x187FE4EC0")]
	public static bool EENEHKLMOOA(this AvatarItemSidednessEquipType AGIIMDNIIOG, IJELGOILOGJ MOINPJHGPMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4EA0", Offset = "0x7FE3EA0", VA = "0x187FE4EA0")]
	public static bool CAPDFMHDHMN(this AvatarItemSidednessEquipType ENCOBHMNKMD, AvatarItemSidednessEquipType ANAMNOKLDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4EF0", Offset = "0x7FE3EF0", VA = "0x187FE4EF0")]
	public static AvatarItemSidednessEquipType GLAPGJFOKKF(this AvatarItemSidednessEquipType ENCOBHMNKMD)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum EPAEDOABNLL
{
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Wrist = 10,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Roomie_Head = 20,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Roomie_Waist = 21,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Roomie_Eye = 22
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Roomie_Head = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Roomie_Waist = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Roomie_Eye = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BDEOOJCILJG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3CE0", Offset = "0x7FE2CE0", VA = "0x187FE3CE0")]
	private static EPAEDOABNLL DCPDLHHJLFK(this OutfitType HNEBPDAGPDP)
	{
		return default(EPAEDOABNLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3B20", Offset = "0x7FE2B20", VA = "0x187FE3B20")]
	public static OutfitSlotFlags APJICOGBLCC(this OutfitType HNEBPDAGPDP)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FE40F0", Offset = "0x7FE30F0", VA = "0x187FE40F0")]
	public static bool PBGDKMLAFLF(this OutfitSlotFlags IIFJMEEIBEJ, OutfitSlotFlags DNDFDFONCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3EA0", Offset = "0x7FE2EA0", VA = "0x187FE3EA0")]
	public static bool KIPMKLFNHID(this OutfitType HNEBPDAGPDP, OutfitSlotFlags MJIGFFKOCJC)
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
