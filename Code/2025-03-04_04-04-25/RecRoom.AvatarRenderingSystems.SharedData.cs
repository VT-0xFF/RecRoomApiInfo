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
public interface BOEIPLPALDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float CEGGFGAPGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float FKAHBBPPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float GHDALFDKKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float JAJBGIKDIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float OCHPPHOGIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float OKJFGEILAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PBJGIPABLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float HLBKJLDAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KBHBGFBOBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float GIGBIBNABJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float CBCHCILAPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JOHBDPCMDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float PGBGALPODPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float GAFMMFMAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float CFAACOADCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float AFBBOHDGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 GDPIMHPLJJO(Vector3 AAOMFNIJCFO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 JKDIIEBEHPD(Vector3 IINEMILNAJL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 IDPCFMPBPCL();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : BOEIPLPALDB
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
			[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB45090", Offset = "0xB43690", VA = "0x180B45090", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD791D0", Offset = "0xD777D0", VA = "0x180D791D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBDFEB0", VA = "0x180BE18B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEA5F40", Offset = "0xEA4540", VA = "0x180EA5F40", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD7A6F0", Offset = "0xD78CF0", VA = "0x180D7A6F0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAA06F0", Offset = "0xA9ECF0", VA = "0x180AA06F0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x981A60", Offset = "0x980060", VA = "0x180981A60", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7391340", Offset = "0x738F940", VA = "0x187391340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7391A70", Offset = "0x7390070", VA = "0x187391A70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7391A50", Offset = "0x7390050", VA = "0x187391A50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DB0", Offset = "0xEE13B0", VA = "0x180EE2DB0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xEA5EE0", Offset = "0xEA44E0", VA = "0x180EA5EE0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA9A810", Offset = "0xA98E10", VA = "0x180A9A810", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA9A800", Offset = "0xA98E00", VA = "0x180A9A800", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD4E4D0", Offset = "0xD4CAD0", VA = "0x180D4E4D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xEEC0E0", Offset = "0xEEA6E0", VA = "0x180EEC0E0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7390BB0", Offset = "0x738F1B0", VA = "0x187390BB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7391A90", Offset = "0x7390090", VA = "0x187391A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7391A30", Offset = "0x7390030", VA = "0x187391A30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEEC120", Offset = "0xEEA720", VA = "0x180EEC120", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB450A0", Offset = "0xB436A0", VA = "0x180B450A0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB45930", Offset = "0xB43F30", VA = "0x180B45930", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x96C900", Offset = "0x96AF00", VA = "0x18096C900", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7391AB0", Offset = "0x73900B0", VA = "0x187391AB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7391AF0", Offset = "0x73900F0", VA = "0x187391AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7391AD0", Offset = "0x73900D0", VA = "0x187391AD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7391B10", Offset = "0x7390110", VA = "0x187391B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x73919A0", Offset = "0x738FFA0", VA = "0x1873919A0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7390BD0", Offset = "0x738F1D0", VA = "0x187390BD0")]
		public KOIFPCMFICK DHHCBNBCKKG(KOIFPCMFICK GMNKPJJBKFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7390BB0", Offset = "0x738F1B0", VA = "0x187390BB0", Slot = "25")]
		public Vector3 CIBLFBJJDPE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7391340", Offset = "0x738F940", VA = "0x187391340", Slot = "22")]
		public Vector3 IDPCFMPBPCL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7390FD0", Offset = "0x738F5D0", VA = "0x187390FD0", Slot = "20")]
		public Vector3 GDPIMHPLJJO(Vector3 AAOMFNIJCFO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7391360", Offset = "0x738F960", VA = "0x187391360", Slot = "21")]
		public Vector3 JKDIIEBEHPD(Vector3 IINEMILNAJL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7390EC0", Offset = "0x738F4C0", VA = "0x187390EC0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73913E0", Offset = "0x738F9E0", VA = "0x1873913E0")]
		protected bool ONNLACEOLHH(AnchorParamsRestrictions OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7391040", Offset = "0x738F640", VA = "0x187391040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7390B40", Offset = "0x738F140", VA = "0x187390B40")]
		[CompilerGenerated]
		internal static bool CCHMMCJOAFN(float AMGCKABOOPF, float PPCFCAEIJMM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CKMFAPEIAED
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x13C4AE0", Offset = "0x13C30E0", VA = "0x1813C4AE0")]
	public static bool EKHHBLEJGPM(this OBJHNMCDGDL OGNNAFLGGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7392550", Offset = "0x7390B50", VA = "0x187392550")]
	public static bool MDNLAJCDCIL(this OBJHNMCDGDL OGNNAFLGGHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBGIJDBKODA
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool AKJIFFAOHHA;
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
public static class LBHKALJLNHI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7394020", Offset = "0x7392620", VA = "0x187394020")]
	public static bool POKOLGIGHGF(this HelmetHairMode FIFICFINBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7393FA0", Offset = "0x73925A0", VA = "0x187393FA0")]
	public static PKOOKMMPLDP EBPCOGGBFPH(this AvatarItemBodyType KJBFEELDPAB)
	{
		return default(PKOOKMMPLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7393E60", Offset = "0x7392460", VA = "0x187393E60")]
	public static AvatarItemBodyType ACLGBFNDEDL(this PKOOKMMPLDP KJBFEELDPAB)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7393EE0", Offset = "0x73924E0", VA = "0x187393EE0")]
	public static string AOLKFACEHDD(this AvatarItemBodyType KJBFEELDPAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CIMAKCMDKMO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7391C00", Offset = "0x7390200", VA = "0x187391C00")]
	public static void NGIKCOODJCM(Transform HFKIOHKELDH, Transform IJMIMAFFPIN, Transform BMCEENKIOJD, Transform NHBJHJGOMNJ, float HHHBMNEBGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KBAIGJMAONF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum EHMCMLMEFNE
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
	public enum FALICHFPADL : long
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
	public static readonly IReadOnlyList<EHMCMLMEFNE> DIPNMCJNDOI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<EHMCMLMEFNE> HKNJPPLKAGG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<EHMCMLMEFNE> HJIKCAAADHL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly FALICHFPADL LONHBNJLLPI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly FALICHFPADL FGKBNLGGJCJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly FALICHFPADL GFBGEOIPFJP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7393CA0", Offset = "0x73922A0", VA = "0x187393CA0")]
	public static FALICHFPADL EOJLNNCMGOP(FALICHFPADL PKLJLJKKCCA, FALICHFPADL DBJAKICEMMJ)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7393CC0", Offset = "0x73922C0", VA = "0x187393CC0")]
	public static FALICHFPADL MODBLGCMGJK(FALICHFPADL OCFOJMDAFKN, FALICHFPADL PEJJIOFJKHM)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7393CB0", Offset = "0x73922B0", VA = "0x187393CB0")]
	public static FALICHFPADL JADPLFDHFJO(EHMCMLMEFNE HGJDCAJDLKD, FALICHFPADL MJIFKAKMLDL)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7393C80", Offset = "0x7392280", VA = "0x187393C80")]
	public static FALICHFPADL BLKHKAKHOEE(EHMCMLMEFNE HGJDCAJDLKD, FALICHFPADL MJIFKAKMLDL)
	{
		return default(FALICHFPADL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BCOAPANBCBE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum AHFGMPCCCPM : short
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
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x73936F0", Offset = "0x7391CF0", VA = "0x1873936F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7392C50", Offset = "0x7391250", VA = "0x187392C50")]
		public void EGIEGHBPICJ(FitMeshHemisphere FKKKLIHMNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7393020", Offset = "0x7391620", VA = "0x187393020")]
		public Vector3 PCOALJLOGGP(Vector2 NHEABMEEBBE, bool BPLKNEFMCEN = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7392BF0", Offset = "0x73911F0", VA = "0x187392BF0")]
		public Vector3 BDHNEIMDICJ(Vector2 NHEABMEEBBE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7392CF0", Offset = "0x73912F0", VA = "0x187392CF0")]
		public Quaternion OPBKLKHJPAL(Vector2 NHEABMEEBBE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7392EB0", Offset = "0x73914B0", VA = "0x187392EB0")]
		public Quaternion OPBKLKHJPAL(Vector2 NHEABMEEBBE, Vector3 KNEJAKEJFIM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7392CA0", Offset = "0x73912A0", VA = "0x187392CA0")]
		public Vector2 LMGDJKLBOPI(Vector2 ALODLBEKEAO)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7393640", Offset = "0x7391C40", VA = "0x187393640")]
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
public static class LJAHEFGLMCM
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73940F0", Offset = "0x73926F0", VA = "0x1873940F0")]
	public static bool PHLGMHNCDIB(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x73940C0", Offset = "0x73926C0", VA = "0x1873940C0")]
	public static bool MKAGJNMKFFI(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7394080", Offset = "0x7392680", VA = "0x187394080")]
	public static bool KAIMIILPKLN(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7394040", Offset = "0x7392640", VA = "0x187394040")]
	public static bool DHFAKACCGDI(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x73940E0", Offset = "0x73926E0", VA = "0x1873940E0")]
	public static bool OGHBHJCMCOC(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x73940A0", Offset = "0x73926A0", VA = "0x1873940A0")]
	public static bool MJMEACGHPCP(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7394030", Offset = "0x7392630", VA = "0x187394030")]
	public static bool BLMMFOECHJM(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7394050", Offset = "0x7392650", VA = "0x187394050")]
	public static bool FBCFJFAEJDB(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7394060", Offset = "0x7392660", VA = "0x187394060")]
	public static bool GNMKAFOMNBL(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7394090", Offset = "0x7392690", VA = "0x187394090")]
	public static bool LEBJFGDDIPA(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EOKAMEMIPNI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly EOKAMEMIPNI IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7392AE0", Offset = "0x73910E0", VA = "0x187392AE0", Slot = "4")]
	public bool Equals(OutfitType GLIPEBBNIOG, OutfitType MIMMBLGABED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7392B40", Offset = "0x7391140", VA = "0x187392B40", Slot = "5")]
	public int GetHashCode(OutfitType BMIPLDLMPCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public EOKAMEMIPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GOEIDDHPLEF
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
public enum LHELENKBGMO
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BJGDFBKEINK
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
public enum DDOKGHHJODE
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
public enum LDBIEKJHPFI
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
public enum EHLDDELHBFB
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

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7390050", Offset = "0x738E650", VA = "0x187390050", Slot = "7")]
		public override bool Equals(AdditionalFeetData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7390080", Offset = "0x738E680", VA = "0x187390080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7390100", Offset = "0x738E700", VA = "0x187390100")]
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
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7390640", Offset = "0x738EC40", VA = "0x187390640")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7390140", Offset = "0x738E740", VA = "0x187390140", Slot = "7")]
		public override bool Equals(AdditionalHatData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7390330", Offset = "0x738E930", VA = "0x187390330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7390490", Offset = "0x738EA90", VA = "0x187390490")]
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

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7390750", Offset = "0x738ED50", VA = "0x187390750")]
		public static bool JOPEBPINLPF(OutfitType BMIPLDLMPCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7390780", Offset = "0x738ED80", VA = "0x187390780")]
		public static AdditionalOutfitTypeData OILMBKHFGKP(OutfitType BMIPLDLMPCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73906C0", Offset = "0x738ECC0", VA = "0x1873906C0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData OKCHLIEAIJP);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4C0A560", Offset = "0x4C08B60", VA = "0x184C0A560", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T OKCHLIEAIJP);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, OPFGAAPGJPL
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
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xF63F60", Offset = "0xF62560", VA = "0x180F63F60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7391B30", Offset = "0x7390130", VA = "0x187391B30", Slot = "7")]
		public override bool Equals(BeardData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7391B50", Offset = "0x7390150", VA = "0x187391B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7391BC0", Offset = "0x73901C0", VA = "0x187391BC0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, OPFGAAPGJPL
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
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAE930", Offset = "0xAACF30", VA = "0x180AAE930", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x96F670", Offset = "0x96DC70", VA = "0x18096F670", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA708D0", Offset = "0xA6EED0", VA = "0x180A708D0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7393BF0", Offset = "0x73921F0", VA = "0x187393BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7393840", Offset = "0x7391E40", VA = "0x187393840", Slot = "7")]
		public override bool Equals(HairData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7393A30", Offset = "0x7392030", VA = "0x187393A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7393B30", Offset = "0x7392130", VA = "0x187393B30")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OPFGAAPGJPL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool MFOIJFPIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle FBOHFEANLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HHNKGEMHLHE
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73937C0", Offset = "0x7391DC0", VA = "0x1873937C0")]
	public static OBJHNMCDGDL OMEAAHOOBFP(this OutfitType CNBEFNFJEEJ, AvatarItemSidednessEquipType CKEJOHFGAJF = AvatarItemSidednessEquipType.Left)
	{
		return default(OBJHNMCDGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7393700", Offset = "0x7391D00", VA = "0x187393700")]
	public static OBJHNMCDGDL EIOIPOLMJPF(this OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(OBJHNMCDGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7393750", Offset = "0x7391D50", VA = "0x187393750")]
	public static bool LJNAJFLMAKJ(this OutfitType CNBEFNFJEEJ, OBJHNMCDGDL DBDEIKJCEBF)
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
public static class DGHGNKAGCMH
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73925A0", Offset = "0x7390BA0", VA = "0x1873925A0")]
	public static bool OJFOPHHDIBM(this AvatarItemSidednessEquipType CKEJOHFGAJF, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73925D0", Offset = "0x7390BD0", VA = "0x1873925D0")]
	public static bool OMJNGEBIADH(this AvatarItemSidednessEquipType JCLBDPJOOIB, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7392580", Offset = "0x7390B80", VA = "0x187392580")]
	public static bool FDEFIIBKDJG(this AvatarItemSidednessEquipType DGFHDKIKKOG, AvatarItemSidednessEquipType IBIJCGMEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7392560", Offset = "0x7390B60", VA = "0x187392560")]
	public static AvatarItemSidednessEquipType EFJBLPGPLNP(this AvatarItemSidednessEquipType DGFHDKIKKOG)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum LJJGPLOBBOC
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
public static class EMBDNMKKGIK
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7392970", Offset = "0x7390F70", VA = "0x187392970")]
	private static LJJGPLOBBOC LKIAMICOCJO(this OutfitType CNBEFNFJEEJ)
	{
		return default(LJJGPLOBBOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7392800", Offset = "0x7390E00", VA = "0x187392800")]
	public static OutfitSlotFlags FMCCKPGFLHB(this OutfitType CNBEFNFJEEJ)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x73927F0", Offset = "0x7390DF0", VA = "0x1873927F0")]
	public static bool DOIIGNEADLM(this OutfitSlotFlags CNEDLKPNNJD, OutfitSlotFlags BAJOIMKDKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7392600", Offset = "0x7390C00", VA = "0x187392600")]
	public static bool DAECDKLCDHB(this OutfitType CNBEFNFJEEJ, OutfitSlotFlags DFJOOLOEDOD)
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
