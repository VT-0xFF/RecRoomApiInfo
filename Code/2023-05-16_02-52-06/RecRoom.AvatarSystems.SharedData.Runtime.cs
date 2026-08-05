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
	[Cpp2IlInjected.Address(RVA = "0x6711720", Offset = "0x6710520", VA = "0x186711720")]
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
			[Cpp2IlInjected.Address(RVA = "0x6711130", Offset = "0x670FF30", VA = "0x186711130")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6710F90", Offset = "0x670FD90", VA = "0x186710F90")]
		public AnchorParams(Vector2 BGDFKCILJLB, Vector3 GLPLKOJHJIA, Vector3 NHINACGKMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6710FC0", Offset = "0x670FDC0", VA = "0x186710FC0")]
		public AnchorParams(POMDFPOKGIH HPEKDCKDKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6710EA0", Offset = "0x670FCA0", VA = "0x186710EA0", Slot = "4")]
		public bool Equals(AnchorParams IDBPJJAKCBN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface POMDFPOKGIH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DAGMOFAAAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HOGJPHJFANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FFCPBJIIFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LANCBJBFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MCKNGGLIEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NNMNCDJECJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DAJCJEJNPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NJNCCFOHMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float DOABINAKOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float ABNEECCFEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JACAHPDNPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float PLPPNJLDAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LLDMPOIBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float CMDJFAIEOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CEHIAEPDFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float BNFNMIBHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float GCMBHOPGIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float GDMOLFBKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float GIFDFAJKEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float GCPHHOIFOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float CJACPLLLCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float BEPPBDPNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float NFNDBDACDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float GNDEOGEMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 EALDGLIIEOC(Vector3 NHINACGKMIN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FICCLBBKHKB(Vector3 CPCAPMPGJCG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 NGHMDMEFONI();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 HFIJALJEFLD();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : POMDFPOKGIH
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
			[Cpp2IlInjected.Address(RVA = "0x6710E10", Offset = "0x670FC10", VA = "0x186710E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6710E40", Offset = "0x670FC40", VA = "0x186710E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6710E70", Offset = "0x670FC70", VA = "0x186710E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6710D80", Offset = "0x670FB80", VA = "0x186710D80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6710DB0", Offset = "0x670FBB0", VA = "0x186710DB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6710DE0", Offset = "0x670FBE0", VA = "0x186710DE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7C8A60", Offset = "0x7C7860", VA = "0x1807C8A60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x10A4E10", Offset = "0x10A3C10", VA = "0x1810A4E10", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x10A4E00", Offset = "0x10A3C00", VA = "0x1810A4E00", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xFBD7A0", Offset = "0xFBC5A0", VA = "0x180FBD7A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x113CED0", Offset = "0x113BCD0", VA = "0x18113CED0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1247E20", Offset = "0x1246C20", VA = "0x181247E20", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x15557A0", Offset = "0x15545A0", VA = "0x1815557A0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x171C780", Offset = "0x171B580", VA = "0x18171C780", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x171C770", Offset = "0x171B570", VA = "0x18171C770", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x120EC60", Offset = "0x120DA60", VA = "0x18120EC60", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x116A3D0", Offset = "0x11691D0", VA = "0x18116A3D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x171C7B0", Offset = "0x171B5B0", VA = "0x18171C7B0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x14BB1C0", Offset = "0x14B9FC0", VA = "0x1814BB1C0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x145A520", Offset = "0x1459320", VA = "0x18145A520", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A31C60", Offset = "0x1A30A60", VA = "0x181A31C60", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x17ACBF0", Offset = "0x17AB9F0", VA = "0x1817ACBF0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x17ACC40", Offset = "0x17ABA40", VA = "0x1817ACC40", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6710CF0", Offset = "0x670FAF0", VA = "0x186710CF0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6710A70", Offset = "0x670F870", VA = "0x186710A70")]
		public AnchorParams GDOHLEMFMJP(AnchorParams ABDKOMPCMIG)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6710CD0", Offset = "0x670FAD0", VA = "0x186710CD0", Slot = "30")]
		public Vector3 NGHMDMEFONI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6710CB0", Offset = "0x670FAB0", VA = "0x186710CB0", Slot = "31")]
		public Vector3 HFIJALJEFLD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6710940", Offset = "0x670F740", VA = "0x186710940", Slot = "28")]
		public Vector3 EALDGLIIEOC(Vector3 NHINACGKMIN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67109D0", Offset = "0x670F7D0", VA = "0x1867109D0", Slot = "29")]
		public Vector3 FICCLBBKHKB(Vector3 CPCAPMPGJCG)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MHLDENCAHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> APIJBNAMJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] CKBEBOBFCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> HEFMDMGGBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> MDGBGHAAHMF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] NIMFDAHDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6717190", Offset = "0x6715F90", VA = "0x186717190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] GDGBEAAGDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6716E70", Offset = "0x6715C70", VA = "0x186716E70")]
	public void CKFGJHIHBFL(SkinnedMeshRenderer KHMNCIMCHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6717540", Offset = "0x6716340", VA = "0x186717540")]
	public void PFMHLIOOPOC(Transform AFIDPDCMKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67171E0", Offset = "0x6715FE0", VA = "0x1867171E0")]
	private Transform LOJCGMIPAHE(Transform IHIMGDKDDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67172C0", Offset = "0x67160C0", VA = "0x1867172C0")]
	public void NIOAMKMBOJP(MHLDENCAHGA PLJNGKBPIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6717020", Offset = "0x6715E20", VA = "0x186717020")]
	private void ENCCDOGOODO(Transform LFLMFMLCFKL, List<Transform> DEPKPJPMGDM, Dictionary<string, Transform> IJMCDPPIPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67175B0", Offset = "0x67163B0", VA = "0x1867175B0")]
	public MHLDENCAHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IJKPEJKOEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool HFBALAJLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool BGCIKJBOCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool MOMOMNKFIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool CFMBGIJMNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool KMOJCGCJHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool FNBGKNKJEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool JKKDJMJLFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<PDHLIOOGGKP> IPEKOMEGHAH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IJKPEJKOEFM()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum NALIGAPLFKP
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private NALIGAPLFKP useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1FFBE00", Offset = "0x1FFAC00", VA = "0x181FFBE00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A270", Offset = "0xA59070", VA = "0x180A5A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x113CED0", Offset = "0x113BCD0", VA = "0x18113CED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x151D920", Offset = "0x151C720", VA = "0x18151D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3BC3F60", Offset = "0x3BC2D60", VA = "0x183BC3F60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE3F740", Offset = "0xE3E540", VA = "0x180E3F740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x116A3D0", Offset = "0x11691D0", VA = "0x18116A3D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x120EC70", Offset = "0x120DA70", VA = "0x18120EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x850A00", Offset = "0x84F800", VA = "0x180850A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5B82720", Offset = "0x5B81520", VA = "0x185B82720")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x97DB60", Offset = "0x97C960", VA = "0x18097DB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x14BB1C0", Offset = "0x14B9FC0", VA = "0x1814BB1C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1E45AC0", Offset = "0x1E448C0", VA = "0x181E45AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA1B0", Offset = "0x7F8FB0", VA = "0x1807FA1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8509E0", Offset = "0x84F7E0", VA = "0x1808509E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x757890", Offset = "0x756690", VA = "0x180757890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x7687F0", VA = "0x1807699F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7578A0", Offset = "0x7566A0", VA = "0x1807578A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x778F40", Offset = "0x777D40", VA = "0x180778F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C660", VA = "0x18077D860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x778F20", Offset = "0x777D20", VA = "0x180778F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7483B0", Offset = "0x7471B0", VA = "0x1807483B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x94CF40", Offset = "0x94BD40", VA = "0x18094CF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x748450", Offset = "0x747250", VA = "0x180748450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C04C0", VA = "0x1808C16C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x77D830", Offset = "0x77C630", VA = "0x18077D830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x94C560", Offset = "0x94B360", VA = "0x18094C560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB2BA50", Offset = "0xB2A850", VA = "0x180B2BA50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB2BA60", Offset = "0xB2A860", VA = "0x180B2BA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public NALIGAPLFKP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x67115D0", Offset = "0x67103D0", VA = "0x1867115D0")]
			get
			{
				return default(NALIGAPLFKP);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x13EFBE0", Offset = "0x13EE9E0", VA = "0x1813EFBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x13B8730", Offset = "0x13B7530", VA = "0x1813B8730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x13B5C80", Offset = "0x13B4A80", VA = "0x1813B5C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x67115B0", Offset = "0x67103B0", VA = "0x1867115B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x67116A0", Offset = "0x67104A0", VA = "0x1867116A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x874F00", Offset = "0x873D00", VA = "0x180874F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x874FF0", Offset = "0x873DF0", VA = "0x180874FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6711600", Offset = "0x6710400", VA = "0x186711600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x25A24D0", Offset = "0x25A12D0", VA = "0x1825A24D0")]
		public string EPOBOPBJBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67111A0", Offset = "0x670FFA0", VA = "0x1867111A0")]
		public static AvatarCustomizationSettings BPPOCFBLMGN(string DNAIGHGJNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6711340", Offset = "0x6710140", VA = "0x186711340")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FLDAKNOJEGK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PKMHPLKENBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Transform ADNEHNPNMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject NCNNFGOMFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] KKEABPFDKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] AEPGEBLNMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GameObject FGKLDNGICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public SkinnedMeshRenderer[] GBNBOCANKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public SkinnedMeshRenderer[] CNJKMHOKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MHLDENCAHGA JFGIEMLJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Material BOLHBDLCBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Material LLKONDCBEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Shader GDNCANFJKAN;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EGLFEAMHGPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform AELMCAGIMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform JOFOFHMBFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform KBHAEJLMOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform MIJIKLGMCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform NFKBHAFFBJA;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EELLBDNHLBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public SkinnedMeshRenderer[] PIPIHACMBNM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LEGJNCLPMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public FFKLNPFPBHM IDEGKNIMEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int HEGEKLOGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int MCJGEBHOFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Color LMKIMJPPGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Color DLKGNDPLPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int DICLBMOIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int EMJNMLPBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color EKPCKKEHHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color EENHAMMDLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public int DBGMNCOGAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float GOLMDGBBICL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FMEIEGMNCKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public FFKLNPFPBHM IDEGKNIMEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Vector2 BJOCAHAOFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float LJHIGGFJJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 CILHGFJAOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float PBIIGOGPJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector2 GPCNJGAADOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float NIDJPCAPNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float PIDNPAOFFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector2 HMDABKHEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector2 EDKANFJPKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool EILANIBIGOA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PDHLIOOGGKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string JAGOKEMFLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public OutfitType BDFLDHMAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public OFJLBDEAIBL AICKJKANFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool IMHEKPFGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Color? JBPNONGKAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector3? NBIIHNAGOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float? OICMAENGOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Guid? KFFAPHBBEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DPCCPIFEEED? EMKCFKANJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Color? EMCEPJJIFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool ONLIJKKJEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool FLKDIBKNBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AnchorParamsRestrictions MMFHFAIAPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Vector2? DHEECHDOABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform HIJLAMEMBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public FitMeshHemisphere LLOPPPCIHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Vector2 PGOIFCFFKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<AvatarHairPatternOverride> MFELODNMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<string, Texture2D> JANGBCJLABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private List<AvatarHairPatternOverride> BGJEEPCIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Dictionary<string, Texture2D> LPNALBPAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AssetReference BIPCODGGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AssetReference GJNHFBENAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AssetReference[] EBPGNACHCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool HLOOHNHJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool NIGBLKBPENP;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public List<AvatarHairPatternOverride> JOCAHODIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7578D0", Offset = "0x7566D0", VA = "0x1807578D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67179A0", Offset = "0x67167A0", VA = "0x1867179A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public List<AvatarHairPatternOverride> LALHJMFBNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x810E90", Offset = "0x80FC90", VA = "0x180810E90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67176C0", Offset = "0x67164C0", VA = "0x1867176C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string AGAKBCIAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67178F0", Offset = "0x67166F0", VA = "0x1867178F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6717BD0", Offset = "0x67169D0", VA = "0x186717BD0")]
	public PDHLIOOGGKP()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarItemMaterial : AvatarSelectionElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x67116C0", Offset = "0x67104C0", VA = "0x1867116C0")]
		public static void HJOECHBGJCK(AvatarItemMaterial BIIOEFJDDMB, Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6711720", Offset = "0x6710520", VA = "0x186711720")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class POBCDEABANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Mesh LHJHFJIFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Material[] BCEJBBNEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool OJNLOBECLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool EKGPNIDGPBM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private POBCDEABANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6718070", Offset = "0x6716E70", VA = "0x186718070")]
	public POBCDEABANL(Mesh MGJAECMCOFA, Material[] GIKOHPKLEPO, bool EOOGENBCGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6717F50", Offset = "0x6716D50", VA = "0x186717F50")]
	public POBCDEABANL(SkinnedMeshRenderer JJICPKHNKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6717BE0", Offset = "0x67169E0", VA = "0x186717BE0")]
	public static POBCDEABANL LKNPAEAJOCA(Renderer KHMNCIMCHCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ADJPAMHGIOA
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum HIMFAFCCCFP
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OFJLBDEAIBL
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum BCENMCCIEKG
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PCKOCIJPAAE
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum PNEFIMHBFDC
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KMOGMELHIMA
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BENBALBCODL
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JFDCPBAJOJB
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KALBAJJCIIC
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly int MANOIAPEEIF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static readonly string NNJFOFIJDBG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly string JGBADOGBBKK;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6714DF0", Offset = "0x6713BF0", VA = "0x186714DF0")]
	public static IEJKAHPLNPM COFNNCFPFKF()
	{
		return default(IEJKAHPLNPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6714BD0", Offset = "0x67139D0", VA = "0x186714BD0")]
	public static MNDCJGACGFD CNJDACGJEDM(Transform BICKPKDCFNO, Transform KPHONFGLECF, AvatarConfiguration KIFBJBIFLIA, Animator AJHOPLLALCA, VRIK PEJCMNBADON, SkeletonLODUpdateRate[] HINKMFOFEPD, GameObject[] FKKBDLMPEOF, Transform DEOMIMDJPLB, GameObject GBFEOEELGMB, BodySkinnedMeshLODs PDONDKPNCCH, BodySkinnedMeshLODs MOAJADIGIFN, GameObject AEADFKEAFIC, BodySkinnedMeshLODs FBNFKINIBFE, BodySkinnedMeshLODs DIJPIGBBEEF, MHLDENCAHGA IBNJCMGEGEN, Material HDBLMHOLMPJ, Material IFFBHDICCHH, Shader AEHGJKJIPLM, Transform PIKGBBKKJCL, Transform CIGMICALEGK, Transform JBGPFLLMCCI, Transform MBNKEFGBGGN, Transform EOJKMNABOEK)
	{
		return default(MNDCJGACGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6714F20", Offset = "0x6713D20", VA = "0x186714F20")]
	public static GJNICFPMPAJ EBDJCCOEFNC(string FJDIHHPPEFI, bool FKJNGKCHFNB, bool HOBPLJNCEDA, bool CMLALBEMODG, RigidbodyEx DOEJIILEDKM, RigidbodyEx KFCNOJPOHNK, RigidbodyEx IKJNLFGNOLE, RigidbodyEx KECMDJIDHFB, Transform OJIHCNJNPEO, Transform OKNHKKNOKGH, Transform IDDBLEMHOKP, float EIPHFGIDOON, float JJNFFLOGPGN, PlayerAvatarFullBodyColliders OOJMHNMDBNL)
	{
		return default(GJNICFPMPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6714E20", Offset = "0x6713C20", VA = "0x186714E20")]
	public static PKMHPLKENBJ DGGCCAMJHPO(Transform KPHONFGLECF, GameObject GBFEOEELGMB, SkinnedMeshRenderer[] JOBOPAPFDPK, SkinnedMeshRenderer[] KIFNJHIKCJK, GameObject AEADFKEAFIC, SkinnedMeshRenderer[] MKGGHBCNIIH, SkinnedMeshRenderer[] JLMNBEOKCCG, MHLDENCAHGA IBNJCMGEGEN, Material HDBLMHOLMPJ, Material IFFBHDICCHH, Shader AEHGJKJIPLM)
	{
		return default(PKMHPLKENBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67150F0", Offset = "0x6713EF0", VA = "0x1867150F0")]
	public static EGLFEAMHGPC HEEHMKAICMA(Transform PIKGBBKKJCL, Transform JBGPFLLMCCI, Transform CIGMICALEGK, Transform MBNKEFGBGGN, Transform EOJKMNABOEK)
	{
		return default(EGLFEAMHGPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE72D60", Offset = "0xE71B60", VA = "0x180E72D60")]
	public static EELLBDNHLBB CMFFHALGHMG(SkinnedMeshRenderer[] EJLOPHAPMFE)
	{
		return default(EELLBDNHLBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6715180", Offset = "0x6713F80", VA = "0x186715180")]
	public static LEGJNCLPMFF LFMABBBNFMH(FFKLNPFPBHM EDMEKCKBHAF, int NGODDLCECIF, int BDACAPJNIJP, Color DHOPILLMKMF, Color LCAAFHOHIGO, int MOJJDMDAFII, int AOKPFFFMELB, Color DELFMKIJNDA, Color MKEDEMDNOLI, int AEJFCGKCECI, float MKICKAFNOJH)
	{
		return default(LEGJNCLPMFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6715030", Offset = "0x6713E30", VA = "0x186715030")]
	public static FMEIEGMNCKF ENDHGKLEENH(FFKLNPFPBHM EDMEKCKBHAF, Vector2 PGADJJNMPOP, float JCEPEKACONG, Vector2 CJIBHILPJLO, float CCNNMEKHDOM, Vector2 ELHALFHIBNO, float JFBLKMEAKFJ, float KPCHDGCMJCD, Vector2 ENICGPMDHON, Vector2 MDFDOAJJOJI)
	{
		return default(FMEIEGMNCKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JMMLJKIHPAH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Transform BENGFKCGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 AFAENNHFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JHLBAIFHCMC : JMMLJKIHPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Transform BENGFKCGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 AFAENNHFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1172400", Offset = "0x1171200", VA = "0x181172400", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x10A52B0", Offset = "0x10A40B0", VA = "0x1810A52B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public float? INMPELHJLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x11723E0", Offset = "0x11711E0", VA = "0x1811723E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x11723F0", Offset = "0x11711F0", VA = "0x1811723F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JHLBAIFHCMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KBFPPMOJIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly JHLBAIFHCMC GBFACPOJEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly JHLBAIFHCMC JMBKNNEBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly JHLBAIFHCMC MDFFIMPFGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly JHLBAIFHCMC MNLGHKPHONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly JHLBAIFHCMC HDGFNJNLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly JHLBAIFHCMC GABLLLPGHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected readonly JHLBAIFHCMC LOGEMGNFGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly JHLBAIFHCMC EMLICEKMDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly JHLBAIFHCMC OCGGFOLHLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly JHLBAIFHCMC PNNJODPOIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly JHLBAIFHCMC ANLJEFGCIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected readonly JHLBAIFHCMC ENFJJNIHPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly JHLBAIFHCMC BLADFCBHMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected JHLBAIFHCMC JDBIBDIHMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly JHLBAIFHCMC KCCLCABDGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly JHLBAIFHCMC POBGDAGBJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly JHLBAIFHCMC BLBFBKGDMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected JHLBAIFHCMC PGGGMGFHLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly JHLBAIFHCMC BNNAKPDAAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected readonly JHLBAIFHCMC JGMCCEDAFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected readonly JHLBAIFHCMC DOOANOJGGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected ReadOnlyCollection<JHLBAIFHCMC> OLKLIIOBJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform DEOMIMDJPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private (JHLBAIFHCMC Start, JHLBAIFHCMC End)[] EHIJLJOCNFD;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public JMMLJKIHPAH KPBCIGPOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JMMLJKIHPAH MFKJLDDJPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public JMMLJKIHPAH GOENIKIDHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public JMMLJKIHPAH PPEJHDGPPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JMMLJKIHPAH NHFFKOFEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public JMMLJKIHPAH GHMLAIGKLFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public JMMLJKIHPAH KIHHMEJMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JHLBAIFHCMC EOIHKGCKJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JMMLJKIHPAH BMCIDCAFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JHLBAIFHCMC DKEJDOFANFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public JMMLJKIHPAH FLDODHACANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7578F0", Offset = "0x7566F0", VA = "0x1807578F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JMMLJKIHPAH LGILMAJOKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7400B0", Offset = "0x73EEB0", VA = "0x1807400B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public JMMLJKIHPAH LHCJKECKNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public JHLBAIFHCMC NGNKBOPECBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public JHLBAIFHCMC HGEPOEIGDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public JMMLJKIHPAH GPEBPCFFKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JMMLJKIHPAH HBGIMBCEFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x757890", Offset = "0x756690", VA = "0x180757890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JMMLJKIHPAH OAOJPJKMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7578A0", Offset = "0x7566A0", VA = "0x1807578A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JMMLJKIHPAH JPMLLBKDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C660", VA = "0x18077D860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JMMLJKIHPAH PMHFDMLEGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7483B0", Offset = "0x7471B0", VA = "0x1807483B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JMMLJKIHPAH DDNGOEKPDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x748450", Offset = "0x747250", VA = "0x180748450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JMMLJKIHPAH GCFLOKLCEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x77D830", Offset = "0x77C630", VA = "0x18077D830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JMMLJKIHPAH IIOIGEIFEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7578B0", Offset = "0x7566B0", VA = "0x1807578B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JMMLJKIHPAH KEFIFPIGDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7578C0", Offset = "0x7566C0", VA = "0x1807578C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public JMMLJKIHPAH PKIOOECMOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7578E0", Offset = "0x7566E0", VA = "0x1807578E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IReadOnlyList<JMMLJKIHPAH> NLLEHOKKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7578D0", Offset = "0x7566D0", VA = "0x1807578D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x67154B0", Offset = "0x67142B0", VA = "0x1867154B0")]
	public void HHJIOELBKHH(VRIK PEEKOEMPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E7FE10", Offset = "0x1E7EC10", VA = "0x181E7FE10")]
	private void MPCKLDODPPC(Transform NFJHHMHDKEL, JHLBAIFHCMC ONDHOAIGIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6715FF0", Offset = "0x6714DF0", VA = "0x186715FF0")]
	public void MPJAPKIIBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E7FDC0", Offset = "0x1E7EBC0", VA = "0x181E7FDC0")]
	public float MLBFCFMPGOD(in (JHLBAIFHCMC Start, JHLBAIFHCMC End) HIDPEBBHDAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x67152D0", Offset = "0x67140D0", VA = "0x1867152D0")]
	public void EOOBCMBHNHD(in IEJKAHPLNPM GMDALJMBJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6715EA0", Offset = "0x6714CA0", VA = "0x186715EA0")]
	private Vector3 KLFJGANBOIP(in (JHLBAIFHCMC Start, JHLBAIFHCMC End) HIDPEBBHDAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67164A0", Offset = "0x67152A0", VA = "0x1867164A0")]
	public KBFPPMOJIAI()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67117E0", Offset = "0x67105E0", VA = "0x1867117E0")]
		public string CIJMCAKODDG(string JJHMNHFNKKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6711830", Offset = "0x6710630", VA = "0x186711830")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct GJNICFPMPAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public string NFDKCNNFPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool BNLHCIGFMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool PCMPLJIMLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public float GMGEOIIJJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float BACJKFGODJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public bool JKFGFINOKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public RigidbodyEx HPDJFGFIHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public RigidbodyEx GCMFPMOJEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public RigidbodyEx LDCCIOIBDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public RigidbodyEx DLFOMDHNFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform JAOAMCHFENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform KCIPMAKNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform NHLMGEBBMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public PlayerAvatarFullBodyColliders CEIOLGKFGNH;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MNDCJGACGFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform GIFIHEANMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform NAKJFADFEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public AvatarConfiguration EAJFCPOGFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Animator CJNAMAMPCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public VRIK IFPHDICJMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public SkeletonLODUpdateRate[] LIAFBFEFJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public GameObject[] FPLKKOKLKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Transform JDILDNAPBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public GameObject NCNNFGOMFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public BodySkinnedMeshLODs OJEIOKNJCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public BodySkinnedMeshLODs AGHMNBBEKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public GameObject FGKLDNGICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public BodySkinnedMeshLODs DNGFGPHFCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public BodySkinnedMeshLODs FGMAHFDDAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public MHLDENCAHGA JFGIEMLJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Material BOLHBDLCBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Material LLKONDCBEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Shader GDNCANFJKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Transform AELMCAGIMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Transform KBHAEJLMOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Transform JOFOFHMBFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Transform MIJIKLGMCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Transform NFKBHAFFBJA;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IEJKAHPLNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float AIGBPGLJBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool PFIMKPKHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public FLDAKNOJEGK BBEDEJMKMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Vector3 JPBDOJGBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Vector3 BIHIJEOBNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? MKFHLCEKBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3? NAFMGAEDACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool DLKKIOCLOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool NEHDPGPABOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool CEEKPIICJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public bool EBOMHGNEFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool PKMKLBPHFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3? BGKHBJIGAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool EEHOMDBAMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3? LNLHFDCLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool PLMCHKOEODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3? LFPIGLAPNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public Vector3? FDELMNCOPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool AODJINEECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool AJOPKBDHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool HAGLNIANEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public bool ALALLDPNJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public bool IGHOPCDOBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public bool PKIJJADKLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool KGJPIEPALIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public bool COHLKBNGMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public bool CNDLHBKFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public bool FAKGFBDNOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Vector3? BDHDEGCIKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public ADJPAMHGIOA DDCCDMPLFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public ADJPAMHGIOA PKFJGKLFOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float EMAKEPPEKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public float NAFNKAFNLMH;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AFDJIGPIOLL
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAFKHOJDBNA();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::BLENMGIJHFH<Texture2D> MHGNDLGNFCL(DOOLBGICOEM GAHDMOCABNF, [Optional] FDJNECEGIFI DNHNNDBCPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JADPGMLJKAJ : AFDJIGPIOLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private OPCDJDGPGFP EKJJEGNBCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private IRecRoomQualityConfigProvider OFCEDAMIGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool JOOIDFCFBKI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private const uint DHDACKDALIN = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6714460", Offset = "0x6713260", VA = "0x186714460")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void HGJFPOKIOHJ(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	[Preserve]
	public JADPGMLJKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67143B0", Offset = "0x67131B0", VA = "0x1867143B0")]
	private void FCFLDEKDCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6714550", Offset = "0x6713350", VA = "0x186714550", Slot = "4")]
	public void IAFKHOJDBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67145B0", Offset = "0x67133B0", VA = "0x1867145B0", Slot = "5")]
	public global::BLENMGIJHFH<Texture2D> MHGNDLGNFCL(DOOLBGICOEM GAHDMOCABNF, [Optional] FDJNECEGIFI DNHNNDBCPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67149C0", Offset = "0x67137C0", VA = "0x1867149C0")]
	private uint PINOLBPICPP(DOOLBGICOEM GAHDMOCABNF, FDJNECEGIFI DNHNNDBCPLH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum BPOFEJIIACG
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FDJNECEGIFI
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly FDJNECEGIFI ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int JFPCBBEDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7620C0", Offset = "0x760EC0", VA = "0x1807620C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public BPOFEJIIACG BMELBMFEHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x757920", Offset = "0x756720", VA = "0x180757920")]
		[CompilerGenerated]
		get
		{
			return default(BPOFEJIIACG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA94ED0", Offset = "0xA93CD0", VA = "0x180A94ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FDJNECEGIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6711DC0", Offset = "0x6710BC0", VA = "0x186711DC0")]
	public FDJNECEGIFI(BPOFEJIIACG LHDFDDPEACL, int HIGKLONGJKM)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6714130", Offset = "0x6712F30", VA = "0x186714130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6714070", Offset = "0x6712E70", VA = "0x186714070")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6713E50", Offset = "0x6712C50", VA = "0x186713E50")]
		public void OALMCABEHHC(FitMeshHemisphere HEGCEKMCCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6713B10", Offset = "0x6712910", VA = "0x186713B10")]
		public Vector3 NLFLJFMPPLH(Vector2 JGLACJDJIGP, bool BNHMFMGGJHH = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6713870", Offset = "0x6712670", VA = "0x186713870")]
		public Vector3 DOONAPDKFNB(Vector2 JGLACJDJIGP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x67139E0", Offset = "0x67127E0", VA = "0x1867139E0")]
		public Quaternion KPCPAMHCPBM(Vector2 JGLACJDJIGP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x67138D0", Offset = "0x67126D0", VA = "0x1867138D0")]
		public Quaternion KPCPAMHCPBM(Vector2 JGLACJDJIGP, Vector3 INLDHFGCOPC)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6713EA0", Offset = "0x6712CA0", VA = "0x186713EA0")]
		private Vector2 OGFGCBAFOHL(Vector2 MGDKDMDNEDE)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct BJJJGBGOAMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public readonly GameObject JNHJHJFMEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public readonly AvatarItemMaterial CMINAAFDPMG;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
	public BJJJGBGOAMM(GameObject JNHJHJFMEKC, AvatarItemMaterial CMINAAFDPMG)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EOPHBFPAILF
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6711950", Offset = "0x6710750", VA = "0x186711950")]
	public static bool PPEOHLMOMDB(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6711910", Offset = "0x6710710", VA = "0x186711910")]
	public static bool JBGDLGCMFNJ(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67118F0", Offset = "0x67106F0", VA = "0x1867118F0")]
	public static bool BBKKDILBABC(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6711900", Offset = "0x6710700", VA = "0x186711900")]
	public static bool ICAMCJBMHIO(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6711930", Offset = "0x6710730", VA = "0x186711930")]
	public static bool KHCCFNINMNL(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6711940", Offset = "0x6710740", VA = "0x186711940")]
	public static bool PHEOHAANEPI(this OutfitType ELFCJGCGILC)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private MHLDENCAHGA LAHHHDCMBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Collider[] OCGIIMJKKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private Collider[] EAHMJJAPNJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6718200", Offset = "0x6717000", VA = "0x186718200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6718180", Offset = "0x6716F80", VA = "0x186718180")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67183C0", Offset = "0x67171C0", VA = "0x1867183C0")]
		public void UpdateBones(MHLDENCAHGA IBNJCMGEGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6718270", Offset = "0x6717070", VA = "0x186718270")]
		public void SetCollidersEnabled(bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67183F0", Offset = "0x67171F0", VA = "0x1867183F0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x75C420", Offset = "0x75B220", VA = "0x18075C420", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6711880", Offset = "0x6710680", VA = "0x186711880")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6711CF0", Offset = "0x6710AF0", VA = "0x186711CF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6711D30", Offset = "0x6710B30", VA = "0x186711D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2266AB0", Offset = "0x22658B0", VA = "0x182266AB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2268830", Offset = "0x2267630", VA = "0x182268830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2C6B420", Offset = "0x2C6A220", VA = "0x182C6B420")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC10", Offset = "0x8BAA10", VA = "0x1808BBC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6711D10", Offset = "0x6710B10", VA = "0x186711D10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC20", Offset = "0x8BAA20", VA = "0x1808BBC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6711970", Offset = "0x6710770", VA = "0x186711970", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6711C10", Offset = "0x6710A10", VA = "0x186711C10")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6713030", Offset = "0x6711E30", VA = "0x186713030")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x875050", Offset = "0x873E50", VA = "0x180875050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x16F3A10", Offset = "0x16F2810", VA = "0x1816F3A10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x14020F0", Offset = "0x1400EF0", VA = "0x1814020F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6712F00", Offset = "0x6711D00", VA = "0x186712F00", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6712FB0", Offset = "0x6711DB0", VA = "0x186712FB0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6712EE0", Offset = "0x6711CE0", VA = "0x186712EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x483CB40", Offset = "0x483B940", VA = "0x18483CB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCE0", Offset = "0xEFEAE0", VA = "0x180EFFCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6712D10", Offset = "0x6711B10", VA = "0x186712D10")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6712D80", Offset = "0x6711B80", VA = "0x186712D80", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6712E00", Offset = "0x6711C00", VA = "0x186712E00")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class FFKLNPFPBHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class ALJNHLDEGJP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public readonly Texture2DArray LFABMGNIGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public readonly Dictionary<string, int> DLMECFIDKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly BAHKENJLEMI MKFDGEPKKKJ;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool HBEFBEKHDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x18519F0", Offset = "0x18507F0", VA = "0x1818519F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6710870", Offset = "0x670F670", VA = "0x186710870")]
		public ALJNHLDEGJP(Texture2DArray JNGDILLKCJM, Dictionary<string, int> AFPHMPFKNGK, FFKLNPFPBHM POCDJPKKDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x18517F0", Offset = "0x18505F0", VA = "0x1818517F0")]
		public void BDJFMADKJIM(FFKLNPFPBHM AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1850D20", Offset = "0x184FB20", VA = "0x181850D20")]
		public void AOONNHNPMHC(FFKLNPFPBHM AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x14B5B30", Offset = "0x14B4930", VA = "0x1814B5B30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct HPLAKHNNPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private readonly string DOGELLENHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly string DMKHDHGOLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly string AEOHMGONHNO;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8071A0", Offset = "0x805FA0", VA = "0x1808071A0")]
		public HPLAKHNNPEO(string EHKMNBEAJGP, string HPPJCLJAAOH, string MKLLHPLJMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6714330", Offset = "0x6713130", VA = "0x186714330")]
		public bool JBPDPAIMCKC(HPLAKHNNPEO IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x67141D0", Offset = "0x6712FD0", VA = "0x1867141D0", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4472900", Offset = "0x4471700", VA = "0x184472900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6714140", Offset = "0x6712F40", VA = "0x186714140")]
		public static bool EJGLOGBEPOL(HPLAKHNNPEO CJCAMOJJGED, HPLAKHNNPEO DDMHJAPFCFF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x67142A0", Offset = "0x67130A0", VA = "0x1867142A0")]
		public static bool IKFCAHNLBFO(HPLAKHNNPEO CJCAMOJJGED, HPLAKHNNPEO DDMHJAPFCFF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly Dictionary<string, int> AFPHMPFKNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HPLAKHNNPEO AFEALKGANJJ;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Texture2DArray IFODHKAMOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public SymmetricalFaceFeature IKHOGEOGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EyesFaceFeature PKECMEACCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FaceFeature KKMLPDKJABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6711E00", Offset = "0x6710C00", VA = "0x186711E00")]
	private static void CEFIGJNPMIE(Sprite PNLLLGLHBIF, Sprite HNIBOACFGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6712120", Offset = "0x6710F20", VA = "0x186712120")]
	private static void HHJBAPNBKOL(Sprite KBJBDICLDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6712CF0", Offset = "0x6711AF0", VA = "0x186712CF0")]
	public FFKLNPFPBHM(EyesFaceFeature GCPPGCJIKDE, FaceFeature CEDALNFOFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6712190", Offset = "0x6710F90", VA = "0x186712190")]
	public FFKLNPFPBHM(SymmetricalFaceFeature KGJGCOIMMMP, EyesFaceFeature GCPPGCJIKDE, FaceFeature CEDALNFOFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6711F10", Offset = "0x6710D10", VA = "0x186711F10")]
	public bool GLDPLPNGPGN(Sprite KBJBDICLDHC, out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6711F00", Offset = "0x6710D00", VA = "0x186711F00", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6713850", Offset = "0x6712650", VA = "0x186713850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6713540", Offset = "0x6712340", VA = "0x186713540")]
		public FFKLNPFPBHM FIHNDLMJEAD(int PEGHPBNIIAC, int GCPPGCJIKDE, int CEDALNFOFIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x67133F0", Offset = "0x67121F0", VA = "0x1867133F0")]
		public FaceFeatureBase FDIJMEMKMMH(FaceFeatureType HFPKEPCKDDB, string AOKEOLFIKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6713740", Offset = "0x6712540", VA = "0x186713740")]
		public int OCILHEBNEEA(string AOKEOLFIKCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6713050", Offset = "0x6711E50", VA = "0x186713050")]
		private void AJCJNGPOGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2086930", Offset = "0x2085730", VA = "0x182086930")]
		private void NEBGPHHDJAH<T>(Dictionary<string, T> HOPLLDGEACD, T[] OFJIAICMDHG) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6713200", Offset = "0x6712000", VA = "0x186713200")]
		public string AKCINBEEIKE(FaceFeatureType HFPKEPCKDDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x67132D0", Offset = "0x67120D0", VA = "0x1867132D0")]
		public string EJPAIABOJGJ(FaceFeatureType HFPKEPCKDDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x67137D0", Offset = "0x67125D0", VA = "0x1867137D0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x67176B0", Offset = "0x67164B0", VA = "0x1867176B0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x75C430", Offset = "0x75B230", VA = "0x18075C430", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67176B0", Offset = "0x67164B0", VA = "0x1867176B0")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6718650", Offset = "0x6717450", VA = "0x186718650")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x45E7380", Offset = "0x45E6180", VA = "0x1845E7380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x171C790", Offset = "0x171B590", VA = "0x18171C790")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x45E7370", Offset = "0x45E6170", VA = "0x1845E7370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x171C750", Offset = "0x171B550", VA = "0x18171C750")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x3ED9880", Offset = "0x3ED8680", VA = "0x183ED9880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x171C6C0", Offset = "0x171B4C0", VA = "0x18171C6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6718670", Offset = "0x6717470", VA = "0x186718670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6718540", Offset = "0x6717340", VA = "0x186718540", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6711880", Offset = "0x6710680", VA = "0x186711880")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6716B90", Offset = "0x6715990", VA = "0x186716B90")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6716840", Offset = "0x6715640", VA = "0x186716840")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
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
