using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface QVOBUABNYVC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		float LNEODVRLOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		float YRPMBUJKKYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		float VXSWXIIZIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		float DISSFPJOQXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		float YADWGMHGZZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float WNOUAXYPZPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float PGRCRRYRCZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		float MGOODWNQLZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		float PGLVULETTOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		float MGTVBDHNVKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		float PHBQMFMLVWR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float MGEAJIZVTCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		float TZSWUUGATTD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float WDSSVIJQNZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector3 XYTTDDJVNUM(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Vector3 NMHJYHUIYRD(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Vector3 VWOGMGAHLUU();
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : QVOBUABNYVC
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
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBF7020", Offset = "0xBF5C20", VA = "0x180BF7020", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float UPLRWEAEHRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB77D20", Offset = "0xB76920", VA = "0x180B77D20", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float TKUFSEJZGKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76650", VA = "0x180B77A50", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float XBCVMXJABAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB6A410", Offset = "0xB69010", VA = "0x180B6A410", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float PNOWRTFDNPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x11960F0", Offset = "0x1194CF0", VA = "0x1811960F0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float HESCUGSIZDC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xEE6FB0", Offset = "0xEE5BB0", VA = "0x180EE6FB0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float UCDEENYAZZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xE2D8A0", Offset = "0xE2C4A0", VA = "0x180E2D8A0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x885F550", Offset = "0x885E150", VA = "0x18885F550")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x885F770", Offset = "0x885E370", VA = "0x18885F770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x885F750", Offset = "0x885E350", VA = "0x18885F750")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float QWEBYGCEBSO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x12DDDE0", Offset = "0x12DC9E0", VA = "0x1812DDDE0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float CIIOVQRIWAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF9E0D0", Offset = "0xF9CCD0", VA = "0x180F9E0D0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float QWJIVMWBLDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB44790", Offset = "0xB43390", VA = "0x180B44790", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float CIDHYJXLMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB65000", Offset = "0xB63C00", VA = "0x180B65000", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float QVYVAZIGSHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF708B0", Offset = "0xF6F4B0", VA = "0x180F708B0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float CINVSXLGFLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1371CD0", Offset = "0x13708D0", VA = "0x181371CD0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x885E850", Offset = "0x885D450", VA = "0x18885E850")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x885F790", Offset = "0x885E390", VA = "0x18885F790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x885F730", Offset = "0x885E330", VA = "0x18885F730")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1371D10", Offset = "0x1370910", VA = "0x181371D10", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xE8C3F0", Offset = "0xE8AFF0", VA = "0x180E8C3F0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float AUWBKGOYLUH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE8C400", Offset = "0xE8B000", VA = "0x180E8C400", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float KUWFQPRMOND
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE8B190", Offset = "0xE89D90", VA = "0x180E8B190", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x885F7B0", Offset = "0x885E3B0", VA = "0x18885F7B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x885F7F0", Offset = "0x885E3F0", VA = "0x18885F7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x885F7D0", Offset = "0x885E3D0", VA = "0x18885F7D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x885F810", Offset = "0x885E410", VA = "0x18885F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x885F6A0", Offset = "0x885E2A0", VA = "0x18885F6A0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x885F170", Offset = "0x885DD70", VA = "0x18885F170")]
		public EGXISHAOLQW NGDEEUUMCNI(EGXISHAOLQW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x885E850", Offset = "0x885D450", VA = "0x18885E850", Slot = "25")]
		public Vector3 DKLILKHSSJN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x885F550", Offset = "0x885E150", VA = "0x18885F550", Slot = "22")]
		public Vector3 VWOGMGAHLUU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x885F570", Offset = "0x885E170", VA = "0x18885F570", Slot = "20")]
		public Vector3 XYTTDDJVNUM(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x885F460", Offset = "0x885E060", VA = "0x18885F460", Slot = "21")]
		public Vector3 NMHJYHUIYRD(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x885ED70", Offset = "0x885D970", VA = "0x18885ED70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x885E870", Offset = "0x885D470", VA = "0x18885E870")]
		protected bool Equals(AnchorParamsRestrictions other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x885EE70", Offset = "0x885DA70", VA = "0x18885EE70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x885F4E0", Offset = "0x885E0E0", VA = "0x18885F4E0")]
		[CompilerGenerated]
		internal static bool SSWUACGEQFT(float a, float b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class GIMBEEOCZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x19E4B10", Offset = "0x19E3710", VA = "0x1819E4B10")]
		public static bool MDGUQSWBSRW(this AvatarBodyPart a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8860490", Offset = "0x885F090", VA = "0x188860490")]
		public static bool FHZPGUAJDFD(this AvatarBodyPart a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88604A0", Offset = "0x885F0A0", VA = "0x1888604A0")]
		public static bool GXYESNEOQAT(this AvatarBodyPart a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88604C0", Offset = "0x885F0C0", VA = "0x1888604C0")]
		public static bool MBOOMEFQVNU(this AvatarBodyPart a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QLQCRCQQSEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static bool HHJRBJEUJAL;
	}
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
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class PAULLASUNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8861960", Offset = "0x8860560", VA = "0x188861960")]
		public static bool NURSROAEBKN(this HelmetHairMode a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88618F0", Offset = "0x88604F0", VA = "0x1888618F0")]
		public static AvatarBodyType LWWFEHIXHTD(this AvatarItemBodyType a)
		{
			return default(AvatarBodyType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8861970", Offset = "0x8860570", VA = "0x188861970")]
		public static AvatarItemBodyType PAWVHYGVXXR(this AvatarBodyType a)
		{
			return default(AvatarItemBodyType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88619E0", Offset = "0x88605E0", VA = "0x1888619E0")]
		public static string UZPEPVALUOA(this AvatarItemBodyType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class LVRATOVOQNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8860F00", Offset = "0x885FB00", VA = "0x188860F00")]
		public static void ZMSWVSGZCBV(Transform a, Transform b, Transform c, Transform d, float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RRSNZGUWRZN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum SkinCullingMaskSelection
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
		public enum SkinCullingMask : long
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
		public static readonly IReadOnlyList<SkinCullingMaskSelection> LEZDLXHXCQS;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly IReadOnlyList<SkinCullingMaskSelection> SAKALODXGFX;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly IReadOnlyList<SkinCullingMaskSelection> WODPSLXVSCH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IReadOnlyList<SkinCullingMaskSelection> LIEZRCYKRCH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly SkinCullingMask PLEYKDZCHMJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly SkinCullingMask YMTLOJQOABG;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly SkinCullingMask ANMVIZIXNMR;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8861A90", Offset = "0x8860690", VA = "0x188861A90")]
		public static SkinCullingMask IWWZSVTOZRC(SkinCullingMask a, SkinCullingMask b)
		{
			return default(SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8861AD0", Offset = "0x88606D0", VA = "0x188861AD0")]
		public static SkinCullingMask YVHBXHLFRBF(SkinCullingMask a, SkinCullingMask b)
		{
			return default(SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8861AA0", Offset = "0x88606A0", VA = "0x188861AA0")]
		public static SkinCullingMask QSPBEKOMPFK(SkinCullingMaskSelection a, SkinCullingMask b)
		{
			return default(SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8861AB0", Offset = "0x88606B0", VA = "0x188861AB0")]
		public static SkinCullingMask XAEDENLPDVE(SkinCullingMaskSelection a, SkinCullingMask b)
		{
			return default(SkinCullingMask);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IXZFSOMDNHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum Emote : short
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
			[Cpp2IlInjected.Address(RVA = "0x8860480", Offset = "0x885F080", VA = "0x188860480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8860180", Offset = "0x885ED80", VA = "0x188860180")]
		public void QAEJRVVRTGH(FitMeshHemisphere a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x885FC90", Offset = "0x885E890", VA = "0x18885FC90")]
		public Vector3 JCCFTBEFGIE(Vector2 a, bool b = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x885F900", Offset = "0x885E500", VA = "0x18885F900")]
		public Vector3 ABLOSKGNMTK(Vector2 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x885F960", Offset = "0x885E560", VA = "0x18885F960")]
		public Quaternion IUQKCKODGSF(Vector2 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x885FB20", Offset = "0x885E720", VA = "0x18885FB20")]
		public Quaternion IUQKCKODGSF(Vector2 a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88601D0", Offset = "0x885EDD0", VA = "0x1888601D0")]
		public Vector2 QEFROIAONOB(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88603D0", Offset = "0x885EFD0", VA = "0x1888603D0")]
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
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class YRBIZISJWTX
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88625C0", Offset = "0x88611C0", VA = "0x1888625C0")]
		public static bool HNVKHVCCOQX(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88625E0", Offset = "0x88611E0", VA = "0x1888625E0")]
		public static bool JVYHJORCKUP(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8862660", Offset = "0x8861260", VA = "0x188862660")]
		public static bool LTANMFKLEHV(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88625A0", Offset = "0x88611A0", VA = "0x1888625A0")]
		public static bool FLEHNRJJXTS(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88626A0", Offset = "0x88612A0", VA = "0x1888626A0")]
		public static bool VUOJNMZKTMK(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8862580", Offset = "0x8861180", VA = "0x188862580")]
		public static bool DHJTZTCTMCK(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8862600", Offset = "0x8861200", VA = "0x188862600")]
		public static bool JXJTVSLJJPF(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8862690", Offset = "0x8861290", VA = "0x188862690")]
		public static bool VCWNKMZEJTE(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8862750", Offset = "0x8861350", VA = "0x188862750")]
		public static bool YQMAYOLYPIX(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88625B0", Offset = "0x88611B0", VA = "0x1888625B0")]
		public static bool GHLKUICDABA(this OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8862670", Offset = "0x8861270", VA = "0x188862670")]
		public static bool RYJECDQOJBJ(this OutfitType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class XVXFOKUCVGZ : IEqualityComparer<OutfitType>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly XVXFOKUCVGZ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88623D0", Offset = "0x8860FD0", VA = "0x1888623D0", Slot = "4")]
		public bool Equals(OutfitType type1, OutfitType type2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8862430", Offset = "0x8861030", VA = "0x188862430", Slot = "5")]
		public int GetHashCode(OutfitType type)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XVXFOKUCVGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum AvatarColorType
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
	public enum AvatarTextureType
	{
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		HairPattern,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		BeardPattern
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum UpdatableColorType
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
	public enum UpdatableTextureType
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
	public enum MeshMergeModes
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
	public enum NoseType
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
		[Cpp2IlInjected.Address(RVA = "0x885DCB0", Offset = "0x885C8B0", VA = "0x18885DCB0", Slot = "7")]
		public override bool Equals(AdditionalFeetData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x885DCE0", Offset = "0x885C8E0", VA = "0x18885DCE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x885DD60", Offset = "0x885C960", VA = "0x18885DD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x885E220", Offset = "0x885CE20", VA = "0x18885E220")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x885DDA0", Offset = "0x885C9A0", VA = "0x18885DDA0", Slot = "7")]
		public override bool Equals(AdditionalHatData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x885DF90", Offset = "0x885CB90", VA = "0x18885DF90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x885E0F0", Offset = "0x885CCF0", VA = "0x18885E0F0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		protected const float KAFBCANIPNP = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x885E810", Offset = "0x885D410", VA = "0x18885E810")]
		public static bool FSTSZPNJOIC(OutfitType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x885E2A0", Offset = "0x885CEA0", VA = "0x18885E2A0")]
		public static AdditionalOutfitTypeData Create(OutfitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x885E780", Offset = "0x885D380", VA = "0x18885E780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData other);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E24F70", Offset = "0x5E23B70", VA = "0x185E24F70", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T other);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class WSQIDJRUJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8862320", Offset = "0x8860F20", VA = "0x188862320")]
		public static bool TQTCTMZCBBM(this AdditionalOutfitTypeData a)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, FXSASYHCHHT
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
			[Cpp2IlInjected.Address(RVA = "0x13E8500", Offset = "0x13E7100", VA = "0x1813E8500", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x885F830", Offset = "0x885E430", VA = "0x18885F830", Slot = "7")]
		public override bool Equals(BeardData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x885F850", Offset = "0x885E450", VA = "0x18885F850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x885F8C0", Offset = "0x885E4C0", VA = "0x18885F8C0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HairData : AdditionalOutfitTypeData<HairData>, FXSASYHCHHT
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
			[Cpp2IlInjected.Address(RVA = "0xFD49C0", Offset = "0xFD35C0", VA = "0x180FD49C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB540B0", Offset = "0xB52CB0", VA = "0x180B540B0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB31CB0", Offset = "0xB308B0", VA = "0x180B31CB0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8860890", Offset = "0x885F490", VA = "0x188860890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88604E0", Offset = "0x885F0E0", VA = "0x1888604E0", Slot = "7")]
		public override bool Equals(HairData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88606D0", Offset = "0x885F2D0", VA = "0x1888606D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88607D0", Offset = "0x885F3D0", VA = "0x1888607D0")]
		public HairData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface MSNBHZRMOFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool IsTranslatable
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool IsRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AnchorParamsRestrictions JWZYFKXXSBZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface FXSASYHCHHT
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface CQXNIMBNAGL
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		const string KDGEEDIXIVI = "FFFFFF";

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RoomieEyeData : AdditionalOutfitTypeData<RoomieEyeData>, CQXNIMBNAGL
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
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8861CD0", Offset = "0x88608D0", VA = "0x188861CD0", Slot = "7")]
		public override bool Equals(RoomieEyeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8861D00", Offset = "0x8860900", VA = "0x188861D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8861D70", Offset = "0x8860970", VA = "0x188861D70")]
		public RoomieEyeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RoomieHatData : AdditionalOutfitTypeData<RoomieHatData>, CQXNIMBNAGL, MSNBHZRMOFI
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
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsTranslatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8861FA0", Offset = "0x8860BA0", VA = "0x188861FA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8861F80", Offset = "0x8860B80", VA = "0x188861F80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8861DE0", Offset = "0x88609E0", VA = "0x188861DE0", Slot = "7")]
		public override bool Equals(RoomieHatData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8861E50", Offset = "0x8860A50", VA = "0x188861E50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "12")]
		public AnchorParamsRestrictions JWZYFKXXSBZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8861ED0", Offset = "0x8860AD0", VA = "0x188861ED0")]
		public RoomieHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RoomieWaistData : AdditionalOutfitTypeData<RoomieWaistData>, CQXNIMBNAGL
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
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8861CD0", Offset = "0x88608D0", VA = "0x188861CD0", Slot = "7")]
		public override bool Equals(RoomieWaistData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8861FC0", Offset = "0x8860BC0", VA = "0x188861FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8862030", Offset = "0x8860C30", VA = "0x188862030")]
		public RoomieWaistData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class YRBIZISJWTX
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x88624D0", Offset = "0x88610D0", VA = "0x1888624D0")]
		public static AvatarBodyPart CRVWUTTBBYF(this OutfitType a, AvatarItemSidednessEquipType b = AvatarItemSidednessEquipType.Left)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8862560", Offset = "0x8861160", VA = "0x188862560")]
		public static RecRoom.DataLayer.RoomieBodyPart CWIYYYFBNQE(this OutfitType a, AvatarItemSidednessEquipType b = AvatarItemSidednessEquipType.Left)
		{
			return default(RecRoom.DataLayer.RoomieBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8862610", Offset = "0x8861210", VA = "0x188862610")]
		public static AvatarBodyPart KZRLBGUAJBV(this AvatarBodyPart a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88626B0", Offset = "0x88612B0", VA = "0x1888626B0")]
		public static bool XCUFOUEMKGP(this OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}
	}
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
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NAREJHKMNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88618A0", Offset = "0x88604A0", VA = "0x1888618A0")]
		public static bool URBZJMXWUJG(this AvatarItemSidednessEquipType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8861870", Offset = "0x8860470", VA = "0x188861870")]
		public static bool TBDQSLTWWWR(this AvatarItemSidednessEquipType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x88618D0", Offset = "0x88604D0", VA = "0x1888618D0")]
		public static bool VDVLNAESGXM(this AvatarItemSidednessEquipType a, AvatarItemSidednessEquipType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8861850", Offset = "0x8860450", VA = "0x188861850")]
		public static AvatarItemSidednessEquipType ASYLJJCJZPW(this AvatarItemSidednessEquipType a)
		{
			return default(AvatarItemSidednessEquipType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal enum OutfitSlot
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
		All = 0x7FFFFFFF
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class JLRUERYTFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8860920", Offset = "0x885F520", VA = "0x188860920")]
		private static OutfitSlot FKTXCOMXIUX(this OutfitType a)
		{
			return default(OutfitSlot);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8860D40", Offset = "0x885F940", VA = "0x188860D40")]
		public static OutfitSlotFlags RPJHCZLPCAM(this OutfitType a)
		{
			return default(OutfitSlotFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8860AE0", Offset = "0x885F6E0", VA = "0x188860AE0")]
		public static bool GOADBZOWISE(this OutfitSlotFlags a, OutfitSlotFlags b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8860AF0", Offset = "0x885F6F0", VA = "0x188860AF0")]
		public static bool HSZTXPDXJQQ(this OutfitType a, OutfitSlotFlags b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Avatars.AvatarEffectsDataTypes
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct TextureEffectMaterialProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public Vector4 lutST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public Vector4 globalConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Vector4 vfx1Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Vector4 vfx2Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Vector4 vfx3Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Vector4 vfx4Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Vector4 vfx1ST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Vector4 vfx2ST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Vector4 vfx3ST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Vector4 vfx4ST;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x88620A0", Offset = "0x8860CA0", VA = "0x1888620A0")]
		public void JFHSUCPOSQT(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct TextureEffectMaterialTextures
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Texture2D effectMasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Texture2D effectLUT;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88622A0", Offset = "0x8860EA0", VA = "0x1888622A0")]
		public void JFHSUCPOSQT(Material a)
		{
		}
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
