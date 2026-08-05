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
public interface DAPDOCKEFFF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float OOPOLHNCAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float CKGAADBOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float BGLAEKKAFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float EADBHNAGOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float NCJFAAEFJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float AGICDFDBCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float ALCFMEEFAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BBKGIBPBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float EPEKDFHODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float AHBJAEGEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DJPIOFLOJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float CKFKMLIGDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float PFIJKKOAFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float OCDGGLBEFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float LHEJLHLJPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CIPMHPCOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 HPNOPJEJKDL(Vector3 LLGPPANDACN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 BHAELIFLMOG(Vector3 HCGOFMONLKB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 PLFBNCMNCPI();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : DAPDOCKEFFF
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
			[Cpp2IlInjected.Address(RVA = "0x913F50", Offset = "0x912950", VA = "0x180913F50", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDBE7C0", Offset = "0xDBD1C0", VA = "0x180DBE7C0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9B3E20", Offset = "0x9B2820", VA = "0x1809B3E20", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAF17E0", Offset = "0xAF01E0", VA = "0x180AF17E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0A0", Offset = "0xAAAAA0", VA = "0x180AAC0A0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DB0", Offset = "0x9B57B0", VA = "0x1809B6DB0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9982B0", Offset = "0x996CB0", VA = "0x1809982B0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B34D0", Offset = "0x8B1ED0", VA = "0x1808B34D0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B770", Offset = "0x6A3A170", VA = "0x186A3B770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B910", Offset = "0x6A3A310", VA = "0x186A3B910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B8F0", Offset = "0x6A3A2F0", VA = "0x186A3B8F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAF17B0", Offset = "0xAF01B0", VA = "0x180AF17B0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAAC020", Offset = "0xAAAA20", VA = "0x180AAC020", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D90", Offset = "0x9B5790", VA = "0x1809B6D90", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0C0", Offset = "0xAAAAC0", VA = "0x180AAC0C0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x98B4C0", Offset = "0x989EC0", VA = "0x18098B4C0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAFA6E0", Offset = "0xAF90E0", VA = "0x180AFA6E0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B390", Offset = "0x6A39D90", VA = "0x186A3B390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B930", Offset = "0x6A3A330", VA = "0x186A3B930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B8D0", Offset = "0x6A3A2D0", VA = "0x186A3B8D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAFA750", Offset = "0xAF9150", VA = "0x180AFA750", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAFA780", Offset = "0xAF9180", VA = "0x180AFA780", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAFA770", Offset = "0xAF9170", VA = "0x180AFA770", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x89F3B0", Offset = "0x89DDB0", VA = "0x18089F3B0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B950", Offset = "0x6A3A350", VA = "0x186A3B950")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B990", Offset = "0x6A3A390", VA = "0x186A3B990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B970", Offset = "0x6A3A370", VA = "0x186A3B970")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B9B0", Offset = "0x6A3A3B0", VA = "0x186A3B9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B840", Offset = "0x6A3A240", VA = "0x186A3B840")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B490", Offset = "0x6A39E90", VA = "0x186A3B490")]
		public EAKAJADPDPK LBEHMGKOIOA(EAKAJADPDPK DFOADNICANC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B390", Offset = "0x6A39D90", VA = "0x186A3B390", Slot = "25")]
		public Vector3 HGHBJCECNHM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B770", Offset = "0x6A3A170", VA = "0x186A3B770", Slot = "22")]
		public Vector3 PLFBNCMNCPI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B3B0", Offset = "0x6A39DB0", VA = "0x186A3B3B0", Slot = "20")]
		public Vector3 HPNOPJEJKDL(Vector3 LLGPPANDACN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B200", Offset = "0x6A39C00", VA = "0x186A3B200", Slot = "21")]
		public Vector3 BHAELIFLMOG(Vector3 HCGOFMONLKB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B280", Offset = "0x6A39C80", VA = "0x186A3B280", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AD00", Offset = "0x6A39700", VA = "0x186A3AD00")]
		protected bool ADHKKHFADKK(AnchorParamsRestrictions CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B420", Offset = "0x6A39E20", VA = "0x186A3B420")]
		[CompilerGenerated]
		internal static bool JCBJFNMLMJN(float KPNKONMDFPM, float NGNLLOFPDHF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum HelmetHairMode
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
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HairPatternStyle
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
	public enum AvatarItemBodyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		BeanBody,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		FullBody,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		ModernBeanBody
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OOEMKDLBLBN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C960", Offset = "0x6A3B360", VA = "0x186A3C960")]
	public static bool JGJGFBOHHOM(this HelmetHairMode MPHHMGHCGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C970", Offset = "0x6A3B370", VA = "0x186A3C970")]
	public static KPAFIKBMJHO KFMHBOHGHBC(this AvatarItemBodyType LFKFAPGJDMI)
	{
		return default(KPAFIKBMJHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C9F0", Offset = "0x6A3B3F0", VA = "0x186A3C9F0")]
	public static AvatarItemBodyType KLBHKOPNOEG(this KPAFIKBMJHO LFKFAPGJDMI)
	{
		return default(AvatarItemBodyType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PCNNDLGLKGM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MDNDIFFPBGD
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
	public enum MLOLFLCAEKK
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
	public static MLOLFLCAEKK DNIMNBFGHFB;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MLOLFLCAEKK LIACHPBKNDK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB00", Offset = "0x6A3B500", VA = "0x186A3CB00")]
	public static MLOLFLCAEKK JPGIAGMIEIE(MLOLFLCAEKK DGDBCIAFMJG, MLOLFLCAEKK JBBFIKOJEAB)
	{
		return default(MLOLFLCAEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CAF0", Offset = "0x6A3B4F0", VA = "0x186A3CAF0")]
	public static MLOLFLCAEKK HLCGJGHNKDL(MLOLFLCAEKK LAINPDFNMBB, MLOLFLCAEKK EBFKKPJIBOD)
	{
		return default(MLOLFLCAEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CA70", Offset = "0x6A3B470", VA = "0x186A3CA70")]
	public static MLOLFLCAEKK AACFOMLNPOF(MDNDIFFPBGD KPDINHKFGMK, MLOLFLCAEKK LOOMGKIKPJB)
	{
		return default(MLOLFLCAEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB10", Offset = "0x6A3B510", VA = "0x186A3CB10")]
	public static MLOLFLCAEKK MGLAFFILJEI(MDNDIFFPBGD KPDINHKFGMK, MLOLFLCAEKK LOOMGKIKPJB)
	{
		return default(MLOLFLCAEKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CA80", Offset = "0x6A3B480", VA = "0x186A3CA80")]
	public static bool CJPKHHEKAAO(this MLOLFLCAEKK JOMGKFCDPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB20", Offset = "0x6A3B520", VA = "0x186A3CB20")]
	public static bool NGEKHCCIIHJ(this MLOLFLCAEKK JOMGKFCDPME)
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

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C430", Offset = "0x6A3AE30", VA = "0x186A3C430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C220", Offset = "0x6A3AC20", VA = "0x186A3C220")]
		public void ODCGKEAPJFP(FitMeshHemisphere MMCOHMDJFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BE70", Offset = "0x6A3A870", VA = "0x186A3BE70")]
		public Vector3 LIJBJFIIAFJ(Vector2 NHPMHGOACNK, bool OJKOHILMEHM = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BE10", Offset = "0x6A3A810", VA = "0x186A3BE10")]
		public Vector3 HHIJALDNHKK(Vector2 NHPMHGOACNK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BAA0", Offset = "0x6A3A4A0", VA = "0x186A3BAA0")]
		public Quaternion FBMEOPEGADA(Vector2 NHPMHGOACNK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BC50", Offset = "0x6A3A650", VA = "0x186A3BC50")]
		public Quaternion FBMEOPEGADA(Vector2 NHPMHGOACNK, Vector3 BKHMOODGJAD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BDC0", Offset = "0x6A3A7C0", VA = "0x186A3BDC0")]
		public Vector2 HAGKLPODELK(Vector2 ODOCABHGPGB)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C390", Offset = "0x6A3AD90", VA = "0x186A3C390")]
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
public static class MAMOGDHKAGC
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C940", Offset = "0x6A3B340", VA = "0x186A3C940")]
	public static bool PMLNJKDHBHP(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8E0", Offset = "0x6A3B2E0", VA = "0x186A3C8E0")]
	public static bool EOKIELCNCKK(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C880", Offset = "0x6A3B280", VA = "0x186A3C880")]
	public static bool BAENJMHKEFL(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C930", Offset = "0x6A3B330", VA = "0x186A3C930")]
	public static bool NEGPNAOOPHP(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C900", Offset = "0x6A3B300", VA = "0x186A3C900")]
	public static bool LCFBGINIHOK(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C890", Offset = "0x6A3B290", VA = "0x186A3C890")]
	public static bool DMCFMHCGENK(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8C0", Offset = "0x6A3B2C0", VA = "0x186A3C8C0")]
	public static bool EMHJDBLEHJN(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8D0", Offset = "0x6A3B2D0", VA = "0x186A3C8D0")]
	public static bool ENPIDCPBCAO(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C910", Offset = "0x6A3B310", VA = "0x186A3C910")]
	public static bool LIKDLHGDMMA(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8B0", Offset = "0x6A3B2B0", VA = "0x186A3C8B0")]
	public static bool DMJNDKPKNIF(this OutfitType EDBDBBPEKDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ANNMPMFOAJK : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly ANNMPMFOAJK GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A230", Offset = "0x6A38C30", VA = "0x186A3A230", Slot = "4")]
	public bool Equals(OutfitType LHDGLJFBJOG, OutfitType DOENIJIEODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A290", Offset = "0x6A38C90", VA = "0x186A3A290", Slot = "5")]
	public int GetHashCode(OutfitType AOGCIMANLIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public ANNMPMFOAJK()
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
		public HelmetHairMode helmetHairMode;

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

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6A3A820", Offset = "0x6A39220", VA = "0x186A3A820")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A330", Offset = "0x6A38D30", VA = "0x186A3A330", Slot = "8")]
		public override bool Equals(AdditionalHatData CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A520", Offset = "0x6A38F20", VA = "0x186A3A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A680", Offset = "0x6A39080", VA = "0x186A3A680")]
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

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6A3ACE0", Offset = "0x6A396E0", VA = "0x186A3ACE0")]
		public static bool IHLPNFOMLHF(OutfitType AOGCIMANLIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A8A0", Offset = "0x6A392A0", VA = "0x186A3A8A0")]
		public static AdditionalOutfitTypeData EMJKOLAJLFI(OutfitType AOGCIMANLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A3ABD0", Offset = "0x6A395D0", VA = "0x186A3ABD0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData CGCLEIBHLHF);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A3AC60", Offset = "0x6A39660", VA = "0x186A3AC60", Slot = "6")]
		public virtual AdditionalOutfitTypeData HNCMOJOADMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x436D920", Offset = "0x436C320", VA = "0x18436D920", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T CGCLEIBHLHF);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, AMOHMGEMBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB6AD30", Offset = "0xB69730", VA = "0x180B6AD30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B9D0", Offset = "0x6A3A3D0", VA = "0x186A3B9D0", Slot = "8")]
		public override bool Equals(BeardData CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B9F0", Offset = "0x6A3A3F0", VA = "0x186A3B9F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BA60", Offset = "0x6A3A460", VA = "0x186A3BA60")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class HairData : AdditionalOutfitTypeData<HairData>, AMOHMGEMBMD
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
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9084C0", Offset = "0x906EC0", VA = "0x1809084C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8A2150", Offset = "0x8A0B50", VA = "0x1808A2150", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6A3C7F0", Offset = "0x6A3B1F0", VA = "0x186A3C7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C440", Offset = "0x6A3AE40", VA = "0x186A3C440", Slot = "8")]
		public override bool Equals(HairData CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C630", Offset = "0x6A3B030", VA = "0x186A3C630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C730", Offset = "0x6A3B130", VA = "0x186A3C730")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AMOHMGEMBMD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool LMGMHJLGGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HairPatternStyle APBCBFPBCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
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
