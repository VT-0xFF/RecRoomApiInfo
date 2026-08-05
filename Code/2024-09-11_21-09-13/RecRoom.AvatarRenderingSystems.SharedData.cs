using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JIJLAIOODGG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float BONPNIAKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float JGEDHCNMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float EAEKNJKICAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float FEKPNJOGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float CPEHPKBNCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float EIFOBLHNIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DGFJIIFMJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ECLPFFCCCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MOIIEDOMNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float IGGBGAPNHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KGLJAMLPCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KPKJDJLAACM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GNJAPGJFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float BDPMOCIJPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float LNNPLOFDHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float GGFGHKBCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 KHOOIEHOIAP(Vector3 JDEAKAIMACM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 GCPIDMFODHH(Vector3 BHFAFLIBJLE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 JGKALKCOPOO();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : JIJLAIOODGG
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
			[Cpp2IlInjected.Address(RVA = "0xA00000", Offset = "0x9FE600", VA = "0x180A00000", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD0BF00", Offset = "0xD0A500", VA = "0x180D0BF00", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x91DD80", Offset = "0x91C380", VA = "0x18091DD80", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35AB0", VA = "0x180A374B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9F2D10", Offset = "0x9F1310", VA = "0x1809F2D10", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9253A0", Offset = "0x9239A0", VA = "0x1809253A0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9065A0", Offset = "0x904BA0", VA = "0x1809065A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B5400", Offset = "0x8B3A00", VA = "0x1808B5400", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A11ED0", Offset = "0x6A104D0", VA = "0x186A11ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA37480", Offset = "0xA35A80", VA = "0x180A37480", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2C90", Offset = "0x9F1290", VA = "0x1809F2C90", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x925380", Offset = "0x923980", VA = "0x180925380", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9F2D30", Offset = "0x9F1330", VA = "0x1809F2D30", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3C0", Offset = "0x8FA9C0", VA = "0x1808FC3C0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA40460", Offset = "0xA3EA60", VA = "0x180A40460", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6A122B0", Offset = "0x6A108B0", VA = "0x186A122B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA404D0", Offset = "0xA3EAD0", VA = "0x180A404D0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA40510", Offset = "0xA3EB10", VA = "0x180A40510", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA40500", Offset = "0xA3EB00", VA = "0x180A40500", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8A0B60", Offset = "0x89F160", VA = "0x1808A0B60", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6A12910", Offset = "0x6A10F10", VA = "0x186A12910")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6A12950", Offset = "0x6A10F50", VA = "0x186A12950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6A12930", Offset = "0x6A10F30", VA = "0x186A12930")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6A12970", Offset = "0x6A10F70", VA = "0x186A12970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A12880", Offset = "0x6A10E80", VA = "0x186A12880")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A11FD0", Offset = "0x6A105D0", VA = "0x186A11FD0")]
		public FMFJFNMKGFN LFAOPCIFMME(FMFJFNMKGFN MPGLBEDMFKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A122B0", Offset = "0x6A108B0", VA = "0x186A122B0", Slot = "25")]
		public Vector3 MAFFCKEGGJO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A11ED0", Offset = "0x6A104D0", VA = "0x186A11ED0", Slot = "22")]
		public Vector3 JGKALKCOPOO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F60", Offset = "0x6A10560", VA = "0x186A11F60", Slot = "20")]
		public Vector3 KHOOIEHOIAP(Vector3 JDEAKAIMACM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A11E50", Offset = "0x6A10450", VA = "0x186A11E50", Slot = "21")]
		public Vector3 GCPIDMFODHH(Vector3 BHFAFLIBJLE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A11D40", Offset = "0x6A10340", VA = "0x186A11D40", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A122D0", Offset = "0x6A108D0", VA = "0x186A122D0")]
		protected bool OAGHAJOHACJ(AnchorParamsRestrictions PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A11EF0", Offset = "0x6A104F0", VA = "0x186A11EF0")]
		[CompilerGenerated]
		internal static bool JICGNHNEKEP(float MOKDKAEJAPP, float MKGNFMMEFHC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MCGGHHINOAF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OMNFECBJHMM
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LDMPKENIKGE
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NoPattern,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Curly,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Braid
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FNMAPJHHAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ModernBeanBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PIKHPBLJBPO
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A13BC0", Offset = "0x6A121C0", VA = "0x186A13BC0")]
	public static bool FNNNHDFMKDH(this MCGGHHINOAF NHPJIMMNJLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A13BD0", Offset = "0x6A121D0", VA = "0x186A13BD0")]
	public static MMBBNHOOGFA IGPOHNOLFIL(this FNMAPJHHAKI DAOLHFDKAOD)
	{
		return default(MMBBNHOOGFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A13C50", Offset = "0x6A12250", VA = "0x186A13C50")]
	public static FNMAPJHHAKI JCKGCKGOFLB(this MMBBNHOOGFA DAOLHFDKAOD)
	{
		return default(FNMAPJHHAKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JAKMGBMNCCH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FMBCJFFJNJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum MGOIBKLDNOG
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static MGOIBKLDNOG MCHHHPMKAIB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MGOIBKLDNOG ELIJGLACCGI;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A13AD0", Offset = "0x6A120D0", VA = "0x186A13AD0")]
	public static MGOIBKLDNOG GCAPLIKFHLE(MGOIBKLDNOG CPANICAOGOB, MGOIBKLDNOG HCEOEEIAOAF)
	{
		return default(MGOIBKLDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A13A50", Offset = "0x6A12050", VA = "0x186A13A50")]
	public static MGOIBKLDNOG EGLAGLJLIJP(MGOIBKLDNOG LPDMIGJMBHJ, MGOIBKLDNOG EPPJHAAHCFJ)
	{
		return default(MGOIBKLDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A13AF0", Offset = "0x6A120F0", VA = "0x186A13AF0")]
	public static MGOIBKLDNOG NPJAAPBAPDH(FMBCJFFJNJC KGLFOKDCNFP, MGOIBKLDNOG PEIPHADNGIF)
	{
		return default(MGOIBKLDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A13AE0", Offset = "0x6A120E0", VA = "0x186A13AE0")]
	public static MGOIBKLDNOG JEOINNDGABD(FMBCJFFJNJC KGLFOKDCNFP, MGOIBKLDNOG PEIPHADNGIF)
	{
		return default(MGOIBKLDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A13B00", Offset = "0x6A12100", VA = "0x186A13B00")]
	public static bool PPMCDLMLIIK(this MGOIBKLDNOG EOPONNJBIAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A13A60", Offset = "0x6A12060", VA = "0x186A13A60")]
	public static bool GBBANGLNAEM(this MGOIBKLDNOG EOPONNJBIAI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6A13600", Offset = "0x6A11C00", VA = "0x186A13600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A133F0", Offset = "0x6A119F0", VA = "0x186A133F0")]
		public void OMLFCKBOKKM(FitMeshHemisphere HNOFBECGDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A12C40", Offset = "0x6A11240", VA = "0x186A12C40")]
		public Vector3 GMOJHKPLOKD(Vector2 JEBPIHOLMPI, bool GPAPEELACDH = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A12FF0", Offset = "0x6A115F0", VA = "0x186A12FF0")]
		public Vector3 LEJHDJJAPKH(Vector2 JEBPIHOLMPI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A13050", Offset = "0x6A11650", VA = "0x186A13050")]
		public Quaternion NKKOGHHFOAA(Vector2 JEBPIHOLMPI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A13210", Offset = "0x6A11810", VA = "0x186A13210")]
		public Quaternion NKKOGHHFOAA(Vector2 JEBPIHOLMPI, Vector3 DPIGACGOFED)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A13390", Offset = "0x6A11990", VA = "0x186A13390")]
		public Vector2 OCBJOFGICLI(Vector2 LKMGDFCFIJD)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A13560", Offset = "0x6A11B60", VA = "0x186A13560")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FGMKDJBDHCC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A12B70", Offset = "0x6A11170", VA = "0x186A12B70")]
	public static bool DJBKJPPOEEE(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A12BC0", Offset = "0x6A111C0", VA = "0x186A12BC0")]
	public static bool MDDHNBNFAIJ(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A12BB0", Offset = "0x6A111B0", VA = "0x186A12BB0")]
	public static bool KDKFOPHLKKH(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A12B60", Offset = "0x6A11160", VA = "0x186A12B60")]
	public static bool DHLDGPJCPHM(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C30", Offset = "0x6A11230", VA = "0x186A12C30")]
	public static bool PHELJMJJIMD(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A12BE0", Offset = "0x6A111E0", VA = "0x186A12BE0")]
	public static bool MJAPDBNNPMH(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C10", Offset = "0x6A11210", VA = "0x186A12C10")]
	public static bool OHEGAEJEMEC(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C20", Offset = "0x6A11220", VA = "0x186A12C20")]
	public static bool PFINGIFPOPL(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A12B90", Offset = "0x6A11190", VA = "0x186A12B90")]
	public static bool ICAIHKIBOCE(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C00", Offset = "0x6A11200", VA = "0x186A12C00")]
	public static bool OAKCPCFDECK(this OutfitType IDKHDGOOGPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DGOGMHLNENL : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly DGOGMHLNENL DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A12A60", Offset = "0x6A11060", VA = "0x186A12A60", Slot = "4")]
	public bool Equals(OutfitType NDGBIAHMIPG, OutfitType AHFFKCLDJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A12AC0", Offset = "0x6A110C0", VA = "0x186A12AC0", Slot = "5")]
	public int GetHashCode(OutfitType JLAAKHANEHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public DGOGMHLNENL()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MCGGHHINOAF helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A11870", Offset = "0x6A0FE70", VA = "0x186A11870")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A11380", Offset = "0x6A0F980", VA = "0x186A11380", Slot = "8")]
		public override bool Equals(AdditionalHatData PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A11570", Offset = "0x6A0FB70", VA = "0x186A11570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A116D0", Offset = "0x6A0FCD0", VA = "0x186A116D0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A118F0", Offset = "0x6A0FEF0", VA = "0x186A118F0")]
		public static bool DHDCBJKHJKJ(OutfitType JLAAKHANEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6A119A0", Offset = "0x6A0FFA0", VA = "0x186A119A0")]
		public static AdditionalOutfitTypeData GMDNOGMNFLF(OutfitType JLAAKHANEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A11910", Offset = "0x6A0FF10", VA = "0x186A11910", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData PLNBHPCFEOK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6A11CD0", Offset = "0x6A102D0", VA = "0x186A11CD0", Slot = "6")]
		public virtual AdditionalOutfitTypeData HMDPNAMIDEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4210D10", Offset = "0x420F310", VA = "0x184210D10", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T PLNBHPCFEOK);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, AEOMJBBLCMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LDMPKENIKGE beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xACA040", Offset = "0xAC8640", VA = "0x180ACA040", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public LDMPKENIKGE PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0", Slot = "10")]
			get
			{
				return default(LDMPKENIKGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A12990", Offset = "0x6A10F90", VA = "0x186A12990", Slot = "8")]
		public override bool Equals(BeardData PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A129B0", Offset = "0x6A10FB0", VA = "0x186A129B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A12A20", Offset = "0x6A11020", VA = "0x186A12A20")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, AEOMJBBLCMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LDMPKENIKGE hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OMNFECBJHMM helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x915190", Offset = "0x913790", VA = "0x180915190", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public LDMPKENIKGE PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8A38E0", Offset = "0x8A1EE0", VA = "0x1808A38E0", Slot = "10")]
			get
			{
				return default(LDMPKENIKGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6A139C0", Offset = "0x6A11FC0", VA = "0x186A139C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A13610", Offset = "0x6A11C10", VA = "0x186A13610", Slot = "8")]
		public override bool Equals(HairData PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A13800", Offset = "0x6A11E00", VA = "0x186A13800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A13900", Offset = "0x6A11F00", VA = "0x186A13900")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AEOMJBBLCMM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool BAIMIGAHLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LDMPKENIKGE GAPDGENPKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
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
