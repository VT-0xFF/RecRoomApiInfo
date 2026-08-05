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
public interface OKFOBIOPMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float HKLCJPFDFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float EHPAMJJNADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float LKMOMABLJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float MDJAMHCPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float KNGJNPAIFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float APNNAMOKDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GPDNJMFFOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KFOGOAJJNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KCMKOILKGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PAFLMCJNFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float IJBEEKLJDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float BPNGGACAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OLCLIEBLIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LGBJBMCKMON
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float MHLMBIFOPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PEPGBBLFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 EMHMBMBJHMK(Vector3 IEIKMFFPGJB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 HNKAMMDGLNE(Vector3 APGNPFIHGNG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 MEFBMLNPDIA();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : OKFOBIOPMDF
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
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB32050", Offset = "0xB31450", VA = "0x180B32050", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xACB6F0", Offset = "0xACAAF0", VA = "0x180ACB6F0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1057300", Offset = "0x1056700", VA = "0x181057300", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD23FD0", Offset = "0xD233D0", VA = "0x180D23FD0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EF90", Offset = "0xA9E390", VA = "0x180A9EF90", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x811C870", Offset = "0x811BC70", VA = "0x18811C870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x811CA20", Offset = "0x811BE20", VA = "0x18811CA20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x811CA00", Offset = "0x811BE00", VA = "0x18811CA00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAC06C0", Offset = "0xABFAC0", VA = "0x180AC06C0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xEEE240", Offset = "0xEED640", VA = "0x180EEE240", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAC27B0", Offset = "0xAC1BB0", VA = "0x180AC27B0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD22450", Offset = "0xD21850", VA = "0x180D22450", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x102B3E0", Offset = "0x102A7E0", VA = "0x18102B3E0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245C40", VA = "0x181246840", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x811BCE0", Offset = "0x811B0E0", VA = "0x18811BCE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x811CA40", Offset = "0x811BE40", VA = "0x18811CA40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x811C9E0", Offset = "0x811BDE0", VA = "0x18811C9E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1246880", Offset = "0x1245C80", VA = "0x181246880", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xDD8C10", Offset = "0xDD8010", VA = "0x180DD8C10", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDD8DA0", Offset = "0xDD81A0", VA = "0x180DD8DA0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA89A50", Offset = "0xA88E50", VA = "0x180A89A50", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x811CA60", Offset = "0x811BE60", VA = "0x18811CA60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x811CAA0", Offset = "0x811BEA0", VA = "0x18811CAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x811CA80", Offset = "0x811BE80", VA = "0x18811CA80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x811CAC0", Offset = "0x811BEC0", VA = "0x18811CAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x811C950", Offset = "0x811BD50", VA = "0x18811C950")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x811C580", Offset = "0x811B980", VA = "0x18811C580")]
		public CHMLELHGCGH ICFLPAIGHKK(CHMLELHGCGH IPGCOJOFDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x811BCE0", Offset = "0x811B0E0", VA = "0x18811BCE0", Slot = "25")]
		public Vector3 FICAEMANNBF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x811C870", Offset = "0x811BC70", VA = "0x18811C870", Slot = "22")]
		public Vector3 MEFBMLNPDIA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x811BB60", Offset = "0x811AF60", VA = "0x18811BB60", Slot = "20")]
		public Vector3 EMHMBMBJHMK(Vector3 IEIKMFFPGJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x811C500", Offset = "0x811B900", VA = "0x18811C500", Slot = "21")]
		public Vector3 HNKAMMDGLNE(Vector3 APGNPFIHGNG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x811BBD0", Offset = "0x811AFD0", VA = "0x18811BBD0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x811C000", Offset = "0x811B400", VA = "0x18811C000")]
		protected bool HELOPPPCEGA(AnchorParamsRestrictions LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x811BD00", Offset = "0x811B100", VA = "0x18811BD00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x811BAF0", Offset = "0x811AEF0", VA = "0x18811BAF0")]
		[CompilerGenerated]
		internal static bool CABGOIPBKCI(float HCFCOMCPJPA, float JOCIBENNGKI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LHLBNCMOEOI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1870900", Offset = "0x186FD00", VA = "0x181870900")]
	public static bool IPIOIDOKBAM(this KMPAOABCDOI JNKOIGEJLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x811F210", Offset = "0x811E610", VA = "0x18811F210")]
	public static bool JEHGCBPGAAO(this KMPAOABCDOI JNKOIGEJLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x811F220", Offset = "0x811E620", VA = "0x18811F220")]
	public static bool PBEOCLGLLFK(this KMPAOABCDOI JNKOIGEJLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x811F1F0", Offset = "0x811E5F0", VA = "0x18811F1F0")]
	public static bool GOECANEJHOA(this KMPAOABCDOI JNKOIGEJLAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHONACNCAPL
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool CPIBDOBCAPK;
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
public static class IFADJPABNLA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x811DEB0", Offset = "0x811D2B0", VA = "0x18811DEB0")]
	public static bool KDADLACEFHO(this HelmetHairMode HDIGGPGCLJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x811DF80", Offset = "0x811D380", VA = "0x18811DF80")]
	public static AGMMOBNOCAG NKPDAGBMNOJ(this AvatarItemBodyType NBLJOEEFODI)
	{
		return default(AGMMOBNOCAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x811DE30", Offset = "0x811D230", VA = "0x18811DE30")]
	public static AvatarItemBodyType HNGLEJCKIKM(this AGMMOBNOCAG NBLJOEEFODI)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x811DEC0", Offset = "0x811D2C0", VA = "0x18811DEC0")]
	public static string KDLHJKCAIBH(this AvatarItemBodyType NBLJOEEFODI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LHGNHGJGDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x811E8A0", Offset = "0x811DCA0", VA = "0x18811E8A0")]
	public static void JMIOMBMMBNL(Transform BNAIDDPFPJI, Transform IMBDOFCNPCN, Transform OPPENKGIKLC, Transform GGNFNNKFHLH, float DOLEIIMGPJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LFDPDKBANDC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum JCAFCBKJOME
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
	public enum JGFNEKKJIOP : long
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
	public static readonly IReadOnlyList<JCAFCBKJOME> LBNDMJGCHHI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JCAFCBKJOME> EFCEGCKMOCE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<JCAFCBKJOME> IKIKELLGJLA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IReadOnlyList<JCAFCBKJOME> HLFOCJKJNKN;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly JGFNEKKJIOP JKHKDMMHDMK;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly JGFNEKKJIOP EODINMKCBGP;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly JGFNEKKJIOP NLGKNBOJICF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x811E690", Offset = "0x811DA90", VA = "0x18811E690")]
	public static JGFNEKKJIOP MBPNDIHJMDB(JGFNEKKJIOP OMEEPDBHCPA, JGFNEKKJIOP MNBJHGMICOI)
	{
		return default(JGFNEKKJIOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x811E6A0", Offset = "0x811DAA0", VA = "0x18811E6A0")]
	public static JGFNEKKJIOP OINAACNFBLE(JGFNEKKJIOP MKGGIEKOKCC, JGFNEKKJIOP FFAAMNPLEEL)
	{
		return default(JGFNEKKJIOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x811E680", Offset = "0x811DA80", VA = "0x18811E680")]
	public static JGFNEKKJIOP EGCJDEILKIJ(JCAFCBKJOME EDECCIBOKLD, JGFNEKKJIOP PFOENMCBPEC)
	{
		return default(JGFNEKKJIOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x811E660", Offset = "0x811DA60", VA = "0x18811E660")]
	public static JGFNEKKJIOP ABJAINLFPPF(JCAFCBKJOME EDECCIBOKLD, JGFNEKKJIOP PFOENMCBPEC)
	{
		return default(JGFNEKKJIOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MDHFABODAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum EKADEHHDLOB : short
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
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x811D930", Offset = "0x811CD30", VA = "0x18811D930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x811CE90", Offset = "0x811C290", VA = "0x18811CE90")]
		public void GIIOPCDFCGH(FitMeshHemisphere IIICGONEGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x811D210", Offset = "0x811C610", VA = "0x18811D210")]
		public Vector3 MFEHPOFICPG(Vector2 BLPEDOCJJCL, bool DPGNAMBECKK = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x811CE30", Offset = "0x811C230", VA = "0x18811CE30")]
		public Vector3 BDPLGHHEKEG(Vector2 BLPEDOCJJCL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x811CEE0", Offset = "0x811C2E0", VA = "0x18811CEE0")]
		public Quaternion IALFNCGKHFA(Vector2 BLPEDOCJJCL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x811D0A0", Offset = "0x811C4A0", VA = "0x18811D0A0")]
		public Quaternion IALFNCGKHFA(Vector2 BLPEDOCJJCL, Vector3 KHIDBJBJHBG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x811D700", Offset = "0x811CB00", VA = "0x18811D700")]
		public Vector2 OJFDFJFFADB(Vector2 FCHNAMJMMGC)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x811D880", Offset = "0x811CC80", VA = "0x18811D880")]
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
		Roomie_Eye = 502,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Roomie_Mouth = 503,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Roomie_Equipment = 504
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AEHFGOJJADP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x811AD10", Offset = "0x811A110", VA = "0x18811AD10")]
	public static bool IAEMACFGCJK(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x811AD70", Offset = "0x811A170", VA = "0x18811AD70")]
	public static bool NDLLLEKGIDA(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x811ACD0", Offset = "0x811A0D0", VA = "0x18811ACD0")]
	public static bool BEKDOIOEGGC(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x811ACE0", Offset = "0x811A0E0", VA = "0x18811ACE0")]
	public static bool DALIHBOIHHH(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x811ACF0", Offset = "0x811A0F0", VA = "0x18811ACF0")]
	public static bool DFFPBKDKNMI(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x811AD40", Offset = "0x811A140", VA = "0x18811AD40")]
	public static bool LCDIHDGHEFP(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x811AD60", Offset = "0x811A160", VA = "0x18811AD60")]
	public static bool MFDEEJCMMEB(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x811AD30", Offset = "0x811A130", VA = "0x18811AD30")]
	public static bool IAHKLLFFALK(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x811ADC0", Offset = "0x811A1C0", VA = "0x18811ADC0")]
	public static bool PADDOOEAKIG(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x811AD00", Offset = "0x811A100", VA = "0x18811AD00")]
	public static bool EFKOFDAGPON(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x811AD90", Offset = "0x811A190", VA = "0x18811AD90")]
	public static bool OFHCPOBDFFC(this OutfitType COHPPKDJCLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ADKONFLEIFM : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static readonly ADKONFLEIFM NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x811ABC0", Offset = "0x8119FC0", VA = "0x18811ABC0", Slot = "4")]
	public bool Equals(OutfitType JMBNBEKAIEM, OutfitType GNJKGLPOPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x811AC20", Offset = "0x811A020", VA = "0x18811AC20", Slot = "5")]
	public int GetHashCode(OutfitType IIHAKBEOLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ADKONFLEIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JEBPJLFOHBK
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NGOKGPAMFGH
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HOPHAMFEDGF
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PHHJIMPAPKF
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum NFFBEAMILGG
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BIBEJHBBCLK
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum RoomieEquipmentType
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Quest_Sword_1
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x811ADE0", Offset = "0x811A1E0", VA = "0x18811ADE0", Slot = "7")]
		public override bool Equals(AdditionalFeetData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x811AE10", Offset = "0x811A210", VA = "0x18811AE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x811AE90", Offset = "0x811A290", VA = "0x18811AE90")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x811B360", Offset = "0x811A760", VA = "0x18811B360")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x811AED0", Offset = "0x811A2D0", VA = "0x18811AED0", Slot = "7")]
		public override bool Equals(AdditionalHatData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x811B0C0", Offset = "0x811A4C0", VA = "0x18811B0C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x811B220", Offset = "0x811A620", VA = "0x18811B220")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x811BAA0", Offset = "0x811AEA0", VA = "0x18811BAA0")]
		public static bool FNGLHOGPBDM(OutfitType IIHAKBEOLJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x811B3E0", Offset = "0x811A7E0", VA = "0x18811B3E0")]
		public static AdditionalOutfitTypeData CEOONNIFPHP(OutfitType IIHAKBEOLJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x811BA10", Offset = "0x811AE10", VA = "0x18811BA10", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LHDOHAKINKP);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x55C4E40", Offset = "0x55C4240", VA = "0x1855C4E40", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T LHDOHAKINKP);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class IEDODKKHBBL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x811DD80", Offset = "0x811D180", VA = "0x18811DD80")]
	public static bool LEHMAEPMHCI(this AdditionalOutfitTypeData CELDPEMMPBC)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, OBLOOIMOCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x811CAE0", Offset = "0x811BEE0", VA = "0x18811CAE0", Slot = "7")]
		public override bool Equals(BeardData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x811CB00", Offset = "0x811BF00", VA = "0x18811CB00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x811CB70", Offset = "0x811BF70", VA = "0x18811CB70")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HairData : AdditionalOutfitTypeData<HairData>, OBLOOIMOCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD31600", Offset = "0xD30A00", VA = "0x180D31600", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC60", Offset = "0xA8C060", VA = "0x180A8CC60", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE6C750", Offset = "0xE6BB50", VA = "0x180E6C750")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x811DCF0", Offset = "0x811D0F0", VA = "0x18811DCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x811D940", Offset = "0x811CD40", VA = "0x18811D940", Slot = "7")]
		public override bool Equals(HairData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x811DB30", Offset = "0x811CF30", VA = "0x18811DB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x811DC30", Offset = "0x811D030", VA = "0x18811DC30")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MOEPNEFCOEA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool PEGCFGALOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AAIOEBADMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AnchorParamsRestrictions HGPILOJDHKF();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OBLOOIMOCDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LACJOELBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HairPatternStyle MIFPBHCFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface CAIONFANPMO
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	const string PDMLPPDDLJJ = "FFFFFF";

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GFMHAGKEHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string DCPJKIEKBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RoomieEquipmentData : AdditionalOutfitTypeData<RoomieEquipmentData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public RoomieEquipmentType equipmentType;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public RoomieEquipmentType EquipmentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			get
			{
				return default(RoomieEquipmentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B04880", Offset = "0x7B03C80", VA = "0x187B04880", Slot = "7")]
		public override bool Equals(RoomieEquipmentData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x811F490", Offset = "0x811E890", VA = "0x18811F490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x811F4F0", Offset = "0x811E8F0", VA = "0x18811F4F0")]
		public RoomieEquipmentData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RoomieEyeData : AdditionalOutfitTypeData<RoomieEyeData>, CAIONFANPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x811F530", Offset = "0x811E930", VA = "0x18811F530", Slot = "7")]
		public override bool Equals(RoomieEyeData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x811F560", Offset = "0x811E960", VA = "0x18811F560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x811F5D0", Offset = "0x811E9D0", VA = "0x18811F5D0")]
		public RoomieEyeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RoomieHatData : AdditionalOutfitTypeData<RoomieHatData>, CAIONFANPMO, MOEPNEFCOEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsTranslatable
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x811F800", Offset = "0x811EC00", VA = "0x18811F800", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsRotatable
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x811F7E0", Offset = "0x811EBE0", VA = "0x18811F7E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x811F640", Offset = "0x811EA40", VA = "0x18811F640", Slot = "7")]
		public override bool Equals(RoomieHatData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x811F6B0", Offset = "0x811EAB0", VA = "0x18811F6B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "12")]
		public AnchorParamsRestrictions HGPILOJDHKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x811F730", Offset = "0x811EB30", VA = "0x18811F730")]
		public RoomieHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RoomieMouthData : AdditionalOutfitTypeData<RoomieMouthData>, CAIONFANPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x811F530", Offset = "0x811E930", VA = "0x18811F530", Slot = "7")]
		public override bool Equals(RoomieMouthData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x811F820", Offset = "0x811EC20", VA = "0x18811F820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x811F890", Offset = "0x811EC90", VA = "0x18811F890")]
		public RoomieMouthData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class RoomieWaistData : AdditionalOutfitTypeData<RoomieWaistData>, CAIONFANPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public bool isRecolorable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public string defaultColor;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IsRecolorable
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string DefaultColor
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x811F530", Offset = "0x811E930", VA = "0x18811F530", Slot = "7")]
		public override bool Equals(RoomieWaistData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x811F900", Offset = "0x811ED00", VA = "0x18811F900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x811F970", Offset = "0x811ED70", VA = "0x18811F970")]
		public RoomieWaistData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class PIGLGDOJDGN
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x811F3B0", Offset = "0x811E7B0", VA = "0x18811F3B0")]
	public static KMPAOABCDOI IFBIBCNIAOJ(this OutfitType COHPPKDJCLA, AvatarItemSidednessEquipType BAHFBBDHHGE = AvatarItemSidednessEquipType.Left)
	{
		return default(KMPAOABCDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x811F2E0", Offset = "0x811E6E0", VA = "0x18811F2E0")]
	public static KDPIDKKOEEB DIJJPPACNMB(this OutfitType COHPPKDJCLA, AvatarItemSidednessEquipType BAHFBBDHHGE = AvatarItemSidednessEquipType.Left)
	{
		return default(KDPIDKKOEEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x811F440", Offset = "0x811E840", VA = "0x18811F440")]
	public static KMPAOABCDOI ONHBHLOGEFL(this KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(KMPAOABCDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x811F310", Offset = "0x811E710", VA = "0x18811F310")]
	public static bool FODCOKEKFDN(this OutfitType COHPPKDJCLA, KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LNAOIAEOEHC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x811F240", Offset = "0x811E640", VA = "0x18811F240")]
	public static bool APCBDLKCPFL(this AvatarItemSidednessEquipType BAHFBBDHHGE, KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x811F270", Offset = "0x811E670", VA = "0x18811F270")]
	public static bool BPGINIJFPAD(this AvatarItemSidednessEquipType EBDMLGKMJFE, KMPAOABCDOI FBBAOHEBJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x811F2C0", Offset = "0x811E6C0", VA = "0x18811F2C0")]
	public static bool NLBFCALJOFA(this AvatarItemSidednessEquipType MOFLEPJCBPN, AvatarItemSidednessEquipType GHKAAFAPBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x811F2A0", Offset = "0x811E6A0", VA = "0x18811F2A0")]
	public static AvatarItemSidednessEquipType CCOGNKJKDJP(this AvatarItemSidednessEquipType MOFLEPJCBPN)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum CIPIEAMOPGC
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Wrist = 10,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Roomie_Head = 20,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Roomie_Waist = 21,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Roomie_Eye = 22,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Roomie_Mouth = 23,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Roomie_Tool = 24
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Roomie_Head = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Roomie_Waist = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Roomie_Eye = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LCIDJKPCGLC
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x811E1E0", Offset = "0x811D5E0", VA = "0x18811E1E0")]
	private static CIPIEAMOPGC NNDLJEEKBPJ(this OutfitType COHPPKDJCLA)
	{
		return default(CIPIEAMOPGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x811E000", Offset = "0x811D400", VA = "0x18811E000")]
	public static OutfitSlotFlags CCFCBNCNCKH(this OutfitType COHPPKDJCLA)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x811E650", Offset = "0x811DA50", VA = "0x18811E650")]
	public static bool PGOGLAKINIH(this OutfitSlotFlags JFFKDGHHJBM, OutfitSlotFlags NHKHMHKELOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x811E3C0", Offset = "0x811D7C0", VA = "0x18811E3C0")]
	public static bool OBFMIGHDGPF(this OutfitType COHPPKDJCLA, OutfitSlotFlags NOKDAPHLAKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FIDJIHIFKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4 DFKDCPPKNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Vector4 BGGBADEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4 AMECDCFEPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4 DBPFBNNCOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4 DLPPHOOHEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4 MJPABLEOJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4 DEBCOFDPHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4 CMCGENPFHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4 DADBAJGCMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4 LPKJFKKMAFH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x811CBB0", Offset = "0x811BFB0", VA = "0x18811CBB0")]
	public void MEKHOFHGJPO(Material MJMLIEBHGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FNEOCLHOLKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Texture2D OHCNJAAMEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public Texture2D KHCLFLKNJGI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x811CDB0", Offset = "0x811C1B0", VA = "0x18811CDB0")]
	public void MEKHOFHGJPO(Material MJMLIEBHGEF)
	{
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
