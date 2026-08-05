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
public interface AOEHHBOAGNP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float EACCMAFNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NODKJNNBHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NGLKDJHMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float CMAGCBBNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float DODOMPAKJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float CBLIGOFMBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float IIHIFHLAMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LHFOHCJKMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BAENHOLJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PBIEOPDGKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float AKABMPPOGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float BDDPFKMHNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LIHIPGJECDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float BCCKCGIGLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float KMDPFANADPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HKECIGGLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 KBOFGNCDDLA(Vector3 KKKFMBELFLI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 JDJGLONDJPF(Vector3 MFIEDPEOILC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 IGADBJEEEEF();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : AOEHHBOAGNP
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
			[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB44370", Offset = "0xB42F70", VA = "0x180B44370", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD69C10", Offset = "0xD68810", VA = "0x180D69C10", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBE6C40", Offset = "0xBE5840", VA = "0x180BE6C40", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE95D20", Offset = "0xE94920", VA = "0x180E95D20", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD6E740", Offset = "0xD6D340", VA = "0x180D6E740", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5E10", Offset = "0xAA4A10", VA = "0x180AA5E10", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x988900", Offset = "0x987500", VA = "0x180988900", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7344EA0", Offset = "0x7343AA0", VA = "0x187344EA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7345410", Offset = "0x7344010", VA = "0x187345410")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x73453F0", Offset = "0x7343FF0", VA = "0x1873453F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xE95CC0", Offset = "0xE948C0", VA = "0x180E95CC0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA9DDE0", Offset = "0xA9C9E0", VA = "0x180A9DDE0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA9DE00", Offset = "0xA9CA00", VA = "0x180A9DE00", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD49A60", Offset = "0xD48660", VA = "0x180D49A60", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xEDD030", Offset = "0xEDBC30", VA = "0x180EDD030", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7344570", Offset = "0x7343170", VA = "0x187344570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7345430", Offset = "0x7344030", VA = "0x187345430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x73453D0", Offset = "0x7343FD0", VA = "0x1873453D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEDD070", Offset = "0xEDBC70", VA = "0x180EDD070", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB442E0", Offset = "0xB42EE0", VA = "0x180B442E0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB42ED0", Offset = "0xB41AD0", VA = "0x180B42ED0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x973970", Offset = "0x972570", VA = "0x180973970", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7345450", Offset = "0x7344050", VA = "0x187345450")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7345490", Offset = "0x7344090", VA = "0x187345490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7345470", Offset = "0x7344070", VA = "0x187345470")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x73454B0", Offset = "0x73440B0", VA = "0x1873454B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7345340", Offset = "0x7343F40", VA = "0x187345340")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7344F40", Offset = "0x7343B40", VA = "0x187344F40")]
		public IFMFMHOGADG JEBCBLOMGNE(IFMFMHOGADG JPBEOPPGPCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7344570", Offset = "0x7343170", VA = "0x187344570", Slot = "25")]
		public Vector3 ECJAOPJCNIF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7344EA0", Offset = "0x7343AA0", VA = "0x187344EA0", Slot = "22")]
		public Vector3 IGADBJEEEEF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7345220", Offset = "0x7343E20", VA = "0x187345220", Slot = "20")]
		public Vector3 KBOFGNCDDLA(Vector3 KKKFMBELFLI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7344EC0", Offset = "0x7343AC0", VA = "0x187344EC0", Slot = "21")]
		public Vector3 JDJGLONDJPF(Vector3 MFIEDPEOILC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7344590", Offset = "0x7343190", VA = "0x187344590", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73449A0", Offset = "0x73435A0", VA = "0x1873449A0")]
		protected bool HJJPGDONMOM(AnchorParamsRestrictions PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73446A0", Offset = "0x73432A0", VA = "0x1873446A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7344500", Offset = "0x7343100", VA = "0x187344500")]
		[CompilerGenerated]
		internal static bool CIOJIHGAFMF(float CEDOOEEEDCO, float LJEHMGANCNG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FKINAMIEPAK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1421220", Offset = "0x141FE20", VA = "0x181421220")]
	public static bool EBNEGEMCPJI(this MNMFJNIJMID MABMNACPLLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7345CC0", Offset = "0x73448C0", VA = "0x187345CC0")]
	public static bool PBOCHIKEKJN(this MNMFJNIJMID MABMNACPLLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GEBPELFBIFN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool LDKDOFMOBCN;
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
public static class FNCJMHLNJDN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7345E90", Offset = "0x7344A90", VA = "0x187345E90")]
	public static bool HEBMDOJEJEE(this HelmetHairMode AIFCMPIEIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7345D90", Offset = "0x7344990", VA = "0x187345D90")]
	public static CDKJOLAGBOC BOBBAGBBIOO(this AvatarItemBodyType KKOJCMMPONK)
	{
		return default(CDKJOLAGBOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7345E10", Offset = "0x7344A10", VA = "0x187345E10")]
	public static AvatarItemBodyType DMDCHMBOOFG(this CDKJOLAGBOC KKOJCMMPONK)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7345CD0", Offset = "0x73448D0", VA = "0x187345CD0")]
	public static string BMLCOHLACAA(this AvatarItemBodyType KKOJCMMPONK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GIPBGJMJGIK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7346970", Offset = "0x7345570", VA = "0x187346970")]
	public static void MFGLFNKKNDH(Transform LLNFKGOGHFA, Transform NBINEPLLPPC, Transform MFMACPLJGPH, Transform DOBMHOPBLJO, float JAHMNEHGGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AMLHELBFOLA
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum FMLLBDOAAED
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
	public enum MCCCALMIAAN
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
	public static readonly MCCCALMIAAN MMMANICKLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly MCCCALMIAAN PALKKNHFCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly MCCCALMIAAN KLHJILGAFEM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x73438C0", Offset = "0x73424C0", VA = "0x1873438C0")]
	public static MCCCALMIAAN KHHIHFGOJGD(MCCCALMIAAN BKEAEOCHHKC, MCCCALMIAAN OAKLONHBDKL)
	{
		return default(MCCCALMIAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73438D0", Offset = "0x73424D0", VA = "0x1873438D0")]
	public static MCCCALMIAAN KPNHJACPBCJ(MCCCALMIAAN BLIKNDMHOOI, MCCCALMIAAN IJGIGEGKHOC)
	{
		return default(MCCCALMIAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73438B0", Offset = "0x73424B0", VA = "0x1873438B0")]
	public static MCCCALMIAAN AODEGILIAED(FMLLBDOAAED HJMJAHOMCOK, MCCCALMIAAN EAMBJNCJPEJ)
	{
		return default(MCCCALMIAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x73439C0", Offset = "0x73425C0", VA = "0x1873439C0")]
	public static MCCCALMIAAN MLIKEMDIOIB(FMLLBDOAAED HJMJAHOMCOK, MCCCALMIAAN EAMBJNCJPEJ)
	{
		return default(MCCCALMIAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x73438E0", Offset = "0x73424E0", VA = "0x1873438E0")]
	public static bool LELIOKCOGBB(this MCCCALMIAAN AGLHPHGJKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7343950", Offset = "0x7342550", VA = "0x187343950")]
	public static bool MDKNPJJDMJG(this MCCCALMIAAN AGLHPHGJKJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ADCIIIFLNIO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NCBKJGFCDIO : short
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
			[Cpp2IlInjected.Address(RVA = "0x7346960", Offset = "0x7345560", VA = "0x187346960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7345F50", Offset = "0x7344B50", VA = "0x187345F50")]
		public void NELDMPOBHHE(FitMeshHemisphere BLGPKGJHKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73462C0", Offset = "0x7344EC0", VA = "0x1873462C0")]
		public Vector3 OJLJKIJKOMH(Vector2 IMJMGGODEDF, bool HFDLMBBFDCP = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7345EF0", Offset = "0x7344AF0", VA = "0x187345EF0")]
		public Vector3 FPMKALJABNC(Vector2 IMJMGGODEDF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7345FA0", Offset = "0x7344BA0", VA = "0x187345FA0")]
		public Quaternion NLJJBLMAJPK(Vector2 IMJMGGODEDF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7346150", Offset = "0x7344D50", VA = "0x187346150")]
		public Quaternion NLJJBLMAJPK(Vector2 IMJMGGODEDF, Vector3 AMCPEGMKHAJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7345EA0", Offset = "0x7344AA0", VA = "0x187345EA0")]
		public Vector2 FNPMOJJPGLF(Vector2 PIBBOBAECIO)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x73468C0", Offset = "0x73454C0", VA = "0x1873468C0")]
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
public static class DEOPJGPLKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7345780", Offset = "0x7344380", VA = "0x187345780")]
	public static bool HLKMGKHLGEO(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73457B0", Offset = "0x73443B0", VA = "0x1873457B0")]
	public static bool OEEDGLGNMPG(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7345730", Offset = "0x7344330", VA = "0x187345730")]
	public static bool BAJJOHGFEAL(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7345760", Offset = "0x7344360", VA = "0x187345760")]
	public static bool DLJIFHEPPCD(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x73457A0", Offset = "0x73443A0", VA = "0x1873457A0")]
	public static bool IDLCIIHEKJE(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7345740", Offset = "0x7344340", VA = "0x187345740")]
	public static bool BMJKHBFCDOF(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7345720", Offset = "0x7344320", VA = "0x187345720")]
	public static bool ADMHJOIBAIG(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73457D0", Offset = "0x73443D0", VA = "0x1873457D0")]
	public static bool PCILNGONAGB(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7345700", Offset = "0x7344300", VA = "0x187345700")]
	public static bool ADLGPOADKJK(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7345770", Offset = "0x7344370", VA = "0x187345770")]
	public static bool GGJIEGAIDDM(this OutfitType NMFCBJMEKFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KNEGGGCIFLL : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly KNEGGGCIFLL FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73477A0", Offset = "0x73463A0", VA = "0x1873477A0", Slot = "4")]
	public bool Equals(OutfitType GJGIPHFNNHJ, OutfitType IMLJDJEJMPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7347800", Offset = "0x7346400", VA = "0x187347800", Slot = "5")]
	public int GetHashCode(OutfitType ADFFEBFOCBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KNEGGGCIFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum ABKOOFOCNGG
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
public enum OGIEPPBFMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum CEFKCOLGIKD
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
public enum PHCAMDLLKGD
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
public enum ABNAKGGCIGD
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
public enum FHEDEKPEKPL
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
		[Cpp2IlInjected.Address(RVA = "0x7343A30", Offset = "0x7342630", VA = "0x187343A30", Slot = "7")]
		public override bool Equals(AdditionalFeetData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7343A60", Offset = "0x7342660", VA = "0x187343A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7343AE0", Offset = "0x73426E0", VA = "0x187343AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7344010", Offset = "0x7342C10", VA = "0x187344010")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7343B20", Offset = "0x7342720", VA = "0x187343B20", Slot = "7")]
		public override bool Equals(AdditionalHatData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7343D10", Offset = "0x7342910", VA = "0x187343D10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7343E70", Offset = "0x7342A70", VA = "0x187343E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7344090", Offset = "0x7342C90", VA = "0x187344090")]
		public static bool BNNFPOKFADM(OutfitType ADFFEBFOCBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73440C0", Offset = "0x7342CC0", VA = "0x1873440C0")]
		public static AdditionalOutfitTypeData EPPBBCFCJMI(OutfitType ADFFEBFOCBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7344470", Offset = "0x7343070", VA = "0x187344470", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData PELBNOCGOOJ);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4A29BB0", Offset = "0x4A287B0", VA = "0x184A29BB0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T PELBNOCGOOJ);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, NFHBIKOFNPE
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
			[Cpp2IlInjected.Address(RVA = "0xF575D0", Offset = "0xF561D0", VA = "0x180F575D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7345630", Offset = "0x7344230", VA = "0x187345630", Slot = "7")]
		public override bool Equals(BeardData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7345650", Offset = "0x7344250", VA = "0x187345650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73456C0", Offset = "0x73442C0", VA = "0x1873456C0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, NFHBIKOFNPE
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
			[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9766E0", Offset = "0x9752E0", VA = "0x1809766E0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA862F0", Offset = "0xA84EF0", VA = "0x180A862F0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7347670", Offset = "0x7346270", VA = "0x187347670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73472C0", Offset = "0x7345EC0", VA = "0x1873472C0", Slot = "7")]
		public override bool Equals(HairData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x73474B0", Offset = "0x73460B0", VA = "0x1873474B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73475B0", Offset = "0x73461B0", VA = "0x1873475B0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NFHBIKOFNPE
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool NFBHCFLGNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle FFCLBAFMLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class BEIMBBCMEJN
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7345530", Offset = "0x7344130", VA = "0x187345530")]
	public static MNMFJNIJMID LHLCAMLHEBG(this OutfitType NMFCBJMEKFG, AvatarItemSidednessEquipType ELHCJMDKJOK = AvatarItemSidednessEquipType.Left)
	{
		return default(MNMFJNIJMID);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73454D0", Offset = "0x73440D0", VA = "0x1873454D0")]
	public static MNMFJNIJMID FFDJJJONDHJ(this MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(MNMFJNIJMID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73455B0", Offset = "0x73441B0", VA = "0x1873455B0")]
	public static bool PJHJCIJDNNA(this OutfitType NMFCBJMEKFG, MNMFJNIJMID PPCPNOAGMNJ)
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
public static class ICEHJKNCDED
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7347740", Offset = "0x7346340", VA = "0x187347740")]
	public static bool GEFDHIMILEF(this AvatarItemSidednessEquipType ELHCJMDKJOK, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7347770", Offset = "0x7346370", VA = "0x187347770")]
	public static bool ILOJANKKFBC(this AvatarItemSidednessEquipType BGNFNNCOKMK, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7347720", Offset = "0x7346320", VA = "0x187347720")]
	public static bool FLMEAJGJOJG(this AvatarItemSidednessEquipType CCAHKGIKLIH, AvatarItemSidednessEquipType DIBHGIBMEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7347700", Offset = "0x7346300", VA = "0x187347700")]
	public static AvatarItemSidednessEquipType CDMJPBMEGKG(this AvatarItemSidednessEquipType CCAHKGIKLIH)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum JCGGJGHPAHD
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
public static class FHFOHDEBLFI
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7345B50", Offset = "0x7344750", VA = "0x187345B50")]
	private static JCGGJGHPAHD MPBHELMOHNJ(this OutfitType NMFCBJMEKFG)
	{
		return default(JCGGJGHPAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73459D0", Offset = "0x73445D0", VA = "0x1873459D0")]
	public static OutfitSlotFlags DFKNGEIJFLJ(this OutfitType NMFCBJMEKFG)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7345B40", Offset = "0x7344740", VA = "0x187345B40")]
	public static bool FAACKEBHDEJ(this OutfitSlotFlags CDDGLCLGGDL, OutfitSlotFlags POCNIHCPJPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x73457E0", Offset = "0x73443E0", VA = "0x1873457E0")]
	public static bool BNDIBFLGHMN(this OutfitType NMFCBJMEKFG, OutfitSlotFlags IBGKGKLDCAL)
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
