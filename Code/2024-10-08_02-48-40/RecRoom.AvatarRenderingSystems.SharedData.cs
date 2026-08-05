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
public interface DEMCOBDIFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float NFGNDBOLJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float JFFNHMCMFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float EBHDGFIHLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float MOEBMJAAGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float GLAGADPJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float DAFKFHCEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float OMBOLCKEIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MGHCBBCJMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float IGPMINJGDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float NMJEOLBPFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float LFJFODJGICF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float LACPCBCADOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DKGNLHLCEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float MKOKNABHEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float FJCJBAAOJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float DKBKPKCGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 INCCMPLIOLP(Vector3 LPINAINOABB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 BFKEGBILCJM(Vector3 JJJJHKLFBEM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 EFNNKFGNDJL();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : DEMCOBDIFCF
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
			[Cpp2IlInjected.Address(RVA = "0x931B60", Offset = "0x930D60", VA = "0x180931B60", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE2E4F0", Offset = "0xE2D6F0", VA = "0x180E2E4F0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA0F670", Offset = "0xA0E870", VA = "0x180A0F670", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB6EBF0", Offset = "0xB6DDF0", VA = "0x180B6EBF0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB325A0", Offset = "0xB317A0", VA = "0x180B325A0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE30", Offset = "0xA1B030", VA = "0x180A1BE30", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9FF470", Offset = "0x9FE670", VA = "0x1809FF470", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5410", Offset = "0x8C4610", VA = "0x1808C5410", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AFEA80", Offset = "0x6AFDC80", VA = "0x186AFEA80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF2C0", Offset = "0x6AFE4C0", VA = "0x186AFF2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF2A0", Offset = "0x6AFE4A0", VA = "0x186AFF2A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB6EBC0", Offset = "0xB6DDC0", VA = "0x180B6EBC0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xB32520", Offset = "0xB31720", VA = "0x180B32520", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE10", Offset = "0xA1B010", VA = "0x180A1BE10", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB325C0", Offset = "0xB317C0", VA = "0x180B325C0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9F8F20", Offset = "0x9F8120", VA = "0x1809F8F20", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB6F1D0", Offset = "0xB6E3D0", VA = "0x180B6F1D0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6AFEBB0", Offset = "0x6AFDDB0", VA = "0x186AFEBB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF2E0", Offset = "0x6AFE4E0", VA = "0x186AFF2E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF280", Offset = "0x6AFE480", VA = "0x186AFF280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB6F210", Offset = "0xB6E410", VA = "0x180B6F210", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB6F240", Offset = "0xB6E440", VA = "0x180B6F240", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB6F230", Offset = "0xB6E430", VA = "0x180B6F230", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B0840", Offset = "0x8AFA40", VA = "0x1808B0840", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF300", Offset = "0x6AFE500", VA = "0x186AFF300")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF340", Offset = "0x6AFE540", VA = "0x186AFF340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF320", Offset = "0x6AFE520", VA = "0x186AFF320")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF360", Offset = "0x6AFE560", VA = "0x186AFF360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF1F0", Offset = "0x6AFE3F0", VA = "0x186AFF1F0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE6B0", Offset = "0x6AFD8B0", VA = "0x186AFE6B0")]
		public HMMONNFLLEB AJFENKCBKHG(HMMONNFLLEB HCFIJBGOMDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEBB0", Offset = "0x6AFDDB0", VA = "0x186AFEBB0", Slot = "25")]
		public Vector3 ICFCELHJJMB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEA80", Offset = "0x6AFDC80", VA = "0x186AFEA80", Slot = "22")]
		public Vector3 EFNNKFGNDJL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEBD0", Offset = "0x6AFDDD0", VA = "0x186AFEBD0", Slot = "20")]
		public Vector3 INCCMPLIOLP(Vector3 LPINAINOABB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE990", Offset = "0x6AFDB90", VA = "0x186AFE990", Slot = "21")]
		public Vector3 BFKEGBILCJM(Vector3 JJJJHKLFBEM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEAA0", Offset = "0x6AFDCA0", VA = "0x186AFEAA0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEC40", Offset = "0x6AFDE40", VA = "0x186AFEC40")]
		protected bool IPNBNJOGLJK(AnchorParamsRestrictions KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEA10", Offset = "0x6AFDC10", VA = "0x186AFEA10")]
		[CompilerGenerated]
		internal static bool DBBJDNPIJEN(float APIBENHOAOO, float EGCFJOLCAMD)
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
public static class GNEPCAJDLNF
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFF60", Offset = "0x6AFF160", VA = "0x186AFFF60")]
	public static bool CIFCOJKFIAM(this HelmetHairMode FDANIFPFJBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B00030", Offset = "0x6AFF230", VA = "0x186B00030")]
	public static DANEJOKJCGO HHGMOEHGLLN(this AvatarItemBodyType NHILCAMCPII)
	{
		return default(DANEJOKJCGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B000B0", Offset = "0x6AFF2B0", VA = "0x186B000B0")]
	public static AvatarItemBodyType ONLKKLLGEEM(this DANEJOKJCGO NHILCAMCPII)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFF70", Offset = "0x6AFF170", VA = "0x186AFFF70")]
	public static string CIGPKOOCONC(this AvatarItemBodyType NHILCAMCPII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BNHBDMOEGLN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GFBFAOGJAMD
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
	public enum PAEIABBACMD
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
	public static PAEIABBACMD PMDGABELNAG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static PAEIABBACMD CMNDOKFHKID;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF3A0", Offset = "0x6AFE5A0", VA = "0x186AFF3A0")]
	public static PAEIABBACMD JBELOIMOLJF(PAEIABBACMD OOILKPCKJPI, PAEIABBACMD OOCPPBDBNFP)
	{
		return default(PAEIABBACMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF490", Offset = "0x6AFE690", VA = "0x186AFF490")]
	public static PAEIABBACMD PPOILIPGGDK(PAEIABBACMD AOENCBLNCML, PAEIABBACMD FIDKAFCDPHF)
	{
		return default(PAEIABBACMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF390", Offset = "0x6AFE590", VA = "0x186AFF390")]
	public static PAEIABBACMD HPJCGCBKEIC(GFBFAOGJAMD LMPHCDJMFPO, PAEIABBACMD PEBNDNNKDLM)
	{
		return default(PAEIABBACMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF380", Offset = "0x6AFE580", VA = "0x186AFF380")]
	public static PAEIABBACMD DGLMDDJBCDM(GFBFAOGJAMD LMPHCDJMFPO, PAEIABBACMD PEBNDNNKDLM)
	{
		return default(PAEIABBACMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF420", Offset = "0x6AFE620", VA = "0x186AFF420")]
	public static bool MBCBBANDPIH(this PAEIABBACMD LCPAHJCCLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF3B0", Offset = "0x6AFE5B0", VA = "0x186AFF3B0")]
	public static bool KBEHFBNFLEM(this PAEIABBACMD LCPAHJCCLEN)
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
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6AFFF50", Offset = "0x6AFF150", VA = "0x186AFFF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF930", Offset = "0x6AFEB30", VA = "0x186AFF930")]
		public void JNNJAGIIEEA(FitMeshHemisphere GBAAHCKFDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF9E0", Offset = "0x6AFEBE0", VA = "0x186AFF9E0")]
		public Vector3 NEEMAPBKPHG(Vector2 OBAOAIHMKHP, bool MHOMOJDCBCF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF980", Offset = "0x6AFEB80", VA = "0x186AFF980")]
		public Vector3 MOBHLFCHFMB(Vector2 OBAOAIHMKHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF5C0", Offset = "0x6AFE7C0", VA = "0x186AFF5C0")]
		public Quaternion HDLLIFKJFGD(Vector2 OBAOAIHMKHP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF770", Offset = "0x6AFE970", VA = "0x186AFF770")]
		public Quaternion HDLLIFKJFGD(Vector2 OBAOAIHMKHP, Vector3 DLKILFMLJLP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF8E0", Offset = "0x6AFEAE0", VA = "0x186AFF8E0")]
		public Vector2 INDJOCBPKEA(Vector2 LIFBPCGFCAO)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFEB0", Offset = "0x6AFF0B0", VA = "0x186AFFEB0")]
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
public static class NIBFMACADKJ
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B00670", Offset = "0x6AFF870", VA = "0x186B00670")]
	public static bool ANNPPENOFNN(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B006A0", Offset = "0x6AFF8A0", VA = "0x186B006A0")]
	public static bool BGCAECAOMIP(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B006E0", Offset = "0x6AFF8E0", VA = "0x186B006E0")]
	public static bool EFENBIOFFKE(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6B006D0", Offset = "0x6AFF8D0", VA = "0x186B006D0")]
	public static bool DHOOFCCCHND(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B00720", Offset = "0x6AFF920", VA = "0x186B00720")]
	public static bool IPMEDMMCPNI(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B00730", Offset = "0x6AFF930", VA = "0x186B00730")]
	public static bool NENPBGHDFGD(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B006C0", Offset = "0x6AFF8C0", VA = "0x186B006C0")]
	public static bool CAHBCBFOFIA(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B006F0", Offset = "0x6AFF8F0", VA = "0x186B006F0")]
	public static bool EGHEJKOBIPM(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B00700", Offset = "0x6AFF900", VA = "0x186B00700")]
	public static bool FGNGGOHLAPC(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B00690", Offset = "0x6AFF890", VA = "0x186B00690")]
	public static bool BBKJJBJACND(this OutfitType GPNNJGOBEIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KOODPIDOCDO : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly KOODPIDOCDO FAKOKDPOOAM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B00570", Offset = "0x6AFF770", VA = "0x186B00570", Slot = "4")]
	public bool Equals(OutfitType NDDMCEPMDEO, OutfitType FHLNPBJFKGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B005D0", Offset = "0x6AFF7D0", VA = "0x186B005D0", Slot = "5")]
	public int GetHashCode(OutfitType EIHDAHDDDEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KOODPIDOCDO()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDB60", Offset = "0x6AFCD60", VA = "0x186AFDB60", Slot = "8")]
		public override bool Equals(AdditionalFeetData KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDB90", Offset = "0x6AFCD90", VA = "0x186AFDB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDC10", Offset = "0x6AFCE10", VA = "0x186AFDC10")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6AFE140", Offset = "0x6AFD340", VA = "0x186AFE140")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDC50", Offset = "0x6AFCE50", VA = "0x186AFDC50", Slot = "8")]
		public override bool Equals(AdditionalHatData KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDE40", Offset = "0x6AFD040", VA = "0x186AFDE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDFA0", Offset = "0x6AFD1A0", VA = "0x186AFDFA0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE1C0", Offset = "0x6AFD3C0", VA = "0x186AFE1C0")]
		public static bool EJAHDAKLKBJ(OutfitType EIHDAHDDDEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE300", Offset = "0x6AFD500", VA = "0x186AFE300")]
		public static AdditionalOutfitTypeData LGJIMIKIEOH(OutfitType EIHDAHDDDEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE1F0", Offset = "0x6AFD3F0", VA = "0x186AFE1F0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData KDHPJMADEAD);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE280", Offset = "0x6AFD480", VA = "0x186AFE280", Slot = "6")]
		public virtual AdditionalOutfitTypeData KIEKDHFGNJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x45F06A0", Offset = "0x45EF8A0", VA = "0x1845F06A0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T KDHPJMADEAD);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, CBJJLIFALNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBCB400", Offset = "0xBCA600", VA = "0x180BCB400", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF4F0", Offset = "0x6AFE6F0", VA = "0x186AFF4F0", Slot = "8")]
		public override bool Equals(BeardData KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF510", Offset = "0x6AFE710", VA = "0x186AFF510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF580", Offset = "0x6AFE780", VA = "0x186AFF580")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HairData : AdditionalOutfitTypeData<HairData>, CBJJLIFALNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x969330", Offset = "0x968530", VA = "0x180969330", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8B35B0", Offset = "0x8B27B0", VA = "0x1808B35B0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6B004E0", Offset = "0x6AFF6E0", VA = "0x186B004E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B00130", Offset = "0x6AFF330", VA = "0x186B00130", Slot = "8")]
		public override bool Equals(HairData KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B00320", Offset = "0x6AFF520", VA = "0x186B00320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6B00420", Offset = "0x6AFF620", VA = "0x186B00420")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBJJLIFALNA
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BEOFAJADCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HairPatternStyle INAGFGBEHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
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
