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
			[Cpp2IlInjected.Address(RVA = "0xB39EB0", Offset = "0xB392B0", VA = "0x180B39EB0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB39640", Offset = "0xB38A40", VA = "0x180B39640", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD6B510", Offset = "0xD6A910", VA = "0x180D6B510", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBDA170", Offset = "0xBD9570", VA = "0x180BDA170", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE938C0", Offset = "0xE92CC0", VA = "0x180E938C0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD6CA30", Offset = "0xD6BE30", VA = "0x180D6CA30", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA987D0", Offset = "0xA97BD0", VA = "0x180A987D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x97A9B0", Offset = "0x979DB0", VA = "0x18097A9B0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72F78D0", Offset = "0x72F6CD0", VA = "0x1872F78D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72F8000", Offset = "0x72F7400", VA = "0x1872F8000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x72F7FE0", Offset = "0x72F73E0", VA = "0x1872F7FE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xED0730", Offset = "0xECFB30", VA = "0x180ED0730", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xE93860", Offset = "0xE92C60", VA = "0x180E93860", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA928F0", Offset = "0xA91CF0", VA = "0x180A928F0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA928E0", Offset = "0xA91CE0", VA = "0x180A928E0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD40270", Offset = "0xD3F670", VA = "0x180D40270", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xED9A50", Offset = "0xED8E50", VA = "0x180ED9A50", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72F7140", Offset = "0x72F6540", VA = "0x1872F7140")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x72F8020", Offset = "0x72F7420", VA = "0x1872F8020")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72F7FC0", Offset = "0x72F73C0", VA = "0x1872F7FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xED9A90", Offset = "0xED8E90", VA = "0x180ED9A90", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB39650", Offset = "0xB38A50", VA = "0x180B39650", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB39E10", Offset = "0xB39210", VA = "0x180B39E10", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9658C0", Offset = "0x964CC0", VA = "0x1809658C0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72F8040", Offset = "0x72F7440", VA = "0x1872F8040")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72F8080", Offset = "0x72F7480", VA = "0x1872F8080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72F8060", Offset = "0x72F7460", VA = "0x1872F8060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72F80A0", Offset = "0x72F74A0", VA = "0x1872F80A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72F7F30", Offset = "0x72F7330", VA = "0x1872F7F30")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72F7160", Offset = "0x72F6560", VA = "0x1872F7160")]
		public KOIFPCMFICK DHHCBNBCKKG(KOIFPCMFICK GMNKPJJBKFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72F7140", Offset = "0x72F6540", VA = "0x1872F7140", Slot = "25")]
		public Vector3 CIBLFBJJDPE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72F78D0", Offset = "0x72F6CD0", VA = "0x1872F78D0", Slot = "22")]
		public Vector3 IDPCFMPBPCL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72F7560", Offset = "0x72F6960", VA = "0x1872F7560", Slot = "20")]
		public Vector3 GDPIMHPLJJO(Vector3 AAOMFNIJCFO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72F78F0", Offset = "0x72F6CF0", VA = "0x1872F78F0", Slot = "21")]
		public Vector3 JKDIIEBEHPD(Vector3 IINEMILNAJL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72F7450", Offset = "0x72F6850", VA = "0x1872F7450", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72F7970", Offset = "0x72F6D70", VA = "0x1872F7970")]
		protected bool ONNLACEOLHH(AnchorParamsRestrictions OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72F75D0", Offset = "0x72F69D0", VA = "0x1872F75D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72F70D0", Offset = "0x72F64D0", VA = "0x1872F70D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x13C2080", Offset = "0x13C1480", VA = "0x1813C2080")]
	public static bool EKHHBLEJGPM(this OBJHNMCDGDL OGNNAFLGGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72F8AE0", Offset = "0x72F7EE0", VA = "0x1872F8AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x72FA560", Offset = "0x72F9960", VA = "0x1872FA560")]
	public static bool POKOLGIGHGF(this HelmetHairMode FIFICFINBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72FA4E0", Offset = "0x72F98E0", VA = "0x1872FA4E0")]
	public static PKOOKMMPLDP EBPCOGGBFPH(this AvatarItemBodyType KJBFEELDPAB)
	{
		return default(PKOOKMMPLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72FA3A0", Offset = "0x72F97A0", VA = "0x1872FA3A0")]
	public static AvatarItemBodyType ACLGBFNDEDL(this PKOOKMMPLDP KJBFEELDPAB)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72FA420", Offset = "0x72F9820", VA = "0x1872FA420")]
	public static string AOLKFACEHDD(this AvatarItemBodyType KJBFEELDPAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CIMAKCMDKMO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72F8190", Offset = "0x72F7590", VA = "0x1872F8190")]
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
	public enum FALICHFPADL
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
	public static readonly FALICHFPADL LONHBNJLLPI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly FALICHFPADL FGKBNLGGJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly FALICHFPADL GFBGEOIPFJP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72FA290", Offset = "0x72F9690", VA = "0x1872FA290")]
	public static FALICHFPADL EOJLNNCMGOP(FALICHFPADL PKLJLJKKCCA, FALICHFPADL DBJAKICEMMJ)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72FA320", Offset = "0x72F9720", VA = "0x1872FA320")]
	public static FALICHFPADL MODBLGCMGJK(FALICHFPADL OCFOJMDAFKN, FALICHFPADL PEJJIOFJKHM)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72FA310", Offset = "0x72F9710", VA = "0x1872FA310")]
	public static FALICHFPADL JADPLFDHFJO(EHMCMLMEFNE HGJDCAJDLKD, FALICHFPADL MJIFKAKMLDL)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72FA210", Offset = "0x72F9610", VA = "0x1872FA210")]
	public static FALICHFPADL BLKHKAKHOEE(EHMCMLMEFNE HGJDCAJDLKD, FALICHFPADL MJIFKAKMLDL)
	{
		return default(FALICHFPADL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72FA2A0", Offset = "0x72F96A0", VA = "0x1872FA2A0")]
	public static bool FMFKHCFOPAN(this FALICHFPADL FOGBHKGEFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72FA220", Offset = "0x72F9620", VA = "0x1872FA220")]
	public static bool DMLJBFHJJOC(this FALICHFPADL FOGBHKGEFLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BCOAPANBCBE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum AHFGMPCCCPM : short
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
			[Cpp2IlInjected.Address(RVA = "0x72F9C80", Offset = "0x72F9080", VA = "0x1872F9C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72F91E0", Offset = "0x72F85E0", VA = "0x1872F91E0")]
		public void EGIEGHBPICJ(FitMeshHemisphere FKKKLIHMNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72F95B0", Offset = "0x72F89B0", VA = "0x1872F95B0")]
		public Vector3 PCOALJLOGGP(Vector2 NHEABMEEBBE, bool BPLKNEFMCEN = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72F9180", Offset = "0x72F8580", VA = "0x1872F9180")]
		public Vector3 BDHNEIMDICJ(Vector2 NHEABMEEBBE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72F9280", Offset = "0x72F8680", VA = "0x1872F9280")]
		public Quaternion OPBKLKHJPAL(Vector2 NHEABMEEBBE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72F9440", Offset = "0x72F8840", VA = "0x1872F9440")]
		public Quaternion OPBKLKHJPAL(Vector2 NHEABMEEBBE, Vector3 KNEJAKEJFIM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x72F9230", Offset = "0x72F8630", VA = "0x1872F9230")]
		public Vector2 LMGDJKLBOPI(Vector2 ALODLBEKEAO)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72F9BD0", Offset = "0x72F8FD0", VA = "0x1872F9BD0")]
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
public static class LJAHEFGLMCM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72FA630", Offset = "0x72F9A30", VA = "0x1872FA630")]
	public static bool PHLGMHNCDIB(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72FA600", Offset = "0x72F9A00", VA = "0x1872FA600")]
	public static bool MKAGJNMKFFI(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5C0", Offset = "0x72F99C0", VA = "0x1872FA5C0")]
	public static bool KAIMIILPKLN(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72FA580", Offset = "0x72F9980", VA = "0x1872FA580")]
	public static bool DHFAKACCGDI(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72FA620", Offset = "0x72F9A20", VA = "0x1872FA620")]
	public static bool OGHBHJCMCOC(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5E0", Offset = "0x72F99E0", VA = "0x1872FA5E0")]
	public static bool MJMEACGHPCP(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72FA570", Offset = "0x72F9970", VA = "0x1872FA570")]
	public static bool BLMMFOECHJM(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72FA590", Offset = "0x72F9990", VA = "0x1872FA590")]
	public static bool FBCFJFAEJDB(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5A0", Offset = "0x72F99A0", VA = "0x1872FA5A0")]
	public static bool GNMKAFOMNBL(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5D0", Offset = "0x72F99D0", VA = "0x1872FA5D0")]
	public static bool LEBJFGDDIPA(this OutfitType CNBEFNFJEEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EOKAMEMIPNI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly EOKAMEMIPNI IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72F9070", Offset = "0x72F8470", VA = "0x1872F9070", Slot = "4")]
	public bool Equals(OutfitType GLIPEBBNIOG, OutfitType MIMMBLGABED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72F90D0", Offset = "0x72F84D0", VA = "0x1872F90D0", Slot = "5")]
	public int GetHashCode(OutfitType BMIPLDLMPCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EOKAMEMIPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GOEIDDHPLEF
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
public enum LHELENKBGMO
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BJGDFBKEINK
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
public enum DDOKGHHJODE
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
public enum LDBIEKJHPFI
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
public enum EHLDDELHBFB
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
		[Cpp2IlInjected.Address(RVA = "0x72F65E0", Offset = "0x72F59E0", VA = "0x1872F65E0", Slot = "7")]
		public override bool Equals(AdditionalFeetData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72F6610", Offset = "0x72F5A10", VA = "0x1872F6610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72F6690", Offset = "0x72F5A90", VA = "0x1872F6690")]
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
			[Cpp2IlInjected.Address(RVA = "0x72F6BD0", Offset = "0x72F5FD0", VA = "0x1872F6BD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72F66D0", Offset = "0x72F5AD0", VA = "0x1872F66D0", Slot = "7")]
		public override bool Equals(AdditionalHatData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72F68C0", Offset = "0x72F5CC0", VA = "0x1872F68C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72F6A20", Offset = "0x72F5E20", VA = "0x1872F6A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F6CE0", Offset = "0x72F60E0", VA = "0x1872F6CE0")]
		public static bool JOPEBPINLPF(OutfitType BMIPLDLMPCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72F6D10", Offset = "0x72F6110", VA = "0x1872F6D10")]
		public static AdditionalOutfitTypeData OILMBKHFGKP(OutfitType BMIPLDLMPCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72F6C50", Offset = "0x72F6050", VA = "0x1872F6C50", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData OKCHLIEAIJP);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4180", Offset = "0x4BB3580", VA = "0x184BB4180", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T OKCHLIEAIJP);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, OPFGAAPGJPL
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
			[Cpp2IlInjected.Address(RVA = "0xF518C0", Offset = "0xF50CC0", VA = "0x180F518C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72F80C0", Offset = "0x72F74C0", VA = "0x1872F80C0", Slot = "7")]
		public override bool Equals(BeardData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72F80E0", Offset = "0x72F74E0", VA = "0x1872F80E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72F8150", Offset = "0x72F7550", VA = "0x1872F8150")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, OPFGAAPGJPL
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A10", Offset = "0xAA5E10", VA = "0x180AA6A10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x968630", Offset = "0x967A30", VA = "0x180968630", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA681C0", Offset = "0xA675C0", VA = "0x180A681C0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x72FA180", Offset = "0x72F9580", VA = "0x1872FA180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72F9DD0", Offset = "0x72F91D0", VA = "0x1872F9DD0", Slot = "7")]
		public override bool Equals(HairData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72F9FC0", Offset = "0x72F93C0", VA = "0x1872F9FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72FA0C0", Offset = "0x72F94C0", VA = "0x1872FA0C0")]
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
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle FBOHFEANLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HHNKGEMHLHE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72F9D50", Offset = "0x72F9150", VA = "0x1872F9D50")]
	public static OBJHNMCDGDL OMEAAHOOBFP(this OutfitType CNBEFNFJEEJ, AvatarItemSidednessEquipType CKEJOHFGAJF = AvatarItemSidednessEquipType.Left)
	{
		return default(OBJHNMCDGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72F9C90", Offset = "0x72F9090", VA = "0x1872F9C90")]
	public static OBJHNMCDGDL EIOIPOLMJPF(this OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(OBJHNMCDGDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72F9CE0", Offset = "0x72F90E0", VA = "0x1872F9CE0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DGHGNKAGCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72F8B30", Offset = "0x72F7F30", VA = "0x1872F8B30")]
	public static bool OJFOPHHDIBM(this AvatarItemSidednessEquipType CKEJOHFGAJF, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72F8B60", Offset = "0x72F7F60", VA = "0x1872F8B60")]
	public static bool OMJNGEBIADH(this AvatarItemSidednessEquipType JCLBDPJOOIB, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72F8B10", Offset = "0x72F7F10", VA = "0x1872F8B10")]
	public static bool FDEFIIBKDJG(this AvatarItemSidednessEquipType DGFHDKIKKOG, AvatarItemSidednessEquipType IBIJCGMEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72F8AF0", Offset = "0x72F7EF0", VA = "0x1872F8AF0")]
	public static AvatarItemSidednessEquipType EFJBLPGPLNP(this AvatarItemSidednessEquipType DGFHDKIKKOG)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum LJJGPLOBBOC
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
public static class EMBDNMKKGIK
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72F8F00", Offset = "0x72F8300", VA = "0x1872F8F00")]
	private static LJJGPLOBBOC LKIAMICOCJO(this OutfitType CNBEFNFJEEJ)
	{
		return default(LJJGPLOBBOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72F8D90", Offset = "0x72F8190", VA = "0x1872F8D90")]
	public static OutfitSlotFlags FMCCKPGFLHB(this OutfitType CNBEFNFJEEJ)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x72F8D80", Offset = "0x72F8180", VA = "0x1872F8D80")]
	public static bool DOIIGNEADLM(this OutfitSlotFlags CNEDLKPNNJD, OutfitSlotFlags BAJOIMKDKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72F8B90", Offset = "0x72F7F90", VA = "0x1872F8B90")]
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
