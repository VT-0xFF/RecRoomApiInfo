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
public interface KIGDBPAEBEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float EBHAMEMFBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float OPOLDOKCKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float EHDNDPFDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float NLCNNLGILOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float JJNOANINLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float FCMACPPKBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float JAONGNGJNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KLIDKCFFPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OAGNJACHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float ANDFNAMLINC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float ANJIIFFAEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float AIIOCBCHMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float HKBOGCKABHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float HENEBBPMCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float PJJKKONFFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HKJKKDHBJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 HNLBAKEFING(Vector3 PGHBEDDAPBP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 PKEHDKDELIN(Vector3 DPIIEDEIIFO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 AOJMEBCKMED();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : KIGDBPAEBEO
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
			[Cpp2IlInjected.Address(RVA = "0x8B7E10", Offset = "0x8B6A10", VA = "0x1808B7E10", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB928D0", Offset = "0xB914D0", VA = "0x180B928D0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D15D0", Offset = "0x8D01D0", VA = "0x1808D15D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D1590", Offset = "0x8D0190", VA = "0x1808D1590", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D15C0", Offset = "0x8D01C0", VA = "0x1808D15C0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D15A0", Offset = "0x8D01A0", VA = "0x1808D15A0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1580", Offset = "0x8D0180", VA = "0x1808D1580", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8952D0", Offset = "0x893ED0", VA = "0x1808952D0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x687A980", Offset = "0x6879580", VA = "0x18687A980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D1520", Offset = "0x8D0120", VA = "0x1808D1520", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D40", Offset = "0x8D0940", VA = "0x1808D1D40", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1540", Offset = "0x8D0140", VA = "0x1808D1540", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D1550", Offset = "0x8D0150", VA = "0x1808D1550", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C40", Offset = "0x8D0840", VA = "0x1808D1C40", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C30", Offset = "0x8D0830", VA = "0x1808D1C30", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x687A960", Offset = "0x6879560", VA = "0x18687A960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CC0", Offset = "0x8D08C0", VA = "0x1808D1CC0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D10", Offset = "0x8D0910", VA = "0x1808D1D10", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CF0", Offset = "0x8D08F0", VA = "0x1808D1CF0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x881140", Offset = "0x87FD40", VA = "0x180881140", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x687B550", Offset = "0x687A150", VA = "0x18687B550")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x687B590", Offset = "0x687A190", VA = "0x18687B590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x687B570", Offset = "0x687A170", VA = "0x18687B570")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x687B5B0", Offset = "0x687A1B0", VA = "0x18687B5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x687B4C0", Offset = "0x687A0C0", VA = "0x18687B4C0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x687B090", Offset = "0x6879C90", VA = "0x18687B090")]
		public IBJDFNNFBEJ IICGAKFEFEA(IBJDFNNFBEJ NIMDJLDOPPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x687A960", Offset = "0x6879560", VA = "0x18687A960", Slot = "25")]
		public Vector3 AAFPBFKCKBK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x687A980", Offset = "0x6879580", VA = "0x18687A980", Slot = "22")]
		public Vector3 AOJMEBCKMED()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x687AFB0", Offset = "0x6879BB0", VA = "0x18687AFB0", Slot = "20")]
		public Vector3 HNLBAKEFING(Vector3 PGHBEDDAPBP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x687B380", Offset = "0x6879F80", VA = "0x18687B380", Slot = "21")]
		public Vector3 PKEHDKDELIN(Vector3 DPIIEDEIIFO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x687AEA0", Offset = "0x6879AA0", VA = "0x18687AEA0", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x687A9A0", Offset = "0x68795A0", VA = "0x18687A9A0")]
		protected bool BLCHPEHHACB(AnchorParamsRestrictions HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x687B020", Offset = "0x6879C20", VA = "0x18687B020")]
		[CompilerGenerated]
		internal static bool IAKCMKFBOKF(float PFJBMEMCGDE, float GCHHKKAJBGE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NAMGEKDMCNI
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
public enum JGEMJCMHICA
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JNFPLAMIGKC
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
public enum HFBKCJFJOFO
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DOBGPJGLPEP
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x687B8C0", Offset = "0x687A4C0", VA = "0x18687B8C0")]
	public static bool BEEPIAJDHPN(this NAMGEKDMCNI MIHJJCLHEJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x687B8D0", Offset = "0x687A4D0", VA = "0x18687B8D0")]
	public static KLACEAHOGOL JFFDBBNDPFF(this HFBKCJFJOFO BLDHJEOEIPM)
	{
		return default(KLACEAHOGOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BOODGANOLPN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DJMBBNLAAIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum PIPFNOJLPFF
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static PIPFNOJLPFF BMNPNPHNKFB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static PIPFNOJLPFF OGOKKFBLECC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D94A20", Offset = "0x1D93620", VA = "0x181D94A20")]
	public static PIPFNOJLPFF DBICEJLBENM(PIPFNOJLPFF BAPLPKMPIOK, PIPFNOJLPFF JNEGEDFKOKG)
	{
		return default(PIPFNOJLPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1D94A30", Offset = "0x1D93630", VA = "0x181D94A30")]
	public static PIPFNOJLPFF MONKHBFKNEA(PIPFNOJLPFF BEFDEMMIKHH, PIPFNOJLPFF HPOGIFNLGMB)
	{
		return default(PIPFNOJLPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x687B720", Offset = "0x687A320", VA = "0x18687B720")]
	public static PIPFNOJLPFF HLIKABDECEH(DJMBBNLAAIL OMPMGJAIENK, PIPFNOJLPFF CIOANBFNAND)
	{
		return default(PIPFNOJLPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x687B6A0", Offset = "0x687A2A0", VA = "0x18687B6A0")]
	public static PIPFNOJLPFF AGJAFNIPLFI(DJMBBNLAAIL OMPMGJAIENK, PIPFNOJLPFF CIOANBFNAND)
	{
		return default(PIPFNOJLPFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x687B6B0", Offset = "0x687A2B0", VA = "0x18687B6B0")]
	public static bool EIHDIJIMHFL(this PIPFNOJLPFF GKNODBIHPEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x687B730", Offset = "0x687A330", VA = "0x18687B730")]
	public static bool MPLHPJKALOM(this PIPFNOJLPFF GKNODBIHPEC)
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
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x687C440", Offset = "0x687B040", VA = "0x18687C440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x687C1B0", Offset = "0x687ADB0", VA = "0x18687C1B0")]
		public void LKIOLNFLEAP(FitMeshHemisphere PGMPPDJECDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x687BDF0", Offset = "0x687A9F0", VA = "0x18687BDF0")]
		public Vector3 KEFCANAECND(Vector2 LLCPDDNFBMB, bool FOFPCDDEEHN = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x687C200", Offset = "0x687AE00", VA = "0x18687C200")]
		public Vector3 PANIDJKHIKO(Vector2 LLCPDDNFBMB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x687BA50", Offset = "0x687A650", VA = "0x18687BA50")]
		public Quaternion CJGICMPJHBN(Vector2 LLCPDDNFBMB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x687BC10", Offset = "0x687A810", VA = "0x18687BC10")]
		public Quaternion CJGICMPJHBN(Vector2 LLCPDDNFBMB, Vector3 OBHMLMAEMAI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x687BD90", Offset = "0x687A990", VA = "0x18687BD90")]
		public Vector2 EPFMIKOMJLI(Vector2 PMMMPFGEHEJ)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x687C390", Offset = "0x687AF90", VA = "0x18687C390")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BNFEBFNEHJB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x687B660", Offset = "0x687A260", VA = "0x18687B660")]
	public static bool NMOCGAMPHPN(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x687B680", Offset = "0x687A280", VA = "0x18687B680")]
	public static bool OFDJBDHBIGH(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x687B5D0", Offset = "0x687A1D0", VA = "0x18687B5D0")]
	public static bool BBHIEFAGKDK(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x687B650", Offset = "0x687A250", VA = "0x18687B650")]
	public static bool LMIPCADNFHG(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x687B640", Offset = "0x687A240", VA = "0x18687B640")]
	public static bool IKMEGPJPFII(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x687B620", Offset = "0x687A220", VA = "0x18687B620")]
	public static bool FJFPDBKEJNI(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x687B5E0", Offset = "0x687A1E0", VA = "0x18687B5E0")]
	public static bool DPLJMGHKFJK(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x687B610", Offset = "0x687A210", VA = "0x18687B610")]
	public static bool EIOIBPDFPLB(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x687B5F0", Offset = "0x687A1F0", VA = "0x18687B5F0")]
	public static bool EEAJHCJBEFH(this OutfitType KDPLNBMOAMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EBFHJEGKMPE : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly EBFHJEGKMPE NKKNEDDGFMP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x687B940", Offset = "0x687A540", VA = "0x18687B940", Slot = "4")]
	public bool Equals(OutfitType FBFEKHOLOCF, OutfitType KJFADDBODKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x687B9A0", Offset = "0x687A5A0", VA = "0x18687B9A0", Slot = "5")]
	public int GetHashCode(OutfitType HGPIKDLKBHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EBFHJEGKMPE()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public NAMGEKDMCNI helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x687A480", Offset = "0x6879080", VA = "0x18687A480")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6879F80", Offset = "0x6878B80", VA = "0x186879F80", Slot = "8")]
		public override bool Equals(AdditionalHatData HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x687A170", Offset = "0x6878D70", VA = "0x18687A170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x687A2D0", Offset = "0x6878ED0", VA = "0x18687A2D0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x687A940", Offset = "0x6879540", VA = "0x18687A940")]
		public static bool PKALALHMOEG(OutfitType HGPIKDLKBHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x687A600", Offset = "0x6879200", VA = "0x18687A600")]
		public static AdditionalOutfitTypeData NCPDNLLGMJA(OutfitType HGPIKDLKBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x687A500", Offset = "0x6879100", VA = "0x18687A500", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData HEIGABGMPLJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x687A590", Offset = "0x6879190", VA = "0x18687A590", Slot = "6")]
		public virtual AdditionalOutfitTypeData LIMAJKMFJNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x401A9E0", Offset = "0x40195E0", VA = "0x18401A9E0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T HEIGABGMPLJ);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, BHGLFBELLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JNFPLAMIGKC beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x933860", Offset = "0x932460", VA = "0x180933860", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public JNFPLAMIGKC PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0", Slot = "10")]
			get
			{
				return default(JNFPLAMIGKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x687B7F0", Offset = "0x687A3F0", VA = "0x18687B7F0", Slot = "8")]
		public override bool Equals(BeardData HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x687B810", Offset = "0x687A410", VA = "0x18687B810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x687B880", Offset = "0x687A480", VA = "0x18687B880")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, BHGLFBELLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public JNFPLAMIGKC hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JGEMJCMHICA helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9CF560", Offset = "0x9CE160", VA = "0x1809CF560", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public JNFPLAMIGKC PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x883F50", Offset = "0x882B50", VA = "0x180883F50", Slot = "10")]
			get
			{
				return default(JNFPLAMIGKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x687C800", Offset = "0x687B400", VA = "0x18687C800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x687C450", Offset = "0x687B050", VA = "0x18687C450", Slot = "8")]
		public override bool Equals(HairData HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x687C640", Offset = "0x687B240", VA = "0x18687C640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x687C740", Offset = "0x687B340", VA = "0x18687C740")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BHGLFBELLDL
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JIFGONJKFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JNFPLAMIGKC GKDENPNJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
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
