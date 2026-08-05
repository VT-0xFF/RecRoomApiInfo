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
public interface KOJPDNMMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float FDICJEEABPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float MOOGPIHBGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float EHNPBBLJGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float LJJGJBADPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float OPKHBCGBHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float OHEOBFNFGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GPJPKGPIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float LJAFEJGEDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float GPDOMHAHHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float OCAKAHCNHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float CDNDJNMIOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float EHHFCNFMDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OKAKCDHHKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DLMCLACCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float FLNANJOJGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float KLLFAKPKIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 JMKHGGOCGHK(Vector3 JIEAKCOOOOC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 NPIINNDDOJG(Vector3 DAPCLCEFKMB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 LFKILGGJGDC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : KOJPDNMMOFJ
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
			[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD4B480", Offset = "0xD4A080", VA = "0x180D4B480", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x918F20", Offset = "0x917B20", VA = "0x180918F20", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA622D0", Offset = "0xA60ED0", VA = "0x180A622D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA22430", Offset = "0xA21030", VA = "0x180A22430", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x91A540", Offset = "0x919140", VA = "0x18091A540", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8F8520", Offset = "0x8F7120", VA = "0x1808F8520", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B83C0", Offset = "0x8B6FC0", VA = "0x1808B83C0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6ADECF0", Offset = "0x6ADD8F0", VA = "0x186ADECF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEF10", Offset = "0x6ADDB10", VA = "0x186ADEF10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEEF0", Offset = "0x6ADDAF0", VA = "0x186ADEEF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA622A0", Offset = "0xA60EA0", VA = "0x180A622A0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20FA0", VA = "0x180A223A0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x91A520", Offset = "0x919120", VA = "0x18091A520", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA22450", Offset = "0xA21050", VA = "0x180A22450", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8F45D0", Offset = "0x8F31D0", VA = "0x1808F45D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA62920", Offset = "0xA61520", VA = "0x180A62920", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6ADE2E0", Offset = "0x6ADCEE0", VA = "0x186ADE2E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEF30", Offset = "0x6ADDB30", VA = "0x186ADEF30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEED0", Offset = "0x6ADDAD0", VA = "0x186ADEED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA62990", Offset = "0xA61590", VA = "0x180A62990", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA629D0", Offset = "0xA615D0", VA = "0x180A629D0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA629C0", Offset = "0xA615C0", VA = "0x180A629C0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8A3700", Offset = "0x8A2300", VA = "0x1808A3700", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEF50", Offset = "0x6ADDB50", VA = "0x186ADEF50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEF90", Offset = "0x6ADDB90", VA = "0x186ADEF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEF70", Offset = "0x6ADDB70", VA = "0x186ADEF70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6ADEFB0", Offset = "0x6ADDBB0", VA = "0x186ADEFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEE40", Offset = "0x6ADDA40", VA = "0x186ADEE40")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE000", Offset = "0x6ADCC00", VA = "0x186ADE000")]
		public KLLNLHCALDO AAPAGNGDICO(KLLNLHCALDO ENDMEEFKEPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE2E0", Offset = "0x6ADCEE0", VA = "0x186ADE2E0", Slot = "25")]
		public Vector3 EPIKONCPNNN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ADECF0", Offset = "0x6ADD8F0", VA = "0x186ADECF0", Slot = "22")]
		public Vector3 LFKILGGJGDC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC80", Offset = "0x6ADD880", VA = "0x186ADEC80", Slot = "20")]
		public Vector3 JMKHGGOCGHK(Vector3 JIEAKCOOOOC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6ADED10", Offset = "0x6ADD910", VA = "0x186ADED10", Slot = "21")]
		public Vector3 NPIINNDDOJG(Vector3 DAPCLCEFKMB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE300", Offset = "0x6ADCF00", VA = "0x186ADE300", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE710", Offset = "0x6ADD310", VA = "0x186ADE710")]
		protected bool HELLGNHACPM(AnchorParamsRestrictions FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE410", Offset = "0x6ADD010", VA = "0x186ADE410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC10", Offset = "0x6ADD810", VA = "0x186ADEC10")]
		[CompilerGenerated]
		internal static bool HJAJCLCJMIH(float ALHLFNOAFIL, float AFHCIMLJCHF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PLKGDOKFLBB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xF8C8D0", Offset = "0xF8B4D0", VA = "0x180F8C8D0")]
	public static bool KNHEMPBENCJ(this BCGODMJDFFO HHDNICBCKMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0A50", Offset = "0x6ADF650", VA = "0x186AE0A50")]
	public static bool CMKFBPJKHME(this BCGODMJDFFO HHDNICBCKMO)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OBJJFFNEHGH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0860", Offset = "0x6ADF460", VA = "0x186AE0860")]
	public static bool DLJJFHDLLHM(this HelmetHairMode PJGDBFBDLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE07E0", Offset = "0x6ADF3E0", VA = "0x186AE07E0")]
	public static CAJNNHABANH DGPLKANEFBK(this AvatarItemBodyType GAHDPPDCPDD)
	{
		return default(CAJNNHABANH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0870", Offset = "0x6ADF470", VA = "0x186AE0870")]
	public static AvatarItemBodyType FFKKNONEABO(this CAJNNHABANH GAHDPPDCPDD)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6AE08F0", Offset = "0x6ADF4F0", VA = "0x186AE08F0")]
	public static string IHEAHNKPMJE(this AvatarItemBodyType GAHDPPDCPDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HDFJPOEIMPO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum KOMHGDGNNBC
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

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum CLDPEDONPKD
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
	public static CLDPEDONPKD FIHKMBKEFMP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static CLDPEDONPKD PMMDKOJHLGH;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0240", Offset = "0x6ADEE40", VA = "0x186AE0240")]
	public static CLDPEDONPKD IDOMPIJEBCO(CLDPEDONPKD LICABLFJFOF, CLDPEDONPKD ICHLBMACDJB)
	{
		return default(CLDPEDONPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AE01C0", Offset = "0x6ADEDC0", VA = "0x186AE01C0")]
	public static CLDPEDONPKD CKHMJLBLAPE(CLDPEDONPKD BDEANIOEPDO, CLDPEDONPKD KPMLHIEDPKO)
	{
		return default(CLDPEDONPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0260", Offset = "0x6ADEE60", VA = "0x186AE0260")]
	public static CLDPEDONPKD LLBPDLJIIIJ(KOMHGDGNNBC GIOHOGIACPN, CLDPEDONPKD DACFNKKDEHM)
	{
		return default(CLDPEDONPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0250", Offset = "0x6ADEE50", VA = "0x186AE0250")]
	public static CLDPEDONPKD IMMBPNENFLM(KOMHGDGNNBC GIOHOGIACPN, CLDPEDONPKD DACFNKKDEHM)
	{
		return default(CLDPEDONPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AE01D0", Offset = "0x6ADEDD0", VA = "0x186AE01D0")]
	public static bool FLDADJDNFGD(this CLDPEDONPKD MNHCNOIDDHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0150", Offset = "0x6ADED50", VA = "0x186AE0150")]
	public static bool CKEBEHKFAKJ(this CLDPEDONPKD MNHCNOIDDHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GLFIAOJIINM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum PDFEAIHGAJJ : short
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6AE0040", Offset = "0x6ADEC40", VA = "0x186AE0040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFB10", Offset = "0x6ADE710", VA = "0x186ADFB10")]
		public void JHOOAEEEKAK(FitMeshHemisphere GDJEPDNHBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF580", Offset = "0x6ADE180", VA = "0x186ADF580")]
		public Vector3 AEMPGHGLIGE(Vector2 KMGPBBKFCMA, bool CDOPKJPLJHD = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFAB0", Offset = "0x6ADE6B0", VA = "0x186ADFAB0")]
		public Vector3 DJMOPGKBDFB(Vector2 KMGPBBKFCMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFB60", Offset = "0x6ADE760", VA = "0x186ADFB60")]
		public Quaternion POLPOLJOLFH(Vector2 KMGPBBKFCMA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFD10", Offset = "0x6ADE910", VA = "0x186ADFD10")]
		public Quaternion POLPOLJOLFH(Vector2 KMGPBBKFCMA, Vector3 CBMEFKKJMFO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFA60", Offset = "0x6ADE660", VA = "0x186ADFA60")]
		public Vector2 CGGGKBHNFOC(Vector2 OPHOGBEFGCL)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADFFA0", Offset = "0x6ADEBA0", VA = "0x186ADFFA0")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KFICADDMGFB
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0770", Offset = "0x6ADF370", VA = "0x186AE0770")]
	public static bool KHKOBCGJLFP(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0700", Offset = "0x6ADF300", VA = "0x186AE0700")]
	public static bool AJOPKHDEDDJ(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0730", Offset = "0x6ADF330", VA = "0x186AE0730")]
	public static bool CDOMEFNNJHC(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0740", Offset = "0x6ADF340", VA = "0x186AE0740")]
	public static bool FFABBPLLNDO(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0720", Offset = "0x6ADF320", VA = "0x186AE0720")]
	public static bool BHDMNKMCFJD(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AE07A0", Offset = "0x6ADF3A0", VA = "0x186AE07A0")]
	public static bool MJCMACPKMGJ(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AE07D0", Offset = "0x6ADF3D0", VA = "0x186AE07D0")]
	public static bool PJOCNHEEOJB(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0790", Offset = "0x6ADF390", VA = "0x186AE0790")]
	public static bool KNDICIHLCAG(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0750", Offset = "0x6ADF350", VA = "0x186AE0750")]
	public static bool GFDGPMHOHFC(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE07C0", Offset = "0x6ADF3C0", VA = "0x186AE07C0")]
	public static bool OHFOHJLJNCI(this OutfitType FOLCNFDNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HBALLECABBK : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly HBALLECABBK AAGIFLNDKEI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0050", Offset = "0x6ADEC50", VA = "0x186AE0050", Slot = "4")]
	public bool Equals(OutfitType ANBGBEIAFAN, OutfitType HAEMOBNGMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE00B0", Offset = "0x6ADECB0", VA = "0x186AE00B0", Slot = "5")]
	public int GetHashCode(OutfitType FIFJJNIIAPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HBALLECABBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum IHFNNHKDFJC
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OBACBEJFCEF
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum PJMBHDJNOOL
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum MFOJKHLIICG
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HABOPHMGAFA
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum BPOIGNIBKFG
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD4C0", Offset = "0x6ADC0C0", VA = "0x186ADD4C0", Slot = "8")]
		public override bool Equals(AdditionalFeetData FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD4F0", Offset = "0x6ADC0F0", VA = "0x186ADD4F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD570", Offset = "0x6ADC170", VA = "0x186ADD570")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6ADDAA0", Offset = "0x6ADC6A0", VA = "0x186ADDAA0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD5B0", Offset = "0x6ADC1B0", VA = "0x186ADD5B0", Slot = "8")]
		public override bool Equals(AdditionalHatData FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD7A0", Offset = "0x6ADC3A0", VA = "0x186ADD7A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD900", Offset = "0x6ADC500", VA = "0x186ADD900")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDFD0", Offset = "0x6ADCBD0", VA = "0x186ADDFD0")]
		public static bool MPBFFBPNFMO(OutfitType FIFJJNIIAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDB20", Offset = "0x6ADC720", VA = "0x186ADDB20")]
		public static AdditionalOutfitTypeData ELGDCMPCLII(OutfitType FIFJJNIIAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDED0", Offset = "0x6ADCAD0", VA = "0x186ADDED0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData FDOEIPBMJJM);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDF60", Offset = "0x6ADCB60", VA = "0x186ADDF60", Slot = "6")]
		public virtual AdditionalOutfitTypeData JNOOFNDBBED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x42EDD60", Offset = "0x42EC960", VA = "0x1842EDD60", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T FDOEIPBMJJM);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, GDNEFJKBHEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAE0690", Offset = "0xADF290", VA = "0x180AE0690", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF4B0", Offset = "0x6ADE0B0", VA = "0x186ADF4B0", Slot = "8")]
		public override bool Equals(BeardData FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF4D0", Offset = "0x6ADE0D0", VA = "0x186ADF4D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF540", Offset = "0x6ADE140", VA = "0x186ADF540")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HairData : AdditionalOutfitTypeData<HairData>, GDNEFJKBHEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8A6470", Offset = "0x8A5070", VA = "0x1808A6470", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCDF830", Offset = "0xCDE430", VA = "0x180CDF830")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6AE0670", Offset = "0x6ADF270", VA = "0x186AE0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6AE02C0", Offset = "0x6ADEEC0", VA = "0x186AE02C0", Slot = "8")]
		public override bool Equals(HairData FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE04B0", Offset = "0x6ADF0B0", VA = "0x186AE04B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE05B0", Offset = "0x6ADF1B0", VA = "0x186AE05B0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GDNEFJKBHEI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool KPBBJKFJKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle BPHJGAFFDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AIDKJGIINGE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD360", Offset = "0x6ADBF60", VA = "0x186ADD360")]
	public static BCGODMJDFFO CHIKMBCGIKE(this OutfitType FOLCNFDNCAE, AvatarItemSidednessEquipType IEIOFCBLPNJ = AvatarItemSidednessEquipType.Left)
	{
		return default(BCGODMJDFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD460", Offset = "0x6ADC060", VA = "0x186ADD460")]
	public static BCGODMJDFFO LOIPDJNHLIH(this BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(BCGODMJDFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD3E0", Offset = "0x6ADBFE0", VA = "0x186ADD3E0")]
	public static bool CIIOFFGBPND(this OutfitType FOLCNFDNCAE, BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OKGKHCFHMAM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AE09B0", Offset = "0x6ADF5B0", VA = "0x186AE09B0")]
	public static bool HPNKLFPOKJH(this AvatarItemSidednessEquipType IEIOFCBLPNJ, BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AE09E0", Offset = "0x6ADF5E0", VA = "0x186AE09E0")]
	public static bool JKGLGGLBKKK(this AvatarItemSidednessEquipType MBMCHGPLLEJ, BCGODMJDFFO NOIJPBIAGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0A30", Offset = "0x6ADF630", VA = "0x186AE0A30")]
	public static bool NDJLGCPMGEP(this AvatarItemSidednessEquipType ABEAMEKFDPB, AvatarItemSidednessEquipType HNIHHHHKFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0A10", Offset = "0x6ADF610", VA = "0x186AE0A10")]
	public static AvatarItemSidednessEquipType LAKNBBCKAKG(this AvatarItemSidednessEquipType ABEAMEKFDPB)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal enum MMBOHBENNFH
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BENADEIKLPM
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF340", Offset = "0x6ADDF40", VA = "0x186ADF340")]
	private static MMBOHBENNFH LPPFNBPFIFF(this OutfitType FOLCNFDNCAE)
	{
		return default(MMBOHBENNFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEFE0", Offset = "0x6ADDBE0", VA = "0x186ADEFE0")]
	public static OutfitSlotFlags JMIEFGADAPC(this OutfitType FOLCNFDNCAE)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEFD0", Offset = "0x6ADDBD0", VA = "0x186ADEFD0")]
	public static bool JEFHNOHPEMG(this OutfitSlotFlags JPLMIDLDPLF, OutfitSlotFlags IBIIAHCGGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF150", Offset = "0x6ADDD50", VA = "0x186ADF150")]
	public static bool LHDCMANJKEM(this OutfitType FOLCNFDNCAE, OutfitSlotFlags MFMOGIFEMIK)
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
