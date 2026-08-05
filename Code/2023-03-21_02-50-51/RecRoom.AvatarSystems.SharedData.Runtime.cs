using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AvatarSelectionElement : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string Guid;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61F5E90", Offset = "0x61F4690", VA = "0x1861F5E90")]
	public AvatarSelectionElement()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x61F5840", Offset = "0x61F4040", VA = "0x1861F5840")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61F5810", Offset = "0x61F4010", VA = "0x1861F5810")]
		public AnchorParams(Vector2 HAFFHHIHBOI, Vector3 EIBGGKJCMCG, Vector3 IIDAHPCNCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61F56A0", Offset = "0x61F3EA0", VA = "0x1861F56A0")]
		public AnchorParams(DGKMDGHKMJK HKMDDOJBIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61F55B0", Offset = "0x61F3DB0", VA = "0x1861F55B0", Slot = "4")]
		public bool Equals(AnchorParams HAKPJJGEGOM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DGKMDGHKMJK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CIFJHIPLEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FGFOIFHCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IGHHBIAPGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ACCGIFHPHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PPBJBAHCIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DFCFFONBBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LDGPPJMIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PPIMKHFMOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PDGKPLBEOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DLMIPHDJHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JAAKPNNPHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DMCDBKGPCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float JKFFLGKBMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float EMKGHDBDNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float BGANHDOHDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float DPBOPCDFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float BIMLCOKKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float OHAPCNKDOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float KPILPKCPJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float ALNNEPAOBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float KEMAAHOCODB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float FGNGFFOLMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LPEMKGAAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float KCJLLNIHIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 IGIGIMLEGGL(Vector3 IIDAHPCNCHH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IEFDPGNIHPM(Vector3 OEPPHHHEGLC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 EJDGAIPDFLJ();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 FJEKFLCCPCF();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : DGKMDGHKMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61F5520", Offset = "0x61F3D20", VA = "0x1861F5520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61F5550", Offset = "0x61F3D50", VA = "0x1861F5550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61F5580", Offset = "0x61F3D80", VA = "0x1861F5580", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61F5490", Offset = "0x61F3C90", VA = "0x1861F5490", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61F54C0", Offset = "0x61F3CC0", VA = "0x1861F54C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61F54F0", Offset = "0x61F3CF0", VA = "0x1861F54F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E90", Offset = "0x7F4690", VA = "0x1807F5E90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x118F400", Offset = "0x118DC00", VA = "0x18118F400", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1145040", Offset = "0x1143840", VA = "0x181145040", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x121B0D0", Offset = "0x12198D0", VA = "0x18121B0D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x139CAA0", Offset = "0x139B2A0", VA = "0x18139CAA0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x108B180", Offset = "0x1089980", VA = "0x18108B180", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x127AEB0", Offset = "0x12796B0", VA = "0x18127AEB0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x12966F0", Offset = "0x1294EF0", VA = "0x1812966F0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x12966E0", Offset = "0x1294EE0", VA = "0x1812966E0", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xF42370", Offset = "0xF40B70", VA = "0x180F42370", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xF422D0", Offset = "0xF40AD0", VA = "0x180F422D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1296720", Offset = "0x1294F20", VA = "0x181296720", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1296740", Offset = "0x1294F40", VA = "0x181296740", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1296730", Offset = "0x1294F30", VA = "0x181296730", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xFE5310", Offset = "0xFE3B10", VA = "0x180FE5310", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1714FD0", Offset = "0x17137D0", VA = "0x181714FD0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1652230", Offset = "0x1650A30", VA = "0x181652230", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61F5400", Offset = "0x61F3C00", VA = "0x1861F5400")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61F51C0", Offset = "0x61F39C0", VA = "0x1861F51C0")]
		public AnchorParams NLDGIFMOMKL(AnchorParams MFDKOEPMLJF)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61F5050", Offset = "0x61F3850", VA = "0x1861F5050", Slot = "30")]
		public Vector3 EJDGAIPDFLJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61F5070", Offset = "0x61F3870", VA = "0x1861F5070", Slot = "31")]
		public Vector3 FJEKFLCCPCF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61F5130", Offset = "0x61F3930", VA = "0x1861F5130", Slot = "28")]
		public Vector3 IGIGIMLEGGL(Vector3 IIDAHPCNCHH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61F5090", Offset = "0x61F3890", VA = "0x1861F5090", Slot = "29")]
		public Vector3 IEFDPGNIHPM(Vector3 OEPPHHHEGLC)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IICBJELIDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> NJBAGCKKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] EPPDHNLECFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> MMLAJEKFLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> MOAODHNFILK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] MKCAKHKCNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61F9650", Offset = "0x61F7E50", VA = "0x1861F9650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] OBPENMGJGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61F97F0", Offset = "0x61F7FF0", VA = "0x1861F97F0")]
	public void JMILOHCGJAK(SkinnedMeshRenderer KCFPMLMHLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61F96A0", Offset = "0x61F7EA0", VA = "0x1861F96A0")]
	public void DBJFBGIJAPK(Transform LALMBPEGKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61F9710", Offset = "0x61F7F10", VA = "0x1861F9710")]
	private Transform HDEIJMOPIIA(Transform CGDHEPNJCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61F9B10", Offset = "0x61F8310", VA = "0x1861F9B10")]
	public void LNBHJGNDINC(IICBJELIDEA JMNNLLCHLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61F99A0", Offset = "0x61F81A0", VA = "0x1861F99A0")]
	private void JNAOPICMIGH(Transform FECENBBKPOP, List<Transform> JNHJIHHGGKN, Dictionary<string, Transform> BIGACJPLHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61F9D90", Offset = "0x61F8590", VA = "0x1861F9D90")]
	public IICBJELIDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HGAECCJJANE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool AABGDFNDJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool AAGJKFFFPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool FPOFKMIEIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool ACFGPGHELBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool AKMEAJFOMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool POPCOHFAINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DKKPDJNNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<DNBHHFPLGEL> CPLNNHGAMFE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HGAECCJJANE()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum INALOFPMKLO
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private INALOFPMKLO useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x18185D0", Offset = "0x1816DD0", VA = "0x1818185D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0x9FF760", VA = "0x180A00F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x139CAA0", Offset = "0x139B2A0", VA = "0x18139CAA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x15BE8A0", Offset = "0x15BD0A0", VA = "0x1815BE8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x39E1B90", Offset = "0x39E0390", VA = "0x1839E1B90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDCE1E0", Offset = "0xDCC9E0", VA = "0x180DCE1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xF422D0", Offset = "0xF40AD0", VA = "0x180F422D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xF423B0", Offset = "0xF40BB0", VA = "0x180F423B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7CD330", Offset = "0x7CBB30", VA = "0x1807CD330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6EB760", Offset = "0x6E9F60", VA = "0x1806EB760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x75F020", Offset = "0x75D820", VA = "0x18075F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6D50B0", Offset = "0x6D38B0", VA = "0x1806D50B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7CD320", Offset = "0x7CBB20", VA = "0x1807CD320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6EB770", Offset = "0x6E9F70", VA = "0x1806EB770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x776AD0", Offset = "0x7752D0", VA = "0x180776AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7CD310", Offset = "0x7CBB10", VA = "0x1807CD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6EB700", Offset = "0x6E9F00", VA = "0x1806EB700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6FD860", Offset = "0x6FC060", VA = "0x1806FD860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6EB710", Offset = "0x6E9F10", VA = "0x1806EB710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x70CDB0", Offset = "0x70B5B0", VA = "0x18070CDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7116D0", Offset = "0x70FED0", VA = "0x1807116D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70CD90", Offset = "0x70B590", VA = "0x18070CD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84F5A0", Offset = "0x84DDA0", VA = "0x18084F5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84F8B0", Offset = "0x84E0B0", VA = "0x18084F8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public INALOFPMKLO UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x61F5DE0", Offset = "0x61F45E0", VA = "0x1861F5DE0")]
			get
			{
				return default(INALOFPMKLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8545C0", Offset = "0x852DC0", VA = "0x1808545C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBBE240", Offset = "0xBBCA40", VA = "0x180BBE240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBBE7E0", Offset = "0xBBCFE0", VA = "0x180BBE7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x61F5DC0", Offset = "0x61F45C0", VA = "0x1861F5DC0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x61F5E10", Offset = "0x61F4610", VA = "0x1861F5E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25CAFC0", Offset = "0x25C97C0", VA = "0x1825CAFC0")]
		public string ODHIHDMAPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x61F58B0", Offset = "0x61F40B0", VA = "0x1861F58B0")]
		public static AvatarCustomizationSettings JFCMHHFNDFE(string AOOIJHFKAJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61F5C00", Offset = "0x61F4400", VA = "0x1861F5C00")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EPPGHKHCLCO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GPNKPAIFJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Transform MFEILJOJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GameObject HKIMOELKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public SkinnedMeshRenderer[] OCENEAFOOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] GBHJHCMEOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject JIJMLDCAGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public SkinnedMeshRenderer[] DDKLPCKFIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] ABOPEBLPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] KMINCFENKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public IICBJELIDEA OLHELEHJMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material FOIKPMGIOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Shader KCLHCIOPOEG;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GEPEOMHHKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MeshRenderer POGJLMEKECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform PFEHGEBNIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform KDEKHINPGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform HHILLOGGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform JGKDALBGOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform BKNLIDNJCDA;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IADNMPLLCPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public MCIDJOBNMOP OKDINGLMGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int OIPCDGHHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int HKJHFBJELFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int GEJKDMJMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int NMHJLHJEDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int EJPHHMAKDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int KFMFDKKDNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int FBJIFJDJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float BCOIAAKBCLF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LHBJHIGKBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public MCIDJOBNMOP OKDINGLMGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Vector2 EIOIEMIPADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float PKAHBBPJHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector2 JFBPANOKNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float IALECPAFEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Vector2 FFAODLPJJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float BLMAAGHPFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float CDKOFJOMKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Vector2 LENCMFPOGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 JBFDDHLMKKE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DNBHHFPLGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public string ILMHEGPAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OutfitType MHIDOOOGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public IPLFEJPCNMM GMOMFOGGPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool GDLMLCIFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Color? ADBEDDJCACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3? FOKLPAKAMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float? CLNGNMIKIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Guid? PBIAOGIFEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Color? IOMPFIOBODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool IHKKAFAOOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool OOFDAOBKPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AnchorParamsRestrictions NBJMBFCKOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector2? ELFKGPKGJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform KOMEIDMBCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public FitMeshHemisphere OOFNBEHAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector2 OGPDCLNNBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<AvatarHairPatternOverride> EKHBJMJCGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Dictionary<string, Texture2D> HBPGINKJDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<AvatarHairPatternOverride> HBCLMOKCMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Dictionary<string, Texture2D> AAOEFBNLDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AssetReference CLJJLKLLNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference JMPPJCEONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference[] GNCEJBEFNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool FAFNFEJCEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool CGJFHOOAABD;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public List<AvatarHairPatternOverride> BKNHNGDHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EB750", Offset = "0x6E9F50", VA = "0x1806EB750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61F6880", Offset = "0x61F5080", VA = "0x1861F6880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public List<AvatarHairPatternOverride> HKGGHIOKLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x805840", Offset = "0x804040", VA = "0x180805840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61F6AB0", Offset = "0x61F52B0", VA = "0x1861F6AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string CKKAJIALKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61F6CE0", Offset = "0x61F54E0", VA = "0x1861F6CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61F6D90", Offset = "0x61F5590", VA = "0x1861F6D90")]
	public DNBHHFPLGEL()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AvatarItemMaterial : AvatarSelectionElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61F5E30", Offset = "0x61F4630", VA = "0x1861F5E30")]
		public static void KGBEBONMIII(AvatarItemMaterial FMPDMGDIPHA, Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61F5E90", Offset = "0x61F4690", VA = "0x1861F5E90")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FMKGECHLELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Mesh BEKEFOFCBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Material[] IHEBLNEJJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool NFOHMNJLBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool LHIKFMODHJH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	private FMKGECHLELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61F74A0", Offset = "0x61F5CA0", VA = "0x1861F74A0")]
	public FMKGECHLELO(Mesh AGOOLBLGOGP, Material[] LBPKNEHJFNJ, bool HAIPBMBNMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61F75B0", Offset = "0x61F5DB0", VA = "0x1861F75B0")]
	public FMKGECHLELO(SkinnedMeshRenderer MNCAOJHGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61F7130", Offset = "0x61F5930", VA = "0x1861F7130")]
	public static FMKGECHLELO EEAPCHMAILG(Renderer KCFPMLMHLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum KEMKDBCNDII
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FGFNBNONFPF
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum IPLFEJPCNMM
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GAIHHFHKLNF
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BGOCBBGONDL
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DNABJJHOJMO
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KEFFKNMFBPA
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GGPAGNDPLBH
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ALDHBJMACOA
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HJFFDFODPIL
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static readonly int GJBLAHJCBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61F8F20", Offset = "0x61F7720", VA = "0x1861F8F20")]
	public static NMECHIFBEAE ANJPNBEEHOK()
	{
		return default(NMECHIFBEAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61F9310", Offset = "0x61F7B10", VA = "0x1861F9310")]
	public static GOMJKBMEJEE NCEJIOMAGBG(Transform FPGHGBHIIDF, Transform LHHEGAJKBIH, AvatarConfiguration DGOBCDAOBOP, Animator INLILNMNNDC, VRIK HPBAOFLFLLC, SkeletonLODUpdateRate[] JCOGGNJNCML, GameObject[] PLKFLMLAPOO, Transform LIAJFKOAEMA, GameObject CACNAGDBGKG, BodySkinnedMeshLODs JEIBOCCLEAJ, BodySkinnedMeshLODs NJHAMANAJOB, GameObject MDBECMIJMLD, BodySkinnedMeshLODs MBHCHGHHAOG, BodySkinnedMeshLODs BPKKHMEINLE, BodySkinnedMeshLODs HPBFOMCKMLJ, IICBJELIDEA GBHJKANKCMO, Material JPCHPOEHICI, Shader KJPBHELNIEO, MeshRenderer ICHMIFDHFEE, Transform NECEFEAMBJH, Transform KLPOLGDPMGI, Transform OFGCNLOECLD, Transform IEJAINBHJIE, Transform ELGLNFBDOGL)
	{
		return default(GOMJKBMEJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61F9200", Offset = "0x61F7A00", VA = "0x1861F9200")]
	public static CPIPOJFEBKM MHPNLBPHIKI(string JGLEGHPHHEL, bool FGAOPCDADAB, bool BBEKONGEIPK, bool JOAIEOBAKKG, RigidbodyEx ECJLHFOOIMF, RigidbodyEx GPNNFGBDCOK, RigidbodyEx KHIAAFFHKID, RigidbodyEx KALBPKDALFA, Transform EAIOJGJMFEM, Transform MKDAAHHPIHG, Transform NIMCPBLOFHA, float LEJKGFDPGPF, float KFOKBIAMIDH, PlayerAvatarFullBodyColliders HCBJGDEEEJJ)
	{
		return default(CPIPOJFEBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61F8F50", Offset = "0x61F7750", VA = "0x1861F8F50")]
	public static GPNKPAIFJJL BGNCHOKGFBL(Transform LHHEGAJKBIH, GameObject CACNAGDBGKG, SkinnedMeshRenderer[] HBEBEKGCLBK, SkinnedMeshRenderer[] PIIHEKGMKKL, GameObject MDBECMIJMLD, SkinnedMeshRenderer[] PKEHLMHAOFG, SkinnedMeshRenderer[] NHMJOPGOBPL, SkinnedMeshRenderer[] JJAKABOFMOC, IICBJELIDEA GBHJKANKCMO, Material JPCHPOEHICI, Shader KJPBHELNIEO)
	{
		return default(GPNKPAIFJJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61F9160", Offset = "0x61F7960", VA = "0x1861F9160")]
	public static GEPEOMHHKJF IBAFOJJKHIA(MeshRenderer ICHMIFDHFEE, Transform NECEFEAMBJH, Transform OFGCNLOECLD, Transform KLPOLGDPMGI, Transform IEJAINBHJIE, Transform ELGLNFBDOGL)
	{
		return default(GEPEOMHHKJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61F90E0", Offset = "0x61F78E0", VA = "0x1861F90E0")]
	public static IADNMPLLCPJ IAFEBONFALM(MCIDJOBNMOP HOOHKMKJEMF, int DNJCNCOFDGC, int AAOLNMGDEPL, int LEJLEGPFMNL, int BIHKOFJIBNA, int DICHCAFKFNJ, int HDPLJLBKDIC, int IILMIIIFGFO, float JFBAOEMNNCL)
	{
		return default(IADNMPLLCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61F9050", Offset = "0x61F7850", VA = "0x1861F9050")]
	public static LHBJHIGKBKP HJFPLDEGBLC(MCIDJOBNMOP HOOHKMKJEMF, Vector2 JPGOKBLKPLI, float CEEJFMEAJEK, Vector2 NKCNNBJHGGC, float IKJOBNELKKM, Vector2 PHONABIHDDE, float COFMKKBDBNG)
	{
		return default(LHBJHIGKBKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KPFPECPLACG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Transform DMMBNEDLFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Vector3 LHBLNOLILHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JENDFBKBHGL : KPFPECPLACG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Transform DMMBNEDLFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 LHBLNOLILHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1058930", Offset = "0x1057130", VA = "0x181058930", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1058950", Offset = "0x1057150", VA = "0x181058950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float? FHMDPBKAIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1058970", Offset = "0x1057170", VA = "0x181058970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1058960", Offset = "0x1057160", VA = "0x181058960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JENDFBKBHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MACADOMOHEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly JENDFBKBHGL AGODDNHFMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly JENDFBKBHGL ECILBNMJANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	protected readonly JENDFBKBHGL KKBHBBNBKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly JENDFBKBHGL GCDDDNHDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly JENDFBKBHGL KDJGNADELJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly JENDFBKBHGL IBJLCJBHNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly JENDFBKBHGL NHLHGODMHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly JENDFBKBHGL BDFNDFJBEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly JENDFBKBHGL PJLHKOPAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly JENDFBKBHGL KAFFFLGHCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly JENDFBKBHGL NAKKFDIBAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly JENDFBKBHGL EPICCBGAABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly JENDFBKBHGL JEEOKEOGCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected JENDFBKBHGL FJLGDAOAKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly JENDFBKBHGL MBIEABLLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly JENDFBKBHGL CCPEFJCGNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected readonly JENDFBKBHGL AMACCHIPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected JENDFBKBHGL BGJJHOHHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly JENDFBKBHGL CAOGGJHDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly JENDFBKBHGL BGPGFBAMEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly JENDFBKBHGL CLJNMJCHCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected ReadOnlyCollection<JENDFBKBHGL> NPOJDLKKOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Transform LIAJFKOAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private (JENDFBKBHGL Start, JENDFBKBHGL End)[] GKEBBGEDHJC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public KPFPECPLACG FMBDFCOMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KPFPECPLACG ALEHJGLKAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public KPFPECPLACG NMGEGDEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public KPFPECPLACG LIIHIALHOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public KPFPECPLACG BMACOICGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KPFPECPLACG OLLKCDOFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public KPFPECPLACG MEJKLPOLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public JENDFBKBHGL ANOAMECGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public KPFPECPLACG JOCMFEFFBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JENDFBKBHGL JPCENHLKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KPFPECPLACG GECIAHMFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB760", Offset = "0x6E9F60", VA = "0x1806EB760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KPFPECPLACG DAOAEONCKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D50B0", Offset = "0x6D38B0", VA = "0x1806D50B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public KPFPECPLACG IOAADBECHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EB770", Offset = "0x6E9F70", VA = "0x1806EB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JENDFBKBHGL IKNFPGJHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6EB770", Offset = "0x6E9F70", VA = "0x1806EB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JENDFBKBHGL HHMIONDNFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KPFPECPLACG FCPJHGJAAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public KPFPECPLACG KKLBAHCPILE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EB700", Offset = "0x6E9F00", VA = "0x1806EB700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public KPFPECPLACG KGEONBLLKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EB710", Offset = "0x6E9F10", VA = "0x1806EB710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public KPFPECPLACG AEAPEPMIOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7116D0", Offset = "0x70FED0", VA = "0x1807116D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public KPFPECPLACG HPPEGHHMDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD80", Offset = "0x6DA580", VA = "0x1806DBD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public KPFPECPLACG PLGEECEACEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE20", Offset = "0x6DA620", VA = "0x1806DBE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public KPFPECPLACG EPIMNPCJOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7116A0", Offset = "0x70FEA0", VA = "0x1807116A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KPFPECPLACG MODHPCKLFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EB720", Offset = "0x6E9F20", VA = "0x1806EB720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KPFPECPLACG KLNDMFJFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EB730", Offset = "0x6E9F30", VA = "0x1806EB730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KPFPECPLACG BCDDJLCNFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EB750", Offset = "0x6E9F50", VA = "0x1806EB750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IReadOnlyList<KPFPECPLACG> HFAPLOGPNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EB740", Offset = "0x6E9F40", VA = "0x1806EB740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61FA340", Offset = "0x61F8B40", VA = "0x1861FA340")]
	public void DPGABKABJAG(VRIK ELPHKKOCJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x217DE80", Offset = "0x217C680", VA = "0x18217DE80")]
	private void MMDCNEILGMJ(Transform KJFIHMLIKBG, JENDFBKBHGL DJDDCFICJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61F9E90", Offset = "0x61F8690", VA = "0x1861F9E90")]
	public void DAFMGHCFCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2179E60", Offset = "0x2178660", VA = "0x182179E60")]
	public float CJFOGGIPBAI(in (JENDFBKBHGL Start, JENDFBKBHGL End) IIDMCEAOINO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61FAE80", Offset = "0x61F9680", VA = "0x1861FAE80")]
	public void PGIGFGPJLHD(in NMECHIFBEAE DMJFIAAGODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61FAD30", Offset = "0x61F9530", VA = "0x1861FAD30")]
	private Vector3 IOMIKNDNOFO(in (JENDFBKBHGL Start, JENDFBKBHGL End) IIDMCEAOINO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61FB060", Offset = "0x61F9860", VA = "0x1861FB060")]
	public MACADOMOHEN()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x61F5F50", Offset = "0x61F4750", VA = "0x1861F5F50")]
		public string GJOEBHOBMII(string CIKAIACMJLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61F5FA0", Offset = "0x61F47A0", VA = "0x1861F5FA0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CPIPOJFEBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public string EDJMBFFBPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public bool APOEADBKMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public bool GDJJNFCEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public float BMPIOEELMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public float EGMGGJKIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool KMGPNCPFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public RigidbodyEx EBCJKDLFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public RigidbodyEx PCIEFLDPAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public RigidbodyEx PFCDKCDDCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx MDIJMHOHLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform NKKDLDFMFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform GHIAHAMLKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform EAIEIAEKNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public PlayerAvatarFullBodyColliders EGBAHONOEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GOMJKBMEJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform CMFHABDLBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform JBAEICJKFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public AvatarConfiguration OFDLEMLJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Animator POJODEBOCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public VRIK FNHBOBLLMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public SkeletonLODUpdateRate[] NANBPCBEELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public GameObject[] BKIBBLMLJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform GFOPICFDJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public GameObject HKIMOELKIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public BodySkinnedMeshLODs DHCKPKFBPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public BodySkinnedMeshLODs POIHHHBNOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject JIJMLDCAGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs BDBNBFLBNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs BJFFKOEGJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public BodySkinnedMeshLODs JJHALICLEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public IICBJELIDEA OLHELEHJMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Material FOIKPMGIOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Shader KCLHCIOPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public MeshRenderer POGJLMEKECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Transform PFEHGEBNIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Transform HHILLOGGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform KDEKHINPGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform JGKDALBGOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Transform BKNLIDNJCDA;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NMECHIFBEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public float NJGPFPNEHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool ECOCIDPBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public EPPGHKHCLCO KLGFIEFGDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 EJGLFFACCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 KCKLDFEDLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3? CKMMMCIJBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3? AHACIIPAIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool NEFJHMGGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool HNCMLLKBKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool HDMHKDOENBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool EDKLELPCINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool JLIEPBCFAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Vector3? JMOCJEJFPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool GAKDDMPNPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? PKNFDFJBOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool CFJLCICLGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? BHAPMBPMKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3? ACOOEPHHMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool ICCMAFILBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public bool DNEKMINKCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool MHCNDNLFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool JKNACKIBEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool CFBDKOBKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool OAAJEDBJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool JHNKHINKGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool AJBOBABJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool DAJFJJHNNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool JGANFMLOPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public Vector3? FBMEBPNAPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public KEMKDBCNDII EPLOEGDEDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public KEMKDBCNDII CPLBLNBPBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public float LJAJPDKKKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public float IABKELNLEEP;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DEPEPHHJCED
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COKKHHHJAIF();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::FHFGABMPMPC<Texture2D> DNMGKMAEONF(NOAAFNFJPFB BIFPNCNNHBL, [Optional] FENLAOOMDFM NDEGHHCMGIN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DNAGIMDNADA : DEPEPHHJCED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private HBIPFDANKCE IOKGGDFBAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private IRecRoomQualityConfigProvider GBKHPIHELAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool MCHDACLOABN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private const uint ACIPJIILIBD = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61F6060", Offset = "0x61F4860", VA = "0x1861F6060")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	private static void AAFDAINMAIC(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	[Preserve]
	public DNAGIMDNADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61F67D0", Offset = "0x61F4FD0", VA = "0x1861F67D0")]
	private void PJMEBOFHHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61F6150", Offset = "0x61F4950", VA = "0x1861F6150", Slot = "4")]
	public void COKKHHHJAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61F61B0", Offset = "0x61F49B0", VA = "0x1861F61B0", Slot = "5")]
	public global::FHFGABMPMPC<Texture2D> DNMGKMAEONF(NOAAFNFJPFB BIFPNCNNHBL, [Optional] FENLAOOMDFM NDEGHHCMGIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x61F65C0", Offset = "0x61F4DC0", VA = "0x1861F65C0")]
	private uint EHDKKMEADJB(NOAAFNFJPFB BIFPNCNNHBL, FENLAOOMDFM NDEGHHCMGIN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum OGCFAIIGDAM
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FENLAOOMDFM
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly FENLAOOMDFM KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int AMNPLJBKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F30", Offset = "0x6F4730", VA = "0x1806F5F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OGCFAIIGDAM EGACFHDOBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790")]
		[CompilerGenerated]
		get
		{
			return default(OGCFAIIGDAM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x91F260", Offset = "0x91DA60", VA = "0x18091F260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FENLAOOMDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61F70F0", Offset = "0x61F58F0", VA = "0x1861F70F0")]
	public FENLAOOMDFM(OGCFAIIGDAM BCBFMICMNIP, int AOFAKIANJJM)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x61F8F10", Offset = "0x61F7710", VA = "0x1861F8F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x61F8E50", Offset = "0x61F7650", VA = "0x1861F8E50")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x61F8C30", Offset = "0x61F7430", VA = "0x1861F8C30")]
		public void KPJBBGDOGLP(FitMeshHemisphere ENCEHPNHJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x61F8650", Offset = "0x61F6E50", VA = "0x1861F8650")]
		public Vector3 DKEFKNOGPNJ(Vector2 APJDAGAAOME, bool CENMAGIEBPF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61F8990", Offset = "0x61F7190", VA = "0x1861F8990")]
		public Vector3 FHHICKLPBAE(Vector2 APJDAGAAOME)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x61F8B00", Offset = "0x61F7300", VA = "0x1861F8B00")]
		public Quaternion JKBFNFALODB(Vector2 APJDAGAAOME)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x61F89F0", Offset = "0x61F71F0", VA = "0x1861F89F0")]
		public Quaternion JKBFNFALODB(Vector2 APJDAGAAOME, Vector3 NOGDJGEDEON)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x61F8C80", Offset = "0x61F7480", VA = "0x1861F8C80")]
		private Vector2 LBGJGCBLMHA(Vector2 KIDHHMHPKPE)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct OLPPLFNHNJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public readonly GameObject PDLOCGKKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public readonly AvatarItemMaterial NGFCDBDNJDA;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x785A30", Offset = "0x784230", VA = "0x180785A30")]
	public OLPPLFNHNJJ(GameObject PDLOCGKKNJM, AvatarItemMaterial NGFCDBDNJDA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NHIDMOEFLLB
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x61FC430", Offset = "0x61FAC30", VA = "0x1861FC430")]
	public static bool CDOABKCGHCL(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x61FC450", Offset = "0x61FAC50", VA = "0x1861FC450")]
	public static bool FKBHOLJDBGF(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61FC480", Offset = "0x61FAC80", VA = "0x1861FC480")]
	public static bool JMDIFHFDCKC(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61FC490", Offset = "0x61FAC90", VA = "0x1861FC490")]
	public static bool NLALPNGHIHG(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61FC470", Offset = "0x61FAC70", VA = "0x1861FC470")]
	public static bool HBFJCIJOCKO(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61FC420", Offset = "0x61FAC20", VA = "0x1861FC420")]
	public static bool ABBMBJLNLHI(this OutfitType EFKGDFLIABK)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IICBJELIDEA AINKPCPABIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private Collider[] JKHNKDHGIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private Collider[] BFGABFADMMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x61FCAD0", Offset = "0x61FB2D0", VA = "0x1861FCAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61FCB40", Offset = "0x61FB340", VA = "0x1861FCB40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61FCD10", Offset = "0x61FB510", VA = "0x1861FCD10")]
		public void UpdateBones(IICBJELIDEA GBHJKANKCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61FCBC0", Offset = "0x61FB3C0", VA = "0x1861FCBC0")]
		public void SetCollidersEnabled(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61FCD40", Offset = "0x61FB540", VA = "0x1861FCD40")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6F0290", Offset = "0x6EEA90", VA = "0x1806F0290", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61F5FF0", Offset = "0x61F47F0", VA = "0x1861F5FF0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61F5FF0", Offset = "0x61F47F0", VA = "0x1861F5FF0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x61F79F0", Offset = "0x61F61F0", VA = "0x1861F79F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x807F50", Offset = "0x806750", VA = "0x180807F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x14C8BE0", Offset = "0x14C73E0", VA = "0x1814C8BE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xFF9210", Offset = "0xFF7A10", VA = "0x180FF9210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61F78C0", Offset = "0x61F60C0", VA = "0x1861F78C0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61F7970", Offset = "0x61F6170", VA = "0x1861F7970")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x61F78A0", Offset = "0x61F60A0", VA = "0x1861F78A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x45C5750", Offset = "0x45C3F50", VA = "0x1845C5750")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xE995D0", Offset = "0xE97DD0", VA = "0x180E995D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61F76D0", Offset = "0x61F5ED0", VA = "0x1861F76D0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61F7740", Offset = "0x61F5F40", VA = "0x1861F7740", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61F77C0", Offset = "0x61F5FC0", VA = "0x1861F77C0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class MCIDJOBNMOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class IFHKHALLCFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public readonly Texture2DArray PEIBJDBDKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public readonly Dictionary<string, int> HIEPEKNFFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly BGPIKFBGOJB PBJFCLOFGKB;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool KCHPPFGMCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x110B560", Offset = "0x1109D60", VA = "0x18110B560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61F9580", Offset = "0x61F7D80", VA = "0x1861F9580")]
		public IFHKHALLCFL(Texture2DArray MPNHCLKMBAO, Dictionary<string, int> CNGHLPHLCME, MCIDJOBNMOP IGIIEOPBNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1109290", Offset = "0x1107A90", VA = "0x181109290")]
		public void DNAPFGIHGNH(MCIDJOBNMOP JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x110B1E0", Offset = "0x11099E0", VA = "0x18110B1E0")]
		public void FKPBEJBKJIN(MCIDJOBNMOP JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x13C97B0", Offset = "0x13C7FB0", VA = "0x1813C97B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct EIDHDIHGNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly string PGBOCNILBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly string EHIHCNAAKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string LPJPKOICMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly string CJEOJDHGKLK;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x57A2580", Offset = "0x57A0D80", VA = "0x1857A2580")]
		public EIDHDIHGNOM(string ONCFFDPCGFB, string EEPOCKKMEGB, string LLABOCPJAHH, string ILODEGCCMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61F6E80", Offset = "0x61F5680", VA = "0x1861F6E80")]
		public bool GKAHDDHENKO(EIDHDIHGNOM HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61F6DA0", Offset = "0x61F55A0", VA = "0x1861F6DA0", Slot = "0")]
		public override bool Equals(object BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F10", Offset = "0x61F5710", VA = "0x1861F6F10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x61F6E80", Offset = "0x61F5680", VA = "0x1861F6E80")]
		public static bool GLPMECKCBFF(EIDHDIHGNOM NCBNFILGGOG, EIDHDIHGNOM NMABHKKNANH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x61F6FE0", Offset = "0x61F57E0", VA = "0x1861F6FE0")]
		public static bool PKJGEKBKGNO(EIDHDIHGNOM NCBNFILGGOG, EIDHDIHGNOM NMABHKKNANH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly Dictionary<string, int> CNGHLPHLCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly EIDHDIHGNOM EFKPAFLFPAD;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture2DArray ALAGBJHDDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public SymmetricalFaceFeature BNPFFIHLKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public SymmetricalFaceFeature NPFCOBAMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature NLACMNECHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FaceFeature NDGLJKHDCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61FB400", Offset = "0x61F9C00", VA = "0x1861FB400")]
	private static void AIEHJGHAPOK(Sprite AKMKEGMJAOL, Sprite KNEFEKNEEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61FB510", Offset = "0x61F9D10", VA = "0x1861FB510")]
	private static void GOEGGKHAHAM(Sprite IHDGAKGGNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x61FB790", Offset = "0x61F9F90", VA = "0x1861FB790")]
	public MCIDJOBNMOP(SymmetricalFaceFeature ANPAOAHODLL, FaceFeature LPKENPCNHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61FB7C0", Offset = "0x61F9FC0", VA = "0x1861FB7C0")]
	public MCIDJOBNMOP(SymmetricalFaceFeature LMPKLOAOBEH, SymmetricalFaceFeature ANPAOAHODLL, SymmetricalFaceFeature NPLPCNAGPNG, FaceFeature LPKENPCNHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61FB580", Offset = "0x61F9D80", VA = "0x1861FB580")]
	public bool HANCJJLMJNC(Sprite IHDGAKGGNKB, out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61FB500", Offset = "0x61F9D00", VA = "0x1861FB500", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		EyeGleams = 4,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public SymmetricalFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public SymmetricalFaceFeature[] EyeGleams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Dictionary<string, SymmetricalFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<string, SymmetricalFaceFeature> eyeGleamFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x61F8620", Offset = "0x61F6E20", VA = "0x1861F8620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x61F7E10", Offset = "0x61F6610", VA = "0x1861F7E10")]
		public MCIDJOBNMOP FGHNOKLDOKO(int ANPAOAHODLL, int LPKENPCNHKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61F7B90", Offset = "0x61F6390", VA = "0x1861F7B90")]
		public MCIDJOBNMOP FGHNOKLDOKO(int MAJKGNOLJHG, int ANPAOAHODLL, int FIMBHHGODJN, int LPKENPCNHKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x61F8230", Offset = "0x61F6A30", VA = "0x1861F8230")]
		public FaceFeatureBase NJAFKEHJEID(FaceFeatureType DEKDCNKEALB, string CNMALJMHIOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61F80B0", Offset = "0x61F68B0", VA = "0x1861F80B0")]
		public int HAOMEPJEGBD(string CNMALJMHIOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x61F83C0", Offset = "0x61F6BC0", VA = "0x1861F83C0")]
		private void OLLJNICKALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x269AA90", Offset = "0x2699290", VA = "0x18269AA90")]
		private void DMLIPJKEMDH<T>(Dictionary<string, T> OCGEHIBMPLA, T[] ANOENCMCCGE) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x61F8140", Offset = "0x61F6940", VA = "0x1861F8140")]
		public string IGMJHOFFNCF(FaceFeatureType DEKDCNKEALB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x61F7A10", Offset = "0x61F6210", VA = "0x1861F7A10")]
		public string AIBINMLBLDL(FaceFeatureType DEKDCNKEALB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x61F85A0", Offset = "0x61F6DA0", VA = "0x1861F85A0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAA0", Offset = "0x6FA2A0", VA = "0x1806FBAA0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x61FC410", Offset = "0x61FAC10", VA = "0x1861FC410")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6F02A0", Offset = "0x6EEAA0", VA = "0x1806F02A0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x61FC410", Offset = "0x61FAC10", VA = "0x1861FC410")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x61FCFA0", Offset = "0x61FB7A0", VA = "0x1861FCFA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4379220", Offset = "0x4377A20", VA = "0x184379220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1296700", Offset = "0x1294F00", VA = "0x181296700")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4379210", Offset = "0x4377A10", VA = "0x184379210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x12966C0", Offset = "0x1294EC0", VA = "0x1812966C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3B57EE0", Offset = "0x3B566E0", VA = "0x183B57EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x1296620", Offset = "0x1294E20", VA = "0x181296620")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x61FCFC0", Offset = "0x61FB7C0", VA = "0x1861FCFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x61FCE90", Offset = "0x61FB690", VA = "0x1861FCE90", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x61F5FF0", Offset = "0x61F47F0", VA = "0x1861F5FF0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61FC7F0", Offset = "0x61FAFF0", VA = "0x1861FC7F0")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61FC4A0", Offset = "0x61FACA0", VA = "0x1861FC4A0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
