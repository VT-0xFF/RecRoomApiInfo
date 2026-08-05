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
public interface NFNPBLMBHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float DOCEMKBGEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float LIPPAGCFCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float MCOOPNIMHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float KFNALCADIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float PHLJDDCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float KCIKHBBPHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MFNLEGBPIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MGOBBDHOPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EKLOLFKEOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float COPEAMDGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float OIBLBGEPGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JIOCOPJMCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float NLIDEMHLFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float HPPIEAHIIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float MCDOFFKPFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CIMPBCBIPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 HEDOLMKDLOE(Vector3 GILNNGGNLNO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 BPIBPMGEFPJ(Vector3 PLHGCOBHEEK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 LLIOBLBMLFI();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : NFNPBLMBHAL
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
			[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC8F7F0", Offset = "0xC8DDF0", VA = "0x180C8F7F0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD47950", Offset = "0xD45F50", VA = "0x180D47950", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1076350", Offset = "0x1074950", VA = "0x181076350", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xF3EEC0", Offset = "0xF3D4C0", VA = "0x180F3EEC0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xC096D0", Offset = "0xC07CD0", VA = "0x180C096D0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA1A660", Offset = "0xA18C60", VA = "0x180A1A660", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB34C0", Offset = "0x7AB1AC0", VA = "0x187AB34C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3E60", Offset = "0x7AB2460", VA = "0x187AB3E60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3E40", Offset = "0x7AB2440", VA = "0x187AB3E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x10B6800", Offset = "0x10B4E00", VA = "0x1810B6800", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1076300", Offset = "0x1074900", VA = "0x181076300", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC073D0", Offset = "0xC059D0", VA = "0x180C073D0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xC07210", Offset = "0xC05810", VA = "0x180C07210", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xEC1FF0", Offset = "0xEC05F0", VA = "0x180EC1FF0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCE0", Offset = "0x10BE2E0", VA = "0x1810BFCE0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3CC0", Offset = "0x7AB22C0", VA = "0x187AB3CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3E80", Offset = "0x7AB2480", VA = "0x187AB3E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3E20", Offset = "0x7AB2420", VA = "0x187AB3E20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x10BFD20", Offset = "0x10BE320", VA = "0x1810BFD20", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC8F740", Offset = "0xC8DD40", VA = "0x180C8F740", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC905F0", Offset = "0xC8EBF0", VA = "0x180C905F0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA05BE0", Offset = "0xA041E0", VA = "0x180A05BE0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3EA0", Offset = "0x7AB24A0", VA = "0x187AB3EA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3EE0", Offset = "0x7AB24E0", VA = "0x187AB3EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3EC0", Offset = "0x7AB24C0", VA = "0x187AB3EC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3F00", Offset = "0x7AB2500", VA = "0x187AB3F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3D90", Offset = "0x7AB2390", VA = "0x187AB3D90")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AB34E0", Offset = "0x7AB1AE0", VA = "0x187AB34E0")]
		public HMAKLDEGKBC LLKNKLFBOEO(HMAKLDEGKBC DJILDNMOKJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3CC0", Offset = "0x7AB22C0", VA = "0x187AB3CC0", Slot = "25")]
		public Vector3 OAMJFEOOMJK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AB34C0", Offset = "0x7AB1AC0", VA = "0x187AB34C0", Slot = "22")]
		public Vector3 LLIOBLBMLFI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3450", Offset = "0x7AB1A50", VA = "0x187AB3450", Slot = "20")]
		public Vector3 HEDOLMKDLOE(Vector3 GILNNGGNLNO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2FC0", Offset = "0x7AB15C0", VA = "0x187AB2FC0", Slot = "21")]
		public Vector3 BPIBPMGEFPJ(Vector3 PLHGCOBHEEK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3040", Offset = "0x7AB1640", VA = "0x187AB3040", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AB37C0", Offset = "0x7AB1DC0", VA = "0x187AB37C0")]
		protected bool NJNJIHOCGFM(AnchorParamsRestrictions MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3150", Offset = "0x7AB1750", VA = "0x187AB3150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F50", Offset = "0x7AB1550", VA = "0x187AB2F50")]
		[CompilerGenerated]
		internal static bool BFENNJKAAAJ(float FDJHCIBLFFB, float CNIMJCCKEDM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ICPCJGAHIID
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x15E97A0", Offset = "0x15E7DA0", VA = "0x1815E97A0")]
	public static bool CLLDJKKBPEC(this LEMFDNDBDJC PAMAJIDJFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5A10", Offset = "0x7AB4010", VA = "0x187AB5A10")]
	public static bool PFGLMJBMBAL(this LEMFDNDBDJC PAMAJIDJFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB59F0", Offset = "0x7AB3FF0", VA = "0x187AB59F0")]
	public static bool GANNDCNGKCM(this LEMFDNDBDJC PAMAJIDJFOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBOEPLHONCA
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool NAPDPGPHGIF;
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
public static class DOHEHBMCBEP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4290", Offset = "0x7AB2890", VA = "0x187AB4290")]
	public static bool GMBECJOLBJG(this HelmetHairMode KCNDKJBPJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4210", Offset = "0x7AB2810", VA = "0x187AB4210")]
	public static BLMBMEMIHNO GHBDIMOPCML(this AvatarItemBodyType MLPKEOCLJHM)
	{
		return default(BLMBMEMIHNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7AB42A0", Offset = "0x7AB28A0", VA = "0x187AB42A0")]
	public static AvatarItemBodyType LDIMJIMGCIC(this BLMBMEMIHNO MLPKEOCLJHM)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4320", Offset = "0x7AB2920", VA = "0x187AB4320")]
	public static string LNPNCGHDNLI(this AvatarItemBodyType MLPKEOCLJHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IGBNNCGFMND
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5A20", Offset = "0x7AB4020", VA = "0x187AB5A20")]
	public static void EMPIAIINIJF(Transform GOOKDBPGMKD, Transform HIMGMAEEBMF, Transform LPNPNKPHHOI, Transform LONLAKNCEJF, float LOPLBAEGEEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DJMKKMKOHOE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OJOBPPEFHGA
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
	public enum KHMINOCKMDE : long
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
	public static readonly IReadOnlyList<OJOBPPEFHGA> BMKNLNJOEOP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<OJOBPPEFHGA> GAABMJCBPJE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<OJOBPPEFHGA> BPIHELPCLHK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IReadOnlyList<OJOBPPEFHGA> FDAPKPLEGLF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly KHMINOCKMDE DNCDOGPDCDD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly KHMINOCKMDE FENICEGMMJA;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly KHMINOCKMDE HENJDODMHHF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4000", Offset = "0x7AB2600", VA = "0x187AB4000")]
	public static KHMINOCKMDE JDEIIAHEOBP(KHMINOCKMDE LDJKFGILCCG, KHMINOCKMDE FLHOCFIPLGL)
	{
		return default(KHMINOCKMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4030", Offset = "0x7AB2630", VA = "0x187AB4030")]
	public static KHMINOCKMDE PHDNMAABENK(KHMINOCKMDE OHGACGDNIKN, KHMINOCKMDE ALHJACDAIMF)
	{
		return default(KHMINOCKMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3FF0", Offset = "0x7AB25F0", VA = "0x187AB3FF0")]
	public static KHMINOCKMDE EICGNEOELNL(OJOBPPEFHGA MIMINBLBPOB, KHMINOCKMDE IKNOJDPIGOK)
	{
		return default(KHMINOCKMDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4010", Offset = "0x7AB2610", VA = "0x187AB4010")]
	public static KHMINOCKMDE OOKDMDCHPMN(OJOBPPEFHGA MIMINBLBPOB, KHMINOCKMDE IKNOJDPIGOK)
	{
		return default(KHMINOCKMDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GOPMEEGJDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MONNCAKECLO : short
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
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7AB50C0", Offset = "0x7AB36C0", VA = "0x187AB50C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4E60", Offset = "0x7AB3460", VA = "0x187AB4E60")]
		public void LJHHIECBHDJ(FitMeshHemisphere DKDPALEGFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4660", Offset = "0x7AB2C60", VA = "0x187AB4660")]
		public Vector3 JBENELHPGNL(Vector2 AFLACKAFDJB, bool BJJBNLOGHMO = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4600", Offset = "0x7AB2C00", VA = "0x187AB4600")]
		public Vector3 DOAFBHHKBBI(Vector2 AFLACKAFDJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4CB0", Offset = "0x7AB32B0", VA = "0x187AB4CB0")]
		public Quaternion JEGADKNNKFO(Vector2 AFLACKAFDJB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4B40", Offset = "0x7AB3140", VA = "0x187AB4B40")]
		public Quaternion JEGADKNNKFO(Vector2 AFLACKAFDJB, Vector3 OCOKHLADLOM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4EB0", Offset = "0x7AB34B0", VA = "0x187AB4EB0")]
		public Vector2 LOAMMHKNNOP(Vector2 HJOLBLABKBE)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5020", Offset = "0x7AB3620", VA = "0x187AB5020")]
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
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FEIADJEINGN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AB45B0", Offset = "0x7AB2BB0", VA = "0x187AB45B0")]
	public static bool KNMHEJMCCPJ(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4590", Offset = "0x7AB2B90", VA = "0x187AB4590")]
	public static bool KDNJFAIAONB(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AB45F0", Offset = "0x7AB2BF0", VA = "0x187AB45F0")]
	public static bool OKPHMDOIEGM(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7AB45E0", Offset = "0x7AB2BE0", VA = "0x187AB45E0")]
	public static bool LPJFFKGEIPA(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AB45D0", Offset = "0x7AB2BD0", VA = "0x187AB45D0")]
	public static bool LOEAIPDDBHM(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4550", Offset = "0x7AB2B50", VA = "0x187AB4550")]
	public static bool GOMKIIBLJPF(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4570", Offset = "0x7AB2B70", VA = "0x187AB4570")]
	public static bool HEOLGCPFBCD(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4540", Offset = "0x7AB2B40", VA = "0x187AB4540")]
	public static bool GECALKINEFD(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4520", Offset = "0x7AB2B20", VA = "0x187AB4520")]
	public static bool EIOCDCAMNLB(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4580", Offset = "0x7AB2B80", VA = "0x187AB4580")]
	public static bool JEABKAMFPKI(this OutfitType KAMFIEKLGNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OFMPCDPPBIK : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static readonly OFMPCDPPBIK MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6370", Offset = "0x7AB4970", VA = "0x187AB6370", Slot = "4")]
	public bool Equals(OutfitType PNBOKFICMGL, OutfitType PGGCGOHBFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB63D0", Offset = "0x7AB49D0", VA = "0x187AB63D0", Slot = "5")]
	public int GetHashCode(OutfitType MLCOGCMJLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OFMPCDPPBIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MCGIHJPPCCH
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum GFLLLLCANOK
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FOHOLFICGPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum BEEBHKAMNNL
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EONPPOBGAOL
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ABOJDNCODIG
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2480", Offset = "0x7AB0A80", VA = "0x187AB2480", Slot = "7")]
		public override bool Equals(AdditionalFeetData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AB24B0", Offset = "0x7AB0AB0", VA = "0x187AB24B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2530", Offset = "0x7AB0B30", VA = "0x187AB2530")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2A60", Offset = "0x7AB1060", VA = "0x187AB2A60")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2570", Offset = "0x7AB0B70", VA = "0x187AB2570", Slot = "7")]
		public override bool Equals(AdditionalHatData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2760", Offset = "0x7AB0D60", VA = "0x187AB2760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7AB28C0", Offset = "0x7AB0EC0", VA = "0x187AB28C0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2AE0", Offset = "0x7AB10E0", VA = "0x187AB2AE0")]
		public static bool ENNCHOEEJEH(OutfitType MLCOGCMJLBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2BA0", Offset = "0x7AB11A0", VA = "0x187AB2BA0")]
		public static AdditionalOutfitTypeData FLLMCNLHKNL(OutfitType MLCOGCMJLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2B10", Offset = "0x7AB1110", VA = "0x187AB2B10", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData MIJLJBIHDMP);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x51D3DC0", Offset = "0x51D23C0", VA = "0x1851D3DC0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T MIJLJBIHDMP);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, OKEKBCBDDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1132F70", Offset = "0x1131570", VA = "0x181132F70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3F20", Offset = "0x7AB2520", VA = "0x187AB3F20", Slot = "7")]
		public override bool Equals(BeardData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3F40", Offset = "0x7AB2540", VA = "0x187AB3F40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3FB0", Offset = "0x7AB25B0", VA = "0x187AB3FB0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, OKEKBCBDDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA088F0", Offset = "0xA06EF0", VA = "0x180A088F0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD31700", Offset = "0xD2FD00", VA = "0x180D31700")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5960", Offset = "0x7AB3F60", VA = "0x187AB5960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7AB55B0", Offset = "0x7AB3BB0", VA = "0x187AB55B0", Slot = "7")]
		public override bool Equals(HairData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7AB57A0", Offset = "0x7AB3DA0", VA = "0x187AB57A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB58A0", Offset = "0x7AB3EA0", VA = "0x187AB58A0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OKEKBCBDDPI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool LCDGIPEHJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle CCIHMCOJCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EBHGJMACMIH
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB43E0", Offset = "0x7AB29E0", VA = "0x187AB43E0")]
	public static LEMFDNDBDJC GBNIPOAFACJ(this OutfitType KAMFIEKLGNP, AvatarItemSidednessEquipType ECJJACPKCJF = AvatarItemSidednessEquipType.Left)
	{
		return default(LEMFDNDBDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4460", Offset = "0x7AB2A60", VA = "0x187AB4460")]
	public static LEMFDNDBDJC IMGJKPKBFHL(this LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(LEMFDNDBDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB44B0", Offset = "0x7AB2AB0", VA = "0x187AB44B0")]
	public static bool NBDFBOGHCAK(this OutfitType KAMFIEKLGNP, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AKCKGLAJDHF
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2430", Offset = "0x7AB0A30", VA = "0x187AB2430")]
	public static bool LOIDBNIOKNE(this AvatarItemSidednessEquipType ECJJACPKCJF, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0A00", VA = "0x187AB2400")]
	public static bool DIAAJEBHJBN(this AvatarItemSidednessEquipType LKBCNGKMFNE, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2460", Offset = "0x7AB0A60", VA = "0x187AB2460")]
	public static bool OOFNACAJOEC(this AvatarItemSidednessEquipType ONGLDJLGMNH, AvatarItemSidednessEquipType OADIHJKJAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7AB23E0", Offset = "0x7AB09E0", VA = "0x187AB23E0")]
	public static AvatarItemSidednessEquipType APJDHNMNBCK(this AvatarItemSidednessEquipType ONGLDJLGMNH)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum GCMOHKNEFFF
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GKLNEDDICME
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7AB50D0", Offset = "0x7AB36D0", VA = "0x187AB50D0")]
	private static GCMOHKNEFFF FMLNEKOKNKL(this OutfitType KAMFIEKLGNP)
	{
		return default(GCMOHKNEFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5250", Offset = "0x7AB3850", VA = "0x187AB5250")]
	public static OutfitSlotFlags KKBBKCECEFM(this OutfitType KAMFIEKLGNP)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5240", Offset = "0x7AB3840", VA = "0x187AB5240")]
	public static bool HJJAFECPDLG(this OutfitSlotFlags IIGEBJIKJEL, OutfitSlotFlags NCPDEGEDEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AB53C0", Offset = "0x7AB39C0", VA = "0x187AB53C0")]
	public static bool POLOIHCGNFM(this OutfitType KAMFIEKLGNP, OutfitSlotFlags BJKMEFHHBJA)
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
