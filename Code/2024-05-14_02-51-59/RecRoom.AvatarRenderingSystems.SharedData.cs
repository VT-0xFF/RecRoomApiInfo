using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KMMOHIFFHFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float ODFCGLOCEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float AFAAOHPLFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NDHNLPMCHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float GLCNNMILAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float KEIFBGPHDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float IPGALHNDKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DGPGLNALPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float BFGIKNOCHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float PBMCPMKPDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float LOONLMHOGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float FBKBGMPHMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float MJNPOGKFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float JAPNHMLAJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float CFJOLLKHJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float NIFHEFFEKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HHJOBAKHALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 IOPNBEOICEK(Vector3 PPOKIILIAHH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 EIJKLNJHKDJ(Vector3 KOFIDGAJNBN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 DPHGPJCIJMA();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : KMMOHIFFHFB
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
			[Cpp2IlInjected.Address(RVA = "0x838CD0", Offset = "0x8376D0", VA = "0x180838CD0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA30700", Offset = "0xA2F100", VA = "0x180A30700", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x955000", VA = "0x180956600", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA141A0", Offset = "0xA12BA0", VA = "0x180A141A0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x915520", Offset = "0x913F20", VA = "0x180915520", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977590", VA = "0x180978B90", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89E450", Offset = "0x89CE50", VA = "0x18089E450", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F2650", Offset = "0x7F1050", VA = "0x1807F2650", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x61F9560", Offset = "0x61F7F60", VA = "0x1861F9560")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA44E60", Offset = "0xA43860", VA = "0x180A44E60", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1158D60", Offset = "0x1157760", VA = "0x181158D60", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x96CED0", Offset = "0x96B8D0", VA = "0x18096CED0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC91B70", VA = "0x180C93170", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1B99020", Offset = "0x1B97A20", VA = "0x181B99020", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD3BA30", Offset = "0xD3A430", VA = "0x180D3BA30", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61F9AE0", Offset = "0x61F84E0", VA = "0x1861F9AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD3BA20", Offset = "0xD3A420", VA = "0x180D3BA20", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA25C0", VA = "0x180AA3BC0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8E2C70", Offset = "0x8E1670", VA = "0x1808E2C70", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7DD9F0", Offset = "0x7DC3F0", VA = "0x1807DD9F0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x61FA150", Offset = "0x61F8B50", VA = "0x1861FA150")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61FA190", Offset = "0x61F8B90", VA = "0x1861FA190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61FA170", Offset = "0x61F8B70", VA = "0x1861FA170")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61FA1B0", Offset = "0x61F8BB0", VA = "0x1861FA1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61FA0C0", Offset = "0x61F8AC0", VA = "0x1861FA0C0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61F9780", Offset = "0x61F8180", VA = "0x1861F9780")]
		public BFLEOALKIFK ILMKKFLIIKO(BFLEOALKIFK KEHHGCBCEBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61F9AE0", Offset = "0x61F84E0", VA = "0x1861F9AE0", Slot = "25")]
		public Vector3 JNDLBAFLMKL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61F9560", Offset = "0x61F7F60", VA = "0x1861F9560", Slot = "22")]
		public Vector3 DPHGPJCIJMA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61F9A70", Offset = "0x61F8470", VA = "0x1861F9A70", Slot = "20")]
		public Vector3 IOPNBEOICEK(Vector3 PPOKIILIAHH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61F95F0", Offset = "0x61F7FF0", VA = "0x1861F95F0", Slot = "21")]
		public Vector3 EIJKLNJHKDJ(Vector3 KOFIDGAJNBN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61F9670", Offset = "0x61F8070", VA = "0x1861F9670", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61F9B00", Offset = "0x61F8500", VA = "0x1861F9B00")]
		protected bool KGKJIIAJPND(AnchorParamsRestrictions HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61F9580", Offset = "0x61F7F80", VA = "0x1861F9580")]
		[CompilerGenerated]
		internal static bool EEEBIBMEDNF(float LMANHAAPNDE, float AMHFHPBEBNM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NOFHJNOEPOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Transform[] NIFPAIMPIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<string, Transform> DEDLDNHMEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Transform, Transform> EGCMKOLGLHE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform[] AHDOBGNDFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6200840", Offset = "0x61FF240", VA = "0x186200840")]
	public void JJAODCNBOBC(Transform BDDEGGLHCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62005B0", Offset = "0x61FEFB0", VA = "0x1862005B0")]
	public Transform DGLIJEAEGIP(Transform NMALHOBHIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6200920", Offset = "0x61FF320", VA = "0x186200920")]
	public void JNHAGBPEINH(SkinnedMeshRenderer OKMLFCJEOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6200690", Offset = "0x61FF090", VA = "0x186200690")]
	private static void HOGOBLHKFAP(Transform AKBOHBAKCNP, List<Transform> CAGNNHOGHEB, Dictionary<string, Transform> DOCBDOABAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6200B60", Offset = "0x61FF560", VA = "0x186200B60")]
	public NOFHJNOEPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GMJEBCANNBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool IANHOLBIHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool EKKPDDAFBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public FMIFMPDKCJC? FPDCLHNDFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public FHDAOFFBFNF.GIDFDMGKMNF EHEGFAJIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Texture2D GBGMNBKAECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Texture2D EFMBKEDJGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public IList<CODGFMFKADE> IPMFDIFDCPL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GMJEBCANNBA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61FA1D0", Offset = "0x61F8BD0", VA = "0x1861FA1D0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JHMGLKOBIJI
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JGNEGDPOCMG EHGBCCPBHJI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static BFLEOALKIFK EDMBGMIMEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61FF430", Offset = "0x61FDE30", VA = "0x1861FF430")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JMFJNMCGOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Transform BJOLIOHPJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public AssetReference BJHMPPMEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GameObject NKFNBAPAHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject LBHAKMNDEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer CLNCDENGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Material MMHJFHBHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Material GPEBAACABNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Material AKHLHCJHECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Shader EPFGFCONALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Shader AGKOAFEBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Animator PFECJJJPOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Renderer[] OCEPNOIIFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AvatarConfiguration PLIHCIOADEN;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MBNCAEBANBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public SkinnedMeshRenderer[] NKLACPNPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public SkinnedMeshRenderer[] NJDBLMEGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public SkinnedMeshRenderer[] OENFLFLPHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public SkinnedMeshRenderer[] GOGFPEOOLDF;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HEHLGEJLBPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform MHPDPFBIGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform FCCLENMOKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform LILMMEAOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Transform CPDBCJLBIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Transform NOIDOCBFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Transform KLONDFDIBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Transform BDGCNOMBFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public AvatarConfiguration PLIHCIOADEN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FKNAEFHCDDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public SkinnedMeshRenderer[] JMLNACMJJIB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OBEEACAADBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public CBBDDFPEFMJ EOINIDOLBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int NGJGJAMLKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int ENEJNCHHGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color FNBACCODJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Color ELIEPFIBKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int IPLDFECNBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int KKOLBOGGOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Color FHKLNFKJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Color CKPGINJEHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public int HPBDHOGHDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float IFNFCDIEEAE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LPMABDDJJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public CBBDDFPEFMJ EOINIDOLBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector2 ODOBCFLJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float CDICECCHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector2 IJNNIEAPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float EGIDJOPCKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector2 HFBJDIBDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float MPICDCFGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Vector2 LABNHEPHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float MDMLOMBCANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool AELPLKLPDLN;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CODGFMFKADE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public string HAKLMNHDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public OutfitType IMLHNDEGCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public DCDDAAOOBKB MLKGAFEAIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public FHDAOFFBFNF.GIDFDMGKMNF LPHEOODHMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool PODDOCBEMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool EKKOLGAOLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool FKMIIPOHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Color? KGDKFCMAHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Guid? HBBJENFOMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Color? JNIGFFGKBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool FKEGLADOEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool GMBLDKAJAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform OMIFKPPNPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector2? ONMJPNOBPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public FitMeshHemisphere DDFKIIEPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AssetReference MIHJGIAEDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AssetReference LBAOFCMEJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AssetReference[] OFGHHMEBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool CDOHICEHFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool MKEGIBNHKFB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string AEFJAPBOLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61FCC10", Offset = "0x61FB610", VA = "0x1861FCC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61FCC10", Offset = "0x61FB610", VA = "0x1861FCC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61FCCC0", Offset = "0x61FB6C0", VA = "0x1861FCCC0")]
	public CODGFMFKADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IFDHMACKPAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer JFGNMCDMOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material[] NDILFHFBFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private byte[] LLIILCOBKKN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Mesh NKJPNHMGEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61FF350", Offset = "0x61FDD50", VA = "0x1861FF350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Material[] DMLLHPOGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] DCIOFDCMALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61FF370", Offset = "0x61FDD70", VA = "0x1861FF370")]
	public IFDHMACKPAI(SkinnedMeshRenderer PCKLLLIOFDB, [Optional] Material[] MMIPGDAMCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61FF1D0", Offset = "0x61FDBD0", VA = "0x1861FF1D0")]
	public static IFDHMACKPAI EKDAIJCMFKC(Renderer LDIKCIPDAKN)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA6FE30", Offset = "0xA6E830", VA = "0x180A6FE30")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EHABDEJHMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61FCE70", Offset = "0x61FB870", VA = "0x1861FCE70")]
	public static PositionAndRotation IAIJFOEJCCM(this PositionAndRotation DGIBBDIMHIN)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61FCDD0", Offset = "0x61FB7D0", VA = "0x1861FCDD0")]
	public static float AHLEMBHMDOB(float BIKAIHEBIHG, Vector2 OHPIPOPBJAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61FCD50", Offset = "0x61FB750", VA = "0x1861FCD50")]
	public static float AHLEMBHMDOB(float BIKAIHEBIHG, float DOOLANFACOC, float DHAEDCCJHDP, float AOFEKHADIFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61FD080", Offset = "0x61FBA80", VA = "0x1861FD080")]
	public static float NOCAMHKNJBO(float AEJBOLFACJC, Vector2 OHPIPOPBJAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61FCFD0", Offset = "0x61FB9D0", VA = "0x1861FCFD0")]
	public static float NOCAMHKNJBO(float AEJBOLFACJC, float DOOLANFACOC, float DHAEDCCJHDP, float AOFEKHADIFK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DKBGLHBNGKE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly int AMFNEBBBIJN;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly string EEOODIOEPFI;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum AFGPNKPILCE
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HNFBLDHMJGO
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JHIKLGJHNGB
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	NoPattern,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Curly,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Braid
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DCDDAAOOBKB
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum MPHEOLFMMEG
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KCNPANCMBKL
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BCEBCMAJFOB
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LCLAAFBEILO
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JBJFMNNMMIG
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum HANDPICLIOD
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	None
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NMMOHFNHLCF
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class LOGNMPMCNFE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC20", Offset = "0x61FE620", VA = "0x1861FFC20")]
	public static bool BNJOFDBHJDC(this AFGPNKPILCE OAIPBOKLKOL)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum DPENGBLCOHG
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private Dictionary<FMIFMPDKCJC, BodySkinnedMeshLODs> CJJBBAJIJPH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BodySkinnedMeshLODs LOKGGJPANLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public BodySkinnedMeshLODs JFBMDIOBIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BodySkinnedMeshLODs IGCFFJJFCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public BodySkinnedMeshLODs NCACKOPHCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61FA720", Offset = "0x61F9120", VA = "0x1861FA720")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61FA480", Offset = "0x61F8E80", VA = "0x1861FA480")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(DPENGBLCOHG GPIDGOCKONB, [Optional] FMIFMPDKCJC? LNGIFCBDLED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x61FA820", Offset = "0x61F9220", VA = "0x1861FA820")]
		public AvatarSkinAssetItem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FHDAOFFBFNF
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum LPMMEKKKKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Flags]
	public enum GIDFDMGKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static GIDFDMGKMNF OHCCHNELCLM;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static GIDFDMGKMNF GNHNMHPKLKO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C1EC60", Offset = "0x1C1D660", VA = "0x181C1EC60")]
	public static GIDFDMGKMNF LAGNOIFOJOH(GIDFDMGKMNF JPPPAGPDAOC, GIDFDMGKMNF EFINKFCEFNH)
	{
		return default(GIDFDMGKMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C1EC80", Offset = "0x1C1D680", VA = "0x181C1EC80")]
	public static GIDFDMGKMNF HJNAPLLDPDM(GIDFDMGKMNF CIBKKMKDKBC, GIDFDMGKMNF MJAKNAGHIFG)
	{
		return default(GIDFDMGKMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61FD5F0", Offset = "0x61FBFF0", VA = "0x1861FD5F0")]
	public static GIDFDMGKMNF EGKLFEECGJG(LPMMEKKKKHP MCBOOPLOBKP, GIDFDMGKMNF JIJLHBCAPOL)
	{
		return default(GIDFDMGKMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61FD600", Offset = "0x61FC000", VA = "0x1861FD600")]
	public static GIDFDMGKMNF GHJDCBMEOPD(LPMMEKKKKHP MCBOOPLOBKP, GIDFDMGKMNF JIJLHBCAPOL)
	{
		return default(GIDFDMGKMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61FD610", Offset = "0x61FC010", VA = "0x1861FD610")]
	public static bool MDAKOHEJKND(this GIDFDMGKMNF GJGHEJNGDCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61FD680", Offset = "0x61FC080", VA = "0x1861FD680")]
	public static bool OBFHEBAEBFN(this GIDFDMGKMNF GJGHEJNGDCL)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class GDHJCNELJKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GDHJCNELJKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x61FEC50", Offset = "0x61FD650", VA = "0x1861FEC50")]
			internal bool EBMCDIDLMKN(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x61FAA00", Offset = "0x61F9400", VA = "0x1861FAA00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x61FAA00", Offset = "0x61F9400", VA = "0x1861FAA00")]
		private void LIIMBGJIFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61FA8B0", Offset = "0x61F92B0", VA = "0x1861FA8B0")]
		private void JKJBCFDBKGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61FB410", Offset = "0x61F9E10", VA = "0x1861FB410")]
		public byte[] PFKDJONJCKH(string CIEAIBMHPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61FAA10", Offset = "0x61F9410", VA = "0x1861FAA10")]
		public bool LLJONLOBELF(SkinnedMeshBoneOrderData CJBCJEBIALI, AvatarSkinnedMeshBonesController EGLBHHGFOCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61FB480", Offset = "0x61F9E80", VA = "0x1861FB480")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NMKIOEHGNJO
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct AGKLDAJPLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Transform[] AHDOBGNDFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Matrix4x4[] NJPCCEBFPFH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly string ECDDIPDMBGO;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static AvatarSkinnedMeshBoneOrderRemapsData LOGHBALJCEL;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6200540", Offset = "0x61FEF40", VA = "0x186200540")]
	static NMKIOEHGNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62003C0", Offset = "0x61FEDC0", VA = "0x1862003C0")]
	public static AvatarSkinnedMeshBoneOrderRemapsData ILOFOONLBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61FFD00", Offset = "0x61FE700", VA = "0x1861FFD00")]
	public static byte[] DEAKIANPKLB(SkinnedMeshRenderer OKMLFCJEOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61FFFC0", Offset = "0x61FE9C0", VA = "0x1861FFFC0")]
	public static AGKLDAJPLCP? DLJIAFHBNHD(SkinnedMeshRenderer OKMLFCJEOLK)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string KEJLJNMHAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61FB550", Offset = "0x61F9F50", VA = "0x1861FB550")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61FBA20", Offset = "0x61FA420", VA = "0x1861FBA20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x61FB980", Offset = "0x61FA380", VA = "0x1861FB980")]
		private void JKJBCFDBKGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61FB580", Offset = "0x61F9F80", VA = "0x1861FB580")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum NLONEPGFDNM
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FOCDFAJHPPN
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly FOCDFAJHPPN GMHFJIOGOCL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GBPCNAMIFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C8780", Offset = "0x7C7180", VA = "0x1807C8780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NLONEPGFDNM JINKOEPHCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB60", Offset = "0xA6E560", VA = "0x180A6FB60")]
		[CompilerGenerated]
		get
		{
			return default(NLONEPGFDNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA6FBD0", Offset = "0xA6E5D0", VA = "0x180A6FBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FOCDFAJHPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23FC020", Offset = "0x23FAA20", VA = "0x1823FC020")]
	public FOCDFAJHPPN(NLONEPGFDNM MMMGCOBDJOC, int NDBOCLBFIKN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x61FEC40", Offset = "0x61FD640", VA = "0x1861FEC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61FE9B0", Offset = "0x61FD3B0", VA = "0x1861FE9B0")]
		public void JKMAKJCLPNI(FitMeshHemisphere BGBAOAEONIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61FE250", Offset = "0x61FCC50", VA = "0x1861FE250")]
		public Vector3 BOCGKCNOLBJ(Vector2 GNAHAPKPEBH, bool DFNLBKMHOPF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61FEA00", Offset = "0x61FD400", VA = "0x1861FEA00")]
		public Vector3 KJLADDAKFCG(Vector2 GNAHAPKPEBH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61FE670", Offset = "0x61FD070", VA = "0x1861FE670")]
		public Quaternion CPGPEHDPIJB(Vector2 GNAHAPKPEBH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61FE830", Offset = "0x61FD230", VA = "0x1861FE830")]
		public Quaternion CPGPEHDPIJB(Vector2 GNAHAPKPEBH, Vector3 EIJOFGCFHMK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61FE610", Offset = "0x61FD010", VA = "0x1861FE610")]
		public Vector2 CPBLDEKEDKM(Vector2 LOGPMEGCBHM)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61FEB90", Offset = "0x61FD590", VA = "0x1861FEB90")]
		public FitMeshHemisphere()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NKNNPPONHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC30", Offset = "0x61FE630", VA = "0x1861FFC30")]
	public static bool AGDGMHNKHHJ(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC50", Offset = "0x61FE650", VA = "0x1861FFC50")]
	public static bool DJBJDNJDCAD(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC80", Offset = "0x61FE680", VA = "0x1861FFC80")]
	public static bool HPJCGJJKKEJ(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61FFCD0", Offset = "0x61FE6D0", VA = "0x1861FFCD0")]
	public static bool OOGBBHHADMD(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC70", Offset = "0x61FE670", VA = "0x1861FFC70")]
	public static bool HICOODCALJP(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61FFCE0", Offset = "0x61FE6E0", VA = "0x1861FFCE0")]
	public static bool PHIKHPNKJII(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61FFCA0", Offset = "0x61FE6A0", VA = "0x1861FFCA0")]
	public static bool MJNADOMJEKM(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x61FFC90", Offset = "0x61FE690", VA = "0x1861FFC90")]
	public static bool KFBNCBGBMLF(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61FFCB0", Offset = "0x61FE6B0", VA = "0x1861FFCB0")]
	public static bool NIIELLBAONF(this OutfitType IONPEDJIDBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GEFGPALHOAL : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly GEFGPALHOAL AINFBDJPIJL;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61FEC80", Offset = "0x61FD680", VA = "0x1861FEC80", Slot = "4")]
	public bool Equals(OutfitType FIIOMOMOEMK, OutfitType FADPHBFLNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61FECE0", Offset = "0x61FD6E0", VA = "0x1861FECE0", Slot = "5")]
	public int GetHashCode(OutfitType CGEOAHHPHHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GEFGPALHOAL()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6200C40", Offset = "0x61FF640", VA = "0x186200C40")]
		public void HIPCKNEKCNB(SkinnedMeshRenderer OKMLFCJEOLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6200DF0", Offset = "0x61FF7F0", VA = "0x186200DF0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AFGPNKPILCE helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x61F9070", Offset = "0x61F7A70", VA = "0x1861F9070")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x61F8B70", Offset = "0x61F7570", VA = "0x1861F8B70", Slot = "8")]
		public override bool Equals(AdditionalHatData HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61F8D60", Offset = "0x61F7760", VA = "0x1861F8D60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61F8EC0", Offset = "0x61F78C0", VA = "0x1861F8EC0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61F9180", Offset = "0x61F7B80", VA = "0x1861F9180")]
		public static bool GBFGBPDOBCA(OutfitType CGEOAHHPHHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61F91A0", Offset = "0x61F7BA0", VA = "0x1861F91A0")]
		public static AdditionalOutfitTypeData HGOBECNKDLP(OutfitType CGEOAHHPHHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61F90F0", Offset = "0x61F7AF0", VA = "0x1861F90F0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData HKMMPHJFKEA);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61F94E0", Offset = "0x61F7EE0", VA = "0x1861F94E0", Slot = "6")]
		public virtual AdditionalOutfitTypeData JCNCJJKPAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C25550", Offset = "0x3C23F50", VA = "0x183C25550", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T HKMMPHJFKEA);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, PPFCIBKLACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public JHIKLGJHNGB beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9CC5D0", Offset = "0x9CAFD0", VA = "0x1809CC5D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public JHIKLGJHNGB PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110", Slot = "10")]
			get
			{
				return default(JHIKLGJHNGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61FBA30", Offset = "0x61FA430", VA = "0x1861FBA30", Slot = "8")]
		public override bool Equals(BeardData HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x61FBA50", Offset = "0x61FA450", VA = "0x1861FBA50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x61FBAC0", Offset = "0x61FA4C0", VA = "0x1861FBAC0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class HairData : AdditionalOutfitTypeData<HairData>, PPFCIBKLACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public JHIKLGJHNGB hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public HNFBLDHMJGO helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x882160", Offset = "0x880B60", VA = "0x180882160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public JHIKLGJHNGB PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7E0840", Offset = "0x7DF240", VA = "0x1807E0840", Slot = "10")]
			get
			{
				return default(JHIKLGJHNGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x61FF140", Offset = "0x61FDB40", VA = "0x1861FF140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61FED90", Offset = "0x61FD790", VA = "0x1861FED90", Slot = "8")]
		public override bool Equals(HairData HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61FEF80", Offset = "0x61FD980", VA = "0x1861FEF80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x61FF080", Offset = "0x61FDA80", VA = "0x1861FF080")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PPFCIBKLACO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool AOCFNIPGNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	JHIKLGJHNGB PEBNMBFLOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7CC6F0", Offset = "0x7CB0F0", VA = "0x1807CC6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9184F0", Offset = "0x916EF0", VA = "0x1809184F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA0DBE0", Offset = "0xA0C5E0", VA = "0x180A0DBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCAD540", Offset = "0xCABF40", VA = "0x180CAD540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCADDF0", Offset = "0xCAC7F0", VA = "0x180CADDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1D92920", Offset = "0x1D91320", VA = "0x181D92920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1D92930", Offset = "0x1D91330", VA = "0x181D92930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x128A750", Offset = "0x1289150", VA = "0x18128A750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6200C30", Offset = "0x61FF630", VA = "0x186200C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x21B4590", Offset = "0x21B2F90", VA = "0x1821B4590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x21B4720", Offset = "0x21B3120", VA = "0x1821B4720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x19A46A0", Offset = "0x19A30A0", VA = "0x1819A46A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x19A46D0", Offset = "0x19A30D0", VA = "0x1819A46D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xC93150", Offset = "0xC91B50", VA = "0x180C93150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xC9BC60", Offset = "0xC9A660", VA = "0x180C9BC60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public NMMOHFNHLCF ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x963310", Offset = "0x961D10", VA = "0x180963310")]
			[CompilerGenerated]
			get
			{
				return default(NMMOHFNHLCF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9E1FC0", Offset = "0x9E09C0", VA = "0x1809E1FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public FHDAOFFBFNF.GIDFDMGKMNF ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8D7030", Offset = "0x8D5A30", VA = "0x1808D7030")]
			[CompilerGenerated]
			get
			{
				return default(FHDAOFFBFNF.GIDFDMGKMNF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8D2420", Offset = "0x8D0E20", VA = "0x1808D2420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7C6950", Offset = "0x7C5350", VA = "0x1807C6950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xB019E0", Offset = "0xB003E0", VA = "0x180B019E0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x11FB4C0", Offset = "0x11F9EC0", VA = "0x1811FB4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xF24D20", Offset = "0xF23720", VA = "0x180F24D20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3D12970", Offset = "0x3D11370", VA = "0x183D12970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public SerializedAvatarItemData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x949E90", Offset = "0x948890", VA = "0x180949E90", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61FBB00", Offset = "0x61FA500", VA = "0x1861FBB00")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x61FD560", Offset = "0x61FBF60", VA = "0x1861FD560")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x61FD5C0", Offset = "0x61FBFC0", VA = "0x1861FD5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x61FD580", Offset = "0x61FBF80", VA = "0x1861FD580")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x61FD5D0", Offset = "0x61FBFD0", VA = "0x1861FD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xADF6A0", Offset = "0xADE0A0", VA = "0x180ADF6A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1844FD0", Offset = "0x18439D0", VA = "0x181844FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x61FD5A0", Offset = "0x61FBFA0", VA = "0x1861FD5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x61FD5E0", Offset = "0x61FBFE0", VA = "0x1861FD5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61FD150", Offset = "0x61FBB50", VA = "0x1861FD150", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61FD450", Offset = "0x61FBE50", VA = "0x1861FD450")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x61FE230", Offset = "0x61FCC30", VA = "0x1861FE230")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF69FF0", Offset = "0xF689F0", VA = "0x180F69FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB4E010", Offset = "0xB4CA10", VA = "0x180B4E010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xF6A100", Offset = "0xF68B00", VA = "0x180F6A100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61FDFF0", Offset = "0x61FC9F0", VA = "0x1861FDFF0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61FE130", Offset = "0x61FCB30", VA = "0x1861FE130")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x62011E0", Offset = "0x61FFBE0", VA = "0x1862011E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6201F40", Offset = "0x6200940", VA = "0x186201F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly List<NGGDDPJIFIN<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7C6900", Offset = "0x7C5300", VA = "0x1807C6900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x61FDF40", Offset = "0x61FC940", VA = "0x1861FDF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x61FDFB0", Offset = "0x61FC9B0", VA = "0x1861FDFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x61FDEF0", Offset = "0x61FC8F0", VA = "0x1861FDEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4F1ECF0", Offset = "0x4F1D6F0", VA = "0x184F1ECF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x4F1EEF0", Offset = "0x4F1D8F0", VA = "0x184F1EEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61FD9D0", Offset = "0x61FC3D0", VA = "0x1861FD9D0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61FDB10", Offset = "0x61FC510", VA = "0x1861FDB10", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61FDA40", Offset = "0x61FC440", VA = "0x1861FDA40")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x61FDBF0", Offset = "0x61FC5F0", VA = "0x1861FDBF0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61FD7C0", Offset = "0x61FC1C0", VA = "0x1861FD7C0")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61FDCF0", Offset = "0x61FC6F0", VA = "0x1861FDCF0")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class CBBDDFPEFMJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KFHHBBCCFKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public AsyncTaskMethodBuilder<CBBDDFPEFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private CNDCANKNEFB.HFEAAOGKOJO <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61FF5D0", Offset = "0x61FDFD0", VA = "0x1861FF5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61FFBB0", Offset = "0x61FE5B0", VA = "0x1861FFBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Dictionary<string, int> DOALHCPNCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private bool AFJEIGNAFKA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Texture2DArray MADIGDIEKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public SymmetricalFaceFeature NLFAAOBFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EyesFaceFeature JEGNFHKPMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public FaceFeature EDDONALKGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61FBB10", Offset = "0x61FA510", VA = "0x1861FBB10")]
	private static void CCBNDJPLHEJ(Sprite NMMHGONHEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61FC7A0", Offset = "0x61FB1A0", VA = "0x1861FC7A0")]
	public static CBBDDFPEFMJ POKLAJKFCIO(SymmetricalFaceFeature GDJJFEPEHIL, EyesFaceFeature NPHAMPIHGDD, FaceFeature GJLLFCAIPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61FBB80", Offset = "0x61FA580", VA = "0x1861FBB80")]
	[AsyncStateMachine(typeof(KFHHBBCCFKI))]
	public static Task<CBBDDFPEFMJ> DMFPKLNOMGA(SymmetricalFaceFeature GDJJFEPEHIL, EyesFaceFeature NPHAMPIHGDD, FaceFeature GJLLFCAIPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61FC830", Offset = "0x61FB230", VA = "0x1861FC830")]
	private CBBDDFPEFMJ(SymmetricalFaceFeature GDJJFEPEHIL, EyesFaceFeature NPHAMPIHGDD, FaceFeature GJLLFCAIPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61FBF60", Offset = "0x61FA960", VA = "0x1861FBF60")]
	private void KIMOAAOMIPB(List<Sprite> BNKCMCBALFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61FBD70", Offset = "0x61FA770", VA = "0x1861FBD70")]
	public bool JBOGENMDNGF(string KDACLLFGFDD, [Out] int ABBNIPHGMGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61FBCC0", Offset = "0x61FA6C0", VA = "0x1861FBCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61FC6B0", Offset = "0x61FB0B0", VA = "0x1861FC6B0")]
	public bool PCOPBBJPOGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61FBCF0", Offset = "0x61FA6F0", VA = "0x1861FBCF0")]
	public void GEEMHCFMJGG()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x882190", Offset = "0x880B90", VA = "0x180882190", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x61FE130", Offset = "0x61FCB30", VA = "0x1861FE130")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HANDPICLIOD SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9206E0", Offset = "0x91F0E0", VA = "0x1809206E0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FMIFMPDKCJC FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8B0F90", Offset = "0x8AF990", VA = "0x1808B0F90")]
			get
			{
				return default(FMIFMPDKCJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8A9600", Offset = "0x8A8000", VA = "0x1808A9600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8B14E0", Offset = "0x8AFEE0", VA = "0x1808B14E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6201160", Offset = "0x61FFB60", VA = "0x186201160")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD19BF0", Offset = "0xD185F0", VA = "0x180D19BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x62011A0", Offset = "0x61FFBA0", VA = "0x1862011A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x57F73E0", Offset = "0x57F5DE0", VA = "0x1857F73E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6201180", Offset = "0x61FFB80", VA = "0x186201180")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x57FA6A0", Offset = "0x57F90A0", VA = "0x1857FA6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x62011C0", Offset = "0x61FFBC0", VA = "0x1862011C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x57FA690", Offset = "0x57F9090", VA = "0x1857FA690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6200E80", Offset = "0x61FF880", VA = "0x186200E80", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6201090", Offset = "0x61FFA90", VA = "0x186201090")]
		protected SymmetricalFaceFeature()
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
