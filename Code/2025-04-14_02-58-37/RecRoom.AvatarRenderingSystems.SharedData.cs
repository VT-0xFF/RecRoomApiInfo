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
public interface DNNONBHLEHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float HEBOMJGDENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float HMIDOPKJLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float FMEOCGNEGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float ANNLIBHMDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float AJFEPPKMFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float JPDHBIHNMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BOCBGCHGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float NMNAEANNIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NGIANOHGCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float ABENBGKBLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DEEDCKOFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float OFJDIFJMGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GLGHKMCJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DHLDPMKDEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float HNMHDKHHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PPJFNCEGDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 EPOEHLHNCEA(Vector3 HFMGFDPLEDO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 EHFBOLCPFDB(Vector3 DGPMOKPNLHN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 DKBGMGODFNP();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : DNNONBHLEHK
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
			[Cpp2IlInjected.Address(RVA = "0xBFFB90", Offset = "0xBFE590", VA = "0x180BFFB90", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBFFCE0", Offset = "0xBFE6E0", VA = "0x180BFFCE0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE5FD30", Offset = "0xE5E730", VA = "0x180E5FD30", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCB3DA0", Offset = "0xCB27A0", VA = "0x180CB3DA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xF8EF60", Offset = "0xF8D960", VA = "0x180F8EF60", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE86E80", Offset = "0xE85880", VA = "0x180E86E80", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB65740", Offset = "0xB64140", VA = "0x180B65740", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9DD5A0", Offset = "0x9DBFA0", VA = "0x1809DD5A0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x778DBA0", Offset = "0x778C5A0", VA = "0x18778DBA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x778EAB0", Offset = "0x778D4B0", VA = "0x18778EAB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x778EA90", Offset = "0x778D490", VA = "0x18778EA90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x10062C0", Offset = "0x1004CC0", VA = "0x1810062C0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF8EF00", Offset = "0xF8D900", VA = "0x180F8EF00", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB917C0", Offset = "0xB901C0", VA = "0x180B917C0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB917B0", Offset = "0xB901B0", VA = "0x180B917B0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE51820", Offset = "0xE50220", VA = "0x180E51820", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x10069A0", Offset = "0x10053A0", VA = "0x1810069A0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x778E910", Offset = "0x778D310", VA = "0x18778E910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x778EAD0", Offset = "0x778D4D0", VA = "0x18778EAD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x778EA70", Offset = "0x778D470", VA = "0x18778EA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x10069E0", Offset = "0x10053E0", VA = "0x1810069E0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBFF930", Offset = "0xBFE330", VA = "0x180BFF930", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBA0", Offset = "0xBFE5A0", VA = "0x180BFFBA0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9C87C0", Offset = "0x9C71C0", VA = "0x1809C87C0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x778EAF0", Offset = "0x778D4F0", VA = "0x18778EAF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x778EB30", Offset = "0x778D530", VA = "0x18778EB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x778EB10", Offset = "0x778D510", VA = "0x18778EB10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x778EB50", Offset = "0x778D550", VA = "0x18778EB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x778E9E0", Offset = "0x778D3E0", VA = "0x18778E9E0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x778E630", Offset = "0x778D030", VA = "0x18778E630")]
		public CMIMFAFIAGN JBPNAFDFEFF(CMIMFAFIAGN FJPGJKKOFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x778E910", Offset = "0x778D310", VA = "0x18778E910", Slot = "25")]
		public Vector3 PEBEFONDPKG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x778DBA0", Offset = "0x778C5A0", VA = "0x18778DBA0", Slot = "22")]
		public Vector3 DKBGMGODFNP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x778DC40", Offset = "0x778C640", VA = "0x18778DC40", Slot = "20")]
		public Vector3 EPOEHLHNCEA(Vector3 HFMGFDPLEDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x778DBC0", Offset = "0x778C5C0", VA = "0x18778DBC0", Slot = "21")]
		public Vector3 EHFBOLCPFDB(Vector3 DGPMOKPNLHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x778DCB0", Offset = "0x778C6B0", VA = "0x18778DCB0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x778E0C0", Offset = "0x778CAC0", VA = "0x18778E0C0")]
		protected bool HCIIELMKAJD(AnchorParamsRestrictions OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x778DDC0", Offset = "0x778C7C0", VA = "0x18778DDC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x778E5C0", Offset = "0x778CFC0", VA = "0x18778E5C0")]
		[CompilerGenerated]
		internal static bool IJOEDKMKHOE(float KEEADJCBJCP, float LKKBJAKGIGL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NCIMPBNKAAB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x150F760", Offset = "0x150E160", VA = "0x18150F760")]
	public static bool BCNBLMHLNAH(this NMDLGPPCNIO CPKHDNICNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7790FB0", Offset = "0x778F9B0", VA = "0x187790FB0")]
	public static bool NOBHKALOCMJ(this NMDLGPPCNIO CPKHDNICNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7790F90", Offset = "0x778F990", VA = "0x187790F90")]
	public static bool IDKJIGMLEFE(this NMDLGPPCNIO CPKHDNICNAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCDIGJHKFHO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool BHLAEBNOENI;
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
public static class DMFLOLHDMND
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x778EE20", Offset = "0x778D820", VA = "0x18778EE20")]
	public static bool KHEMCFBOLND(this HelmetHairMode GECCIBJCEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x778ECE0", Offset = "0x778D6E0", VA = "0x18778ECE0")]
	public static PLCLOJBLHOK BNKEHFNIKJD(this AvatarItemBodyType JJHAMINNBAP)
	{
		return default(PLCLOJBLHOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x778EE30", Offset = "0x778D830", VA = "0x18778EE30")]
	public static AvatarItemBodyType LKEPMIMFPMA(this PLCLOJBLHOK JJHAMINNBAP)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x778ED60", Offset = "0x778D760", VA = "0x18778ED60")]
	public static string HCACFIBJMBM(this AvatarItemBodyType JJHAMINNBAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MGEOINLEJDO
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7790540", Offset = "0x778EF40", VA = "0x187790540")]
	public static void LNKFNACMGGB(Transform GMFDPAMENFD, Transform LDOLEEOGPOO, Transform NICCLILOCLB, Transform LDGFLGFKJKG, float GPILPILCPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FHMIHNFONJP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum KEGCBHNIHEF
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
	public enum FMPAHPDMJAC : long
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
	public static readonly IReadOnlyList<KEGCBHNIHEF> CLDFFNGOPHA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<KEGCBHNIHEF> PIBMDNBFCMP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<KEGCBHNIHEF> HEGGNLJFLAE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly FMPAHPDMJAC FHDFANBABFK;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly FMPAHPDMJAC DCNCGPBMIIM;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly FMPAHPDMJAC HDAMKPNIGBB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x778EEB0", Offset = "0x778D8B0", VA = "0x18778EEB0")]
	public static FMPAHPDMJAC HCNMMJLJHOM(FMPAHPDMJAC BBMFIIOILIF, FMPAHPDMJAC IKFDLBBIOME)
	{
		return default(FMPAHPDMJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x778EEC0", Offset = "0x778D8C0", VA = "0x18778EEC0")]
	public static FMPAHPDMJAC HDEDILGCLPC(FMPAHPDMJAC ACJHCEFBKAO, FMPAHPDMJAC IHKMGBIIEKP)
	{
		return default(FMPAHPDMJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x778EED0", Offset = "0x778D8D0", VA = "0x18778EED0")]
	public static FMPAHPDMJAC NPFCPKAAAJP(KEGCBHNIHEF GACLBELDBCG, FMPAHPDMJAC AOPKDIBIKNH)
	{
		return default(FMPAHPDMJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x778EEE0", Offset = "0x778D8E0", VA = "0x18778EEE0")]
	public static FMPAHPDMJAC PCMBGNIOOLA(KEGCBHNIHEF GACLBELDBCG, FMPAHPDMJAC AOPKDIBIKNH)
	{
		return default(FMPAHPDMJAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KKFBIHIEIPA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LIPEPNOCILI : short
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
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x778FC10", Offset = "0x778E610", VA = "0x18778FC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x778FA00", Offset = "0x778E400", VA = "0x18778FA00")]
		public void PJJMOHHGFMI(FitMeshHemisphere BDAPKPKMDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x778F150", Offset = "0x778DB50", VA = "0x18778F150")]
		public Vector3 BOIOCMBGIBD(Vector2 NBALHHGCFMD, bool HCEANHONGJB = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x778F9A0", Offset = "0x778E3A0", VA = "0x18778F9A0")]
		public Vector3 KMHPBAILGJB(Vector2 NBALHHGCFMD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x778F7F0", Offset = "0x778E1F0", VA = "0x18778F7F0")]
		public Quaternion IKPEKHMILAG(Vector2 NBALHHGCFMD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x778F680", Offset = "0x778E080", VA = "0x18778F680")]
		public Quaternion IKPEKHMILAG(Vector2 NBALHHGCFMD, Vector3 KOHEHODBCFH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x778F630", Offset = "0x778E030", VA = "0x18778F630")]
		public Vector2 COOJJMBJJPB(Vector2 ODMHGEIGCON)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x778FB70", Offset = "0x778E570", VA = "0x18778FB70")]
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
public static class FIJFDPLJJHM
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x778F0D0", Offset = "0x778DAD0", VA = "0x18778F0D0")]
	public static bool INHHMENELFJ(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x778F070", Offset = "0x778DA70", VA = "0x18778F070")]
	public static bool AAEONODFPJH(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x778F0C0", Offset = "0x778DAC0", VA = "0x18778F0C0")]
	public static bool IIALIKCMHJG(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x778F130", Offset = "0x778DB30", VA = "0x18778F130")]
	public static bool PIMPKDHOKEA(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x778F100", Offset = "0x778DB00", VA = "0x18778F100")]
	public static bool KPOGKFMHCDC(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x778F110", Offset = "0x778DB10", VA = "0x18778F110")]
	public static bool OGDDPDFNNAH(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x778F0B0", Offset = "0x778DAB0", VA = "0x18778F0B0")]
	public static bool EOHBMCJPOIH(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x778F0F0", Offset = "0x778DAF0", VA = "0x18778F0F0")]
	public static bool JMHNEJMMJNC(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x778F090", Offset = "0x778DA90", VA = "0x18778F090")]
	public static bool DEBILEBPNBF(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x778F140", Offset = "0x778DB40", VA = "0x18778F140")]
	public static bool PMIBOOMDPNI(this OutfitType EPLOECKHAMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MOKFOHEIOAM : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly MOKFOHEIOAM LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7790E90", Offset = "0x778F890", VA = "0x187790E90", Slot = "4")]
	public bool Equals(OutfitType BFHCGFIOHGE, OutfitType FLECCEKLGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7790EF0", Offset = "0x778F8F0", VA = "0x187790EF0", Slot = "5")]
	public int GetHashCode(OutfitType OHCGINPDMEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MOKFOHEIOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CMHGCJDKOOB
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
public enum DNCNOGCFLJF
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum POBPEMENNMH
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
public enum DFOGOECIEPI
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
public enum LMGHJFPJPAJ
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
public enum FPNKNMOGAJG
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

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x778D0D0", Offset = "0x778BAD0", VA = "0x18778D0D0", Slot = "7")]
		public override bool Equals(AdditionalFeetData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x778D100", Offset = "0x778BB00", VA = "0x18778D100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x778D180", Offset = "0x778BB80", VA = "0x18778D180")]
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
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x778D6B0", Offset = "0x778C0B0", VA = "0x18778D6B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x778D1C0", Offset = "0x778BBC0", VA = "0x18778D1C0", Slot = "7")]
		public override bool Equals(AdditionalHatData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x778D3B0", Offset = "0x778BDB0", VA = "0x18778D3B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x778D510", Offset = "0x778BF10", VA = "0x18778D510")]
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

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x778D7C0", Offset = "0x778C1C0", VA = "0x18778D7C0")]
		public static bool FPACBPCNCDM(OutfitType OHCGINPDMEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x778D7F0", Offset = "0x778C1F0", VA = "0x18778D7F0")]
		public static AdditionalOutfitTypeData IDEDHGEBOCJ(OutfitType OHCGINPDMEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x778D730", Offset = "0x778C130", VA = "0x18778D730", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData OLKLGHOAKNE);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5202490", Offset = "0x5200E90", VA = "0x185202490", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T OLKLGHOAKNE);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, IBGNNDMACKC
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
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1064160", Offset = "0x1062B60", VA = "0x181064160", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x778EB70", Offset = "0x778D570", VA = "0x18778EB70", Slot = "7")]
		public override bool Equals(BeardData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x778EB90", Offset = "0x778D590", VA = "0x18778EB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x778EC00", Offset = "0x778D600", VA = "0x18778EC00")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, IBGNNDMACKC
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
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBAD060", Offset = "0xBABA60", VA = "0x180BAD060", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9CB670", Offset = "0x9CA070", VA = "0x1809CB670", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCA3DD0", Offset = "0xCA27D0", VA = "0x180CA3DD0")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x77904B0", Offset = "0x778EEB0", VA = "0x1877904B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7790100", Offset = "0x778EB00", VA = "0x187790100", Slot = "7")]
		public override bool Equals(HairData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x77902F0", Offset = "0x778ECF0", VA = "0x1877902F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77903F0", Offset = "0x778EDF0", VA = "0x1877903F0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IBGNNDMACKC
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool GDOKACJNEFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle PLMCJBDHHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NKDJOHKDHAB
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7791080", Offset = "0x778FA80", VA = "0x187791080")]
	public static NMDLGPPCNIO MEFLIIBNMKO(this OutfitType EPLOECKHAMG, AvatarItemSidednessEquipType HDMAJCDEDLE = AvatarItemSidednessEquipType.Left)
	{
		return default(NMDLGPPCNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7791030", Offset = "0x778FA30", VA = "0x187791030")]
	public static NMDLGPPCNIO HDOFCBACDNE(this NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(NMDLGPPCNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7790FC0", Offset = "0x778F9C0", VA = "0x187790FC0")]
	public static bool GBIEDKPJJFD(this OutfitType EPLOECKHAMG, NMDLGPPCNIO NLOPOEHCFJO)
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
public static class DFGGHLLIHDL
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x778ECB0", Offset = "0x778D6B0", VA = "0x18778ECB0")]
	public static bool OPDOMDEDLLL(this AvatarItemSidednessEquipType HDMAJCDEDLE, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x778EC80", Offset = "0x778D680", VA = "0x18778EC80")]
	public static bool NHEEOHGBAAJ(this AvatarItemSidednessEquipType OFAHNENFDKL, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x778EC60", Offset = "0x778D660", VA = "0x18778EC60")]
	public static bool GFGAIIJJOHH(this AvatarItemSidednessEquipType EMELFFCMMFC, AvatarItemSidednessEquipType FFLNOEDFMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x778EC40", Offset = "0x778D640", VA = "0x18778EC40")]
	public static AvatarItemSidednessEquipType EFPCMGLIOLK(this AvatarItemSidednessEquipType EMELFFCMMFC)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum CJAKIGOEGNJ
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
public static class GOABBCDHIFC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x778FC20", Offset = "0x778E620", VA = "0x18778FC20")]
	private static CJAKIGOEGNJ DHJJJIJPBKF(this OutfitType EPLOECKHAMG)
	{
		return default(CJAKIGOEGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x778FF90", Offset = "0x778E990", VA = "0x18778FF90")]
	public static OutfitSlotFlags MKPBFCDDOBJ(this OutfitType EPLOECKHAMG)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x778FD90", Offset = "0x778E790", VA = "0x18778FD90")]
	public static bool GCBPLLAGLBM(this OutfitSlotFlags COHPGFNFOGJ, OutfitSlotFlags LALBGNFABIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x778FDA0", Offset = "0x778E7A0", VA = "0x18778FDA0")]
	public static bool HILLCLCIOEE(this OutfitType EPLOECKHAMG, OutfitSlotFlags AJNMHFGPFGA)
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
