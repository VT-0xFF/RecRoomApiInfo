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
public interface PGNLJLGLBIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float LAAMFECKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float BEIKHIDOJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float CCDHLGPGNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float HFAFOLNFCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float HCKOFHFLBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float DKCLMODDOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CLNKBPKDANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NMHFOGBDIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MOLGFDFKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float NHLEKPMMADH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KEPBHAPBOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JDGLFNGOMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float FGFNIBBCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float FGLPEIBJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float JFLKGLGHANK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float JFHIOJBCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 JBALOFACCOG(Vector3 CJPIMOOHIKA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 OIEGLCMJHPA(Vector3 HJJGNAGPLFD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 LOCJFHCMDJH();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : PGNLJLGLBIO
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
			[Cpp2IlInjected.Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBD0A60", Offset = "0xBCF060", VA = "0x180BD0A60", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F7710", Offset = "0x8F5D10", VA = "0x1808F7710", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8F76D0", Offset = "0x8F5CD0", VA = "0x1808F76D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F7700", Offset = "0x8F5D00", VA = "0x1808F7700", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F76E0", Offset = "0x8F5CE0", VA = "0x1808F76E0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8F76C0", Offset = "0x8F5CC0", VA = "0x1808F76C0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x896450", Offset = "0x894A50", VA = "0x180896450", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x68B0B70", Offset = "0x68AF170", VA = "0x1868B0B70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8F7660", Offset = "0x8F5C60", VA = "0x1808F7660", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E80", Offset = "0x8F6480", VA = "0x1808F7E80", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8F7680", Offset = "0x8F5C80", VA = "0x1808F7680", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8F7690", Offset = "0x8F5C90", VA = "0x1808F7690", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8F7D80", Offset = "0x8F6380", VA = "0x1808F7D80", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F7D70", Offset = "0x8F6370", VA = "0x1808F7D70", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68B0B90", Offset = "0x68AF190", VA = "0x1868B0B90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E00", Offset = "0x8F6400", VA = "0x1808F7E00", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E50", Offset = "0x8F6450", VA = "0x1808F7E50", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E30", Offset = "0x8F6430", VA = "0x1808F7E30", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x881AD0", Offset = "0x8800D0", VA = "0x180881AD0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68B0D80", Offset = "0x68AF380", VA = "0x1868B0D80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68B0DC0", Offset = "0x68AF3C0", VA = "0x1868B0DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68B0DA0", Offset = "0x68AF3A0", VA = "0x1868B0DA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68B0DE0", Offset = "0x68AF3E0", VA = "0x1868B0DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68B0CF0", Offset = "0x68AF2F0", VA = "0x1868B0CF0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68B0190", Offset = "0x68AE790", VA = "0x1868B0190")]
		public CMMPCECIIBE DNBJPILIDDA(CMMPCECIIBE FEMNPFKBLCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68B0B90", Offset = "0x68AF190", VA = "0x1868B0B90", Slot = "25")]
		public Vector3 NDGIGOPMAJL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68B0B70", Offset = "0x68AF170", VA = "0x1868B0B70", Slot = "22")]
		public Vector3 LOCJFHCMDJH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B0600", Offset = "0x68AEC00", VA = "0x1868B0600", Slot = "20")]
		public Vector3 JBALOFACCOG(Vector3 CJPIMOOHIKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68B0BB0", Offset = "0x68AF1B0", VA = "0x1868B0BB0", Slot = "21")]
		public Vector3 OIEGLCMJHPA(Vector3 HJJGNAGPLFD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68B0480", Offset = "0x68AEA80", VA = "0x1868B0480", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68B0670", Offset = "0x68AEC70", VA = "0x1868B0670")]
		protected bool JBEDIOCGHIG(AnchorParamsRestrictions BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68B0590", Offset = "0x68AEB90", VA = "0x1868B0590")]
		[CompilerGenerated]
		internal static bool JAHILEAJFJE(float KHKPJFABMKM, float CGBLKAAFCDI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum APKJKFONDPN
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
public enum DBKFDKCGNDL
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IKLOOCOPKBL
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
public enum NPCIOKELEOD
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HGLENNMPBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68B19A0", Offset = "0x68AFFA0", VA = "0x1868B19A0")]
	public static bool AKNIBHJJGKN(this APKJKFONDPN MIAPBMKFKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68B1A20", Offset = "0x68B0020", VA = "0x1868B1A20")]
	public static PGDJCFPPLAG KDGKCFHKOPL(this NPCIOKELEOD FMABGELIPNO)
	{
		return default(PGDJCFPPLAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68B19B0", Offset = "0x68AFFB0", VA = "0x1868B19B0")]
	public static NPCIOKELEOD DDAFEGHPGBH(this PGDJCFPPLAG FMABGELIPNO)
	{
		return default(NPCIOKELEOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MCHDNMDHAEL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum APGECHFHHOI
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
	public enum INMFOKLKEDE
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
	public static INMFOKLKEDE MBOKPGDFLNO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static INMFOKLKEDE LOEONCKHHKK;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA370", Offset = "0x1DD8970", VA = "0x181DDA370")]
	public static INMFOKLKEDE LEAGBGCHEAM(INMFOKLKEDE GPCDLGAAJEO, INMFOKLKEDE GDHDCIODDGJ)
	{
		return default(INMFOKLKEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA360", Offset = "0x1DD8960", VA = "0x181DDA360")]
	public static INMFOKLKEDE BBPGPJHOJOB(INMFOKLKEDE IPFJBMADBFN, INMFOKLKEDE FFEHFKODOAA)
	{
		return default(INMFOKLKEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68B20D0", Offset = "0x68B06D0", VA = "0x1868B20D0")]
	public static INMFOKLKEDE NLPLOFKFDME(APGECHFHHOI JLIBBCJLGGA, INMFOKLKEDE GBPPAPOBFDK)
	{
		return default(INMFOKLKEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68B2050", Offset = "0x68B0650", VA = "0x1868B2050")]
	public static INMFOKLKEDE EIGLDJNOCFL(APGECHFHHOI JLIBBCJLGGA, INMFOKLKEDE GBPPAPOBFDK)
	{
		return default(INMFOKLKEDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68B1FE0", Offset = "0x68B05E0", VA = "0x1868B1FE0")]
	public static bool CKAEIBJGCMM(this INMFOKLKEDE MDJBILBONKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68B2060", Offset = "0x68B0660", VA = "0x1868B2060")]
	public static bool NKNGDPCHCKO(this INMFOKLKEDE MDJBILBONKN)
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
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x68B1990", Offset = "0x68AFF90", VA = "0x1868B1990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68B1000", Offset = "0x68AF600", VA = "0x1868B1000")]
		public void CIJALGAHJKG(FitMeshHemisphere PJALIAAKCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68B1050", Offset = "0x68AF650", VA = "0x1868B1050")]
		public Vector3 MBKHJBHBKDD(Vector2 FALBFJBNPOD, bool BDDMPEBHBPF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68B1410", Offset = "0x68AFA10", VA = "0x1868B1410")]
		public Vector3 MEGHMIGKIHH(Vector2 FALBFJBNPOD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68B15F0", Offset = "0x68AFBF0", VA = "0x1868B15F0")]
		public Quaternion OJGMMEIACOF(Vector2 FALBFJBNPOD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68B1470", Offset = "0x68AFA70", VA = "0x1868B1470")]
		public Quaternion OJGMMEIACOF(Vector2 FALBFJBNPOD, Vector3 IEHFPGPDGNB)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68B0FA0", Offset = "0x68AF5A0", VA = "0x1868B0FA0")]
		public Vector2 ALDMMNPJLCE(Vector2 JGNFEDEALCB)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68B18E0", Offset = "0x68AFEE0", VA = "0x1868B18E0")]
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
public static class BAGKBJAHOEL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E50", Offset = "0x68AF450", VA = "0x1868B0E50")]
	public static bool GIBKBGCCBGA(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E20", Offset = "0x68AF420", VA = "0x1868B0E20")]
	public static bool DBBEPLKGGJM(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68B0EB0", Offset = "0x68AF4B0", VA = "0x1868B0EB0")]
	public static bool NIHFLMCIGEN(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E70", Offset = "0x68AF470", VA = "0x1868B0E70")]
	public static bool JPHFDCBLJEO(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68B0EC0", Offset = "0x68AF4C0", VA = "0x1868B0EC0")]
	public static bool NOGNHLPOAHG(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E00", Offset = "0x68AF400", VA = "0x1868B0E00")]
	public static bool BLANGKKGHPJ(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E40", Offset = "0x68AF440", VA = "0x1868B0E40")]
	public static bool EBEEOPIEDDP(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E80", Offset = "0x68AF480", VA = "0x1868B0E80")]
	public static bool LMLFPAOMELH(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68B0E90", Offset = "0x68AF490", VA = "0x1868B0E90")]
	public static bool MMDOAEPNKIM(this OutfitType MADEALLKNDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JCINMDOCPDI : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly JCINMDOCPDI CFNNMJAMDBB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68B1ED0", Offset = "0x68B04D0", VA = "0x1868B1ED0", Slot = "4")]
	public bool Equals(OutfitType PLJHFOMNMIM, OutfitType HPPGLOJBFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68B1F30", Offset = "0x68B0530", VA = "0x1868B1F30", Slot = "5")]
	public int GetHashCode(OutfitType GOAECDHCJMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JCINMDOCPDI()
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
		public APKJKFONDPN helmetHairMode;

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
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x68AFCB0", Offset = "0x68AE2B0", VA = "0x1868AFCB0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68AF7B0", Offset = "0x68ADDB0", VA = "0x1868AF7B0", Slot = "8")]
		public override bool Equals(AdditionalHatData BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68AF9A0", Offset = "0x68ADFA0", VA = "0x1868AF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68AFB00", Offset = "0x68AE100", VA = "0x1868AFB00")]
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

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68B0100", Offset = "0x68AE700", VA = "0x1868B0100")]
		public static bool KHJHGNNCGKD(OutfitType GOAECDHCJMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68AFD30", Offset = "0x68AE330", VA = "0x1868AFD30")]
		public static AdditionalOutfitTypeData BBHPEKFPBBP(OutfitType GOAECDHCJMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68B0070", Offset = "0x68AE670", VA = "0x1868B0070", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData BHFGHGMPKOJ);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68B0120", Offset = "0x68AE720", VA = "0x1868B0120", Slot = "6")]
		public virtual AdditionalOutfitTypeData KHNFAICPGCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4174B30", Offset = "0x4173130", VA = "0x184174B30", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T BHFGHGMPKOJ);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, IOEOOEKGMKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IKLOOCOPKBL beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x950D30", Offset = "0x94F330", VA = "0x180950D30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IKLOOCOPKBL PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "10")]
			get
			{
				return default(IKLOOCOPKBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68B0ED0", Offset = "0x68AF4D0", VA = "0x1868B0ED0", Slot = "8")]
		public override bool Equals(BeardData BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68B0EF0", Offset = "0x68AF4F0", VA = "0x1868B0EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68B0F60", Offset = "0x68AF560", VA = "0x1868B0F60")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, IOEOOEKGMKJ
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
		public IKLOOCOPKBL hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DBKFDKCGNDL helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9F3430", Offset = "0x9F1A30", VA = "0x1809F3430", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IKLOOCOPKBL PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x884A10", Offset = "0x883010", VA = "0x180884A10", Slot = "10")]
			get
			{
				return default(IKLOOCOPKBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x68B1E40", Offset = "0x68B0440", VA = "0x1868B1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68B1A90", Offset = "0x68B0090", VA = "0x1868B1A90", Slot = "8")]
		public override bool Equals(HairData BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68B1C80", Offset = "0x68B0280", VA = "0x1868B1C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68B1D80", Offset = "0x68B0380", VA = "0x1868B1D80")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IOEOOEKGMKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool ONCDGOKKIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IKLOOCOPKBL ICBCMEPLCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
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
