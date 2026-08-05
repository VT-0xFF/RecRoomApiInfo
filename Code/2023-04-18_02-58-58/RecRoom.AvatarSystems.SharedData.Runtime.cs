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
	[Cpp2IlInjected.Address(RVA = "0x6317A30", Offset = "0x6316C30", VA = "0x186317A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6317340", Offset = "0x6316540", VA = "0x186317340")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63171A0", Offset = "0x63163A0", VA = "0x1863171A0")]
		public AnchorParams(Vector2 EINADJJBGBM, Vector3 GIAMLDGABBP, Vector3 FNHKBCONGFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x63171D0", Offset = "0x63163D0", VA = "0x1863171D0")]
		public AnchorParams(CLMEHHLKBJG MPOPNGJFAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63170B0", Offset = "0x63162B0", VA = "0x1863170B0", Slot = "4")]
		public bool Equals(AnchorParams HNPEBINPOBO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CLMEHHLKBJG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GOJECHGPKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JHLDHPHAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GGOLCGNABCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CGJIJEIJDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PGKGIALBMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DPPHNJAKANM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NEDIPGPCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GAJDMLFOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float NFKMJHEPIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KNJCAKOLFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JCBNPCPIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float BMLOMAEDJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float IHLNGMONHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float LJJNCOOBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float LDECHIBODLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float HCFJCHOMIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float CNOJOMLJPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float BCAEOPDPLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float BOFHINAIMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float AMPBFEKMJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float AFNNMONDAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AJHPBCNHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LPKPEGHJIND
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float FGKMNGIJPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 KKEDLNLIJOA(Vector3 FNHKBCONGFN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BHGJLFELCHA(Vector3 CIKDIDLCPJL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 PNPGMINHEED();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 AEDEHOJFMAC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : CLMEHHLKBJG
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
			[Cpp2IlInjected.Address(RVA = "0x6317020", Offset = "0x6316220", VA = "0x186317020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6317050", Offset = "0x6316250", VA = "0x186317050", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6317080", Offset = "0x6316280", VA = "0x186317080", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6316F90", Offset = "0x6316190", VA = "0x186316F90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6316FC0", Offset = "0x63161C0", VA = "0x186316FC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6316FF0", Offset = "0x63161F0", VA = "0x186316FF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x14BD710", Offset = "0x14BC910", VA = "0x1814BD710", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB53E30", Offset = "0xB53030", VA = "0x180B53E30", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB53E20", Offset = "0xB53020", VA = "0x180B53E20", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x975480", Offset = "0x974680", VA = "0x180975480", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x975470", Offset = "0x974670", VA = "0x180975470", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1290", Offset = "0xAC0490", VA = "0x180AC1290", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xFF0BC0", Offset = "0xFEFDC0", VA = "0x180FF0BC0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD4D6D0", Offset = "0xD4C8D0", VA = "0x180D4D6D0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD4D6C0", Offset = "0xD4C8C0", VA = "0x180D4D6C0", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAAB540", Offset = "0xAAA740", VA = "0x180AAB540", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9D23D0", Offset = "0x9D15D0", VA = "0x1809D23D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD4D700", Offset = "0xD4C900", VA = "0x180D4D700", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD198E0", Offset = "0xD18AE0", VA = "0x180D198E0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD4D710", Offset = "0xD4C910", VA = "0x180D4D710", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x945C60", Offset = "0x944E60", VA = "0x180945C60", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x15B09E0", Offset = "0x15AFBE0", VA = "0x1815B09E0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xE5D200", Offset = "0xE5C400", VA = "0x180E5D200", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6316F00", Offset = "0x6316100", VA = "0x186316F00")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6316C10", Offset = "0x6315E10", VA = "0x186316C10")]
		public AnchorParams JFPNFPJFINO(AnchorParams OFGNJKIEBFM)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6316EE0", Offset = "0x63160E0", VA = "0x186316EE0", Slot = "30")]
		public Vector3 PNPGMINHEED()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6316B50", Offset = "0x6315D50", VA = "0x186316B50", Slot = "31")]
		public Vector3 AEDEHOJFMAC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6316E50", Offset = "0x6316050", VA = "0x186316E50", Slot = "28")]
		public Vector3 KKEDLNLIJOA(Vector3 FNHKBCONGFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6316B70", Offset = "0x6315D70", VA = "0x186316B70", Slot = "29")]
		public Vector3 BHGJLFELCHA(Vector3 CIKDIDLCPJL)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CFBDLFAJGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> HNOLMFLAKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] GNPPIKEOJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> GMDADIJIACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> NHHFIJFEFIP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] LJJEFEHCKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6318110", Offset = "0x6317310", VA = "0x186318110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] AFALMNGPLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6317E80", Offset = "0x6317080", VA = "0x186317E80")]
	public void HJPCDDHJPAH(SkinnedMeshRenderer LPCBHIEOFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63182D0", Offset = "0x63174D0", VA = "0x1863182D0")]
	public void PJOLBLAGNMO(Transform JLKLNHIHMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6318030", Offset = "0x6317230", VA = "0x186318030")]
	private Transform IABEILKLEJH(Transform CFOLIOFGIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6317C00", Offset = "0x6316E00", VA = "0x186317C00")]
	public void EOKMGAMIDIP(CFBDLFAJGKM MPNKAJHBCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6318160", Offset = "0x6317360", VA = "0x186318160")]
	private void LCKPAKBFNFL(Transform KPDGHDGLMHO, List<Transform> BLBKONLFICB, Dictionary<string, Transform> IBDMKMDGICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6318340", Offset = "0x6317540", VA = "0x186318340")]
	public CFBDLFAJGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BONAMGJKPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool APFODGNKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GMKGNGHPHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NJDHENJLELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool BAAJPFJACCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool EMBMPIHIFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool BCLIDMDKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool HFFNEMLFAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<MJGJFLLCAJJ> CNCJFOFOGAI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public BONAMGJKPCM()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FF0", Offset = "0x6F91F0", VA = "0x1806F9FF0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum JKCCIHPHNHL
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
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
		private JKCCIHPHNHL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1E31E50", Offset = "0x1E31050", VA = "0x181E31E50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA10720", Offset = "0xA0F920", VA = "0x180A10720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x975470", Offset = "0x974670", VA = "0x180975470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xEC6450", Offset = "0xEC5650", VA = "0x180EC6450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3367C90", Offset = "0x3366E90", VA = "0x183367C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x17671A0", Offset = "0x17663A0", VA = "0x1817671A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9D23D0", Offset = "0x9D15D0", VA = "0x1809D23D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAB650", Offset = "0xAAA850", VA = "0x180AAB650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x814E50", Offset = "0x814050", VA = "0x180814E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A90", Offset = "0x7A6C90", VA = "0x1807A7A90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7A7DE0", Offset = "0x7A6FE0", VA = "0x1807A7DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8532C0", Offset = "0x8524C0", VA = "0x1808532C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x852DD0", Offset = "0x851FD0", VA = "0x180852DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x815C60", Offset = "0x814E60", VA = "0x180815C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x711070", Offset = "0x710270", VA = "0x180711070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0E0", Offset = "0x9AC2E0", VA = "0x1809AD0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AC680", Offset = "0x9AB880", VA = "0x1809AC680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA60CF0", Offset = "0xA5FEF0", VA = "0x180A60CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBFBD60", Offset = "0xBFAF60", VA = "0x180BFBD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAD6180", Offset = "0xAD5380", VA = "0x180AD6180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9222F0", Offset = "0x9214F0", VA = "0x1809222F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA8C1F0", Offset = "0xA8B3F0", VA = "0x180A8C1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA8BEA0", Offset = "0xA8B0A0", VA = "0x180A8BEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JKCCIHPHNHL UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63178E0", Offset = "0x6316AE0", VA = "0x1863178E0")]
			get
			{
				return default(JKCCIHPHNHL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x10AA0B0", Offset = "0x10A92B0", VA = "0x1810AA0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6B80", Offset = "0xAA5D80", VA = "0x180AA6B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x958EF0", Offset = "0x9580F0", VA = "0x180958EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x63178C0", Offset = "0x6316AC0", VA = "0x1863178C0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x63179B0", Offset = "0x6316BB0", VA = "0x1863179B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x91E590", Offset = "0x91D790", VA = "0x18091E590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6317910", Offset = "0x6316B10", VA = "0x186317910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2193ED0", Offset = "0x21930D0", VA = "0x182193ED0")]
		public string IIADKJHBOIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63173B0", Offset = "0x63165B0", VA = "0x1863173B0")]
		public static AvatarCustomizationSettings BBCFAILGGHN(string EDEOADKJLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6317700", Offset = "0x6316900", VA = "0x186317700")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AMBBOEBJPNH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CILCFNHODGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Transform KNLLDPLHODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject JDPFMFDEGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] DJGGBONCMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public SkinnedMeshRenderer[] KDGGFKIENDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject CBOJINMPOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] JGLOFEPEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] HALCPEOIHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public CFBDLFAJGKM NLNDNGKMDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material DEKLJKMFOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Material DMAJKKHBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Shader IOLACECGNEM;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JENBGCMJNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform LJDJEKGCPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform NEPKBLDLLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform GLJBACMDAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform PEKNMDJPIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform BFNMIMMIFHD;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FNLPOBAIOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public SkinnedMeshRenderer[] AJPGMCIGGFI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AEDJLAIELAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public HIDAODIFFIL EKHOOBGFOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int KIAFLCMBFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int CGLBDNPGFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int OKKNLJJAAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int PAICKPJMJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int EHIEMPBOHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int EBDIKDNGHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int HDFAGJPFOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float GLCIINOANBG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JLJGFFEAFCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HIDAODIFFIL EKHOOBGFOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector2 FIOGNKMIGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float ALFJEMCNPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Vector2 PBMPNMBOOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float AHABJCOALPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Vector2 MBFOFMFKCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float MJFMCAKNNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float FCPGODHMNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 JBILBKDCHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Vector2 AODGGLENNPB;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MJGJFLLCAJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public string PALADLMJNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public OutfitType AKLDJOKABMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public AEGILPLHPKJ AEGBMLONMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public bool ODLCMHIEGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Color? GFGNHPFDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3? GPKLAIMBDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float? POLCGIAONDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid? DDFLNHIKEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Color? NIGEMBPABFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool NJNFLMILODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool MHFBJHDKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public AnchorParamsRestrictions FIGIALFDLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector2? IBALOJINGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Transform KOLLEDDCEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public FitMeshHemisphere FHIEJHOLPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Vector2 KDJLIMNBAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<AvatarHairPatternOverride> JANDNMACDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Dictionary<string, Texture2D> DNCPIHLFPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<AvatarHairPatternOverride> PMNOLKEKKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<string, Texture2D> KGDENIDLOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference OALBKKJLDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference IMNDKNIHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public AssetReference[] DIACHLCBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool CLEPBIFKBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool EHGHNNOBDMG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public List<AvatarHairPatternOverride> OMHKFNCAGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x91EBD0", Offset = "0x91DDD0", VA = "0x18091EBD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x631D6F0", Offset = "0x631C8F0", VA = "0x18631D6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public List<AvatarHairPatternOverride> AFNKIAILDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA449E0", Offset = "0xA43BE0", VA = "0x180A449E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x631D920", Offset = "0x631CB20", VA = "0x18631D920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string LLBBFNPPBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x631DB50", Offset = "0x631CD50", VA = "0x18631DB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x631DC00", Offset = "0x631CE00", VA = "0x18631DC00")]
	public MJGJFLLCAJJ()
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
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63179D0", Offset = "0x6316BD0", VA = "0x1863179D0")]
		public static void KFIHMLODGME(AvatarItemMaterial ONIIEAMBAHF, Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6317A30", Offset = "0x6316C30", VA = "0x186317A30")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DAJNNNMECKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Mesh FIOJGABILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Material[] GOPNCMGHOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool NAFJGONLMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool DIPDMHKPECD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	private DAJNNNMECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63188D0", Offset = "0x6317AD0", VA = "0x1863188D0")]
	public DAJNNNMECKB(Mesh AAKOJGEOGGC, Material[] LDFHAEGIADD, bool NONJBJLNBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63187B0", Offset = "0x63179B0", VA = "0x1863187B0")]
	public DAJNNNMECKB(SkinnedMeshRenderer BMLILMNEJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6318440", Offset = "0x6317640", VA = "0x186318440")]
	public static DAJNNNMECKB GKNKGNMFAHA(Renderer LPCBHIEOFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GHCICEFBOGM
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PJIBAFHHMLI
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum AEGILPLHPKJ
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum BHPAILAGEHB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CIBGGFLDPDM
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum ENADOCPNNLE
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IPADHDAOEIO
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BEHDJENIOJO
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CONPHCBLKLH
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JBLNBJCJMNB
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly int NKOMCNOACCD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly string OFNBPGENAGI;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly string JJAIDFPHFNL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x631D620", Offset = "0x631C820", VA = "0x18631D620")]
	public static OCJOLNNODFB LOHBGIBJFGP()
	{
		return default(OCJOLNNODFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x631D170", Offset = "0x631C370", VA = "0x18631D170")]
	public static IIMJGMEKKHG HKKAMCDLGMO(Transform GDHKDDJOENB, Transform JLMKEPMGEDO, AvatarConfiguration HLDBCEHCKFD, Animator FMEMELEBBHE, VRIK OMFOCPJIIHI, SkeletonLODUpdateRate[] MEHOEPJHGNB, GameObject[] NNFOBDHPCCK, Transform HPDDFNPLBIM, GameObject JBHCGLDLPKJ, BodySkinnedMeshLODs NBOOHKMFPOL, BodySkinnedMeshLODs NBNAHOJIAHO, GameObject KKAGACEBFGD, BodySkinnedMeshLODs OPIKLOMIGIK, BodySkinnedMeshLODs BHKLAKELCCI, CFBDLFAJGKM PAAINPJHDEN, Material KCFEDEKIDAI, Material ADJLBDEENJA, Shader COCIPKDJBOM, Transform MACEFMMGGMA, Transform DCMBPJJIHLP, Transform PLFKFIPGCMC, Transform ABKOEAIPHNN, Transform GGIMGLBBJEL)
	{
		return default(IIMJGMEKKHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x631D510", Offset = "0x631C710", VA = "0x18631D510")]
	public static DFDOINJOGMK LKOIJHENODA(string IIHOFGMNLLP, bool FPGJENNENEO, bool OLJBJFBAIHI, bool PGGANNIDNMI, RigidbodyEx BKBAMENCIOO, RigidbodyEx NFHOIONNAFP, RigidbodyEx DMEIKGIIEMP, RigidbodyEx GDCNECHOIEO, Transform OALFANFGEJN, Transform FHNNGPKLIBK, Transform ACMJBLHHKAP, float KAGDFNNDNMD, float ENONFLJMGAD, PlayerAvatarFullBodyColliders HCIFJDFJNJD)
	{
		return default(DFDOINJOGMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x631D390", Offset = "0x631C590", VA = "0x18631D390")]
	public static CILCFNHODGD IJFLKPNPALH(Transform JLMKEPMGEDO, GameObject JBHCGLDLPKJ, SkinnedMeshRenderer[] KAMIEJDPDPN, SkinnedMeshRenderer[] NDHHDAPHFBO, GameObject KKAGACEBFGD, SkinnedMeshRenderer[] ADJKNBNDJNP, SkinnedMeshRenderer[] FLAEGDKIOEK, CFBDLFAJGKM PAAINPJHDEN, Material KCFEDEKIDAI, Material ADJLBDEENJA, Shader COCIPKDJBOM)
	{
		return default(CILCFNHODGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x631D050", Offset = "0x631C250", VA = "0x18631D050")]
	public static JENBGCMJNEJ ADPFFHNPLAN(Transform MACEFMMGGMA, Transform PLFKFIPGCMC, Transform DCMBPJJIHLP, Transform ABKOEAIPHNN, Transform GGIMGLBBJEL)
	{
		return default(JENBGCMJNEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9A0840", Offset = "0x99FA40", VA = "0x1809A0840")]
	public static FNLPOBAIOGI PHJLALIHMEP(SkinnedMeshRenderer[] EPCMLLIEMDN)
	{
		return default(FNLPOBAIOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x631D490", Offset = "0x631C690", VA = "0x18631D490")]
	public static AEDJLAIELAB JLLDHAAKDEM(HIDAODIFFIL OGDOMPHLPPM, int PICIJGNILDB, int OBPFLGLCMII, int PGGOLHIPFII, int FDLLAGNLAOG, int JBEHHDAJPBL, int PODJBBFDKEM, int BJGCNJKICPC, float OLCLBEMLNDH)
	{
		return default(AEDJLAIELAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x631D0E0", Offset = "0x631C2E0", VA = "0x18631D0E0")]
	public static JLJGFFEAFCO EGAEGACIIJG(HIDAODIFFIL OGDOMPHLPPM, Vector2 NLEMOEGIDAJ, float AIJMMEBOJLG, Vector2 NLKHAJAJMGD, float HNNMHKGJHAP, Vector2 NCDOKBDLGLK, float COBINMEGMIJ)
	{
		return default(JLJGFFEAFCO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DPFNMEHPMNM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Vector3 PGMKCFAPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EGLKCDIGPEG : DPFNMEHPMNM
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Transform DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 PGMKCFAPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C9690", Offset = "0x8C8890", VA = "0x1808C9690", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8C9680", Offset = "0x8C8880", VA = "0x1808C9680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float? JLKCMFHDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C96B0", Offset = "0x8C88B0", VA = "0x1808C96B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C96C0", Offset = "0x8C88C0", VA = "0x1808C96C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EGLKCDIGPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GBMPODOAGJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly EGLKCDIGPEG LFIDMKOIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly EGLKCDIGPEG DNKIELMIBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly EGLKCDIGPEG INCOMPANLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly EGLKCDIGPEG GMCBIPNJHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly EGLKCDIGPEG KDBIGFFBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly EGLKCDIGPEG JODHIMIHNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly EGLKCDIGPEG EACHDIGAAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly EGLKCDIGPEG EEKDEKNPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly EGLKCDIGPEG DFBDAHEBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly EGLKCDIGPEG AOOJDEHPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly EGLKCDIGPEG GIMKDKDJJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly EGLKCDIGPEG AOIFAGOFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly EGLKCDIGPEG JAMLBIKEGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected EGLKCDIGPEG FEAOOPJJMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly EGLKCDIGPEG KGKKEFHBCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly EGLKCDIGPEG LNBBPMGLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly EGLKCDIGPEG EGGKBMNANOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected EGLKCDIGPEG DPHCHAGPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected readonly EGLKCDIGPEG DCBKEPGODFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly EGLKCDIGPEG PAEGPDBCFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly EGLKCDIGPEG IIEJEGGFLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected ReadOnlyCollection<EGLKCDIGPEG> IHOPPJOBGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform HPDDFNPLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private (EGLKCDIGPEG Start, EGLKCDIGPEG End)[] MDGADHKKJDI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public DPFNMEHPMNM JJDKODPEDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public DPFNMEHPMNM CMBGCNAGJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public DPFNMEHPMNM PBKCOLDPJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DPFNMEHPMNM IPFNCMPKFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public DPFNMEHPMNM JIJIHDNLJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public DPFNMEHPMNM JCDKKNPKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public DPFNMEHPMNM DMNIAOJDABK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EGLKCDIGPEG ACDJFPDHAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public DPFNMEHPMNM IJJMGJJBAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EGLKCDIGPEG ADJKJGIBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public DPFNMEHPMNM JBDMMPMKJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A7A90", Offset = "0x7A6C90", VA = "0x1807A7A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DPFNMEHPMNM NHEOGDJPLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8532C0", Offset = "0x8524C0", VA = "0x1808532C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public DPFNMEHPMNM DOIPNIGEPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EGLKCDIGPEG FICGAJDIMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x817390", Offset = "0x816590", VA = "0x180817390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EGLKCDIGPEG DLMJIBDEINC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public DPFNMEHPMNM CLPEIKMAPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DPFNMEHPMNM NKFKGOFGHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9AD0E0", Offset = "0x9AC2E0", VA = "0x1809AD0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public DPFNMEHPMNM GGKHHFAPGED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA60CF0", Offset = "0xA5FEF0", VA = "0x180A60CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public DPFNMEHPMNM PMNLFJMEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD6180", Offset = "0xAD5380", VA = "0x180AD6180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DPFNMEHPMNM MMEGMCDOMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x91E5A0", Offset = "0x91D7A0", VA = "0x18091E5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DPFNMEHPMNM AICJCILCODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82B680", Offset = "0x82A880", VA = "0x18082B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DPFNMEHPMNM BFFOIMPJIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x91EA50", Offset = "0x91DC50", VA = "0x18091EA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DPFNMEHPMNM AGCPMNCAGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x91EBE0", Offset = "0x91DDE0", VA = "0x18091EBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DPFNMEHPMNM EMGDJBMNEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F9880", Offset = "0x6F8A80", VA = "0x1806F9880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public DPFNMEHPMNM HEGLHPNBIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x91EBD0", Offset = "0x91DDD0", VA = "0x18091EBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IReadOnlyList<DPFNMEHPMNM> NEAKJGCBDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x631A830", Offset = "0x6319A30", VA = "0x18631A830")]
	public void NAFGNNGLLHL(VRIK OIJBBCHCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x13D16B0", Offset = "0x13D08B0", VA = "0x1813D16B0")]
	private void HKMCPADLNKF(Transform GLLFHCCFIGK, EGLKCDIGPEG GFCPAMJILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x631A230", Offset = "0x6319430", VA = "0x18631A230")]
	public void CGCLNMJINHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x13D1CD0", Offset = "0x13D0ED0", VA = "0x1813D1CD0")]
	public float IKNODNMPEDN(in (EGLKCDIGPEG Start, EGLKCDIGPEG End) EIEOJIFKIBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x631B220", Offset = "0x631A420", VA = "0x18631B220")]
	public void OGGPHACMLME(in OCJOLNNODFB DADHJJNJEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x631A6E0", Offset = "0x63198E0", VA = "0x18631A6E0")]
	private Vector3 FKJKLCHGNPK(in (EGLKCDIGPEG Start, EGLKCDIGPEG End) EIEOJIFKIBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x631B400", Offset = "0x631A600", VA = "0x18631B400")]
	public GBMPODOAGJD()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6317AF0", Offset = "0x6316CF0", VA = "0x186317AF0")]
		public string GBCHAPMCBGD(string KKMCHAOLGFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6317B40", Offset = "0x6316D40", VA = "0x186317B40")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct DFDOINJOGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public string PBMKAJCGFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool HNJEGNHKPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool BHKJJHLFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public float GJGICNJPPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float MCJJPPHNFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool POFAIKPGHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx NHFGDOEKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public RigidbodyEx LAFAOOJHJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public RigidbodyEx PFMKGJMHJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public RigidbodyEx GOLIGPJEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform AHILOGLMCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform LNJBKKMFLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform DOAHMOGPOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public PlayerAvatarFullBodyColliders COBPAIHAFJK;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IIMJGMEKKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Transform JLBNELNPGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Transform JINFPGOGNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public AvatarConfiguration JFGPCBBBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Animator GBOPKPCKNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public VRIK KOEJBOHAMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public SkeletonLODUpdateRate[] FKMKAIKDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public GameObject[] FKBOFNGOBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform DIELLIOPMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject JDPFMFDEGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs AAMBJGAILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs OFFEDMAMPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public GameObject CBOJINMPOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public BodySkinnedMeshLODs JONDFBEGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BodySkinnedMeshLODs BFEIDNFLOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public CFBDLFAJGKM NLNDNGKMDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Material DEKLJKMFOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Material DMAJKKHBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Shader IOLACECGNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform LJDJEKGCPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform GLJBACMDAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Transform NEPKBLDLLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Transform PEKNMDJPIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Transform BFNMIMMIFHD;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct OCJOLNNODFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float OOMDNMMLOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool LHOLCEAGDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public AMBBOEBJPNH MJEMHMELENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 MHLFKOCKJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 EEHBCAIBLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3? HKEKDMKGGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3? LPBPALIAHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool EBFBPAHKCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool EACELCMMNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool ANDNBMMGAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool NHIDPCEMAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool HPMDGGJJBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? AKCHNDFOLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool AAIGFFGDDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? MBGGPMFMEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool ONLKKMFEONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3? NKHHBFAKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3? PIPKPAFMJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool KDOFFBOHIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool GGKKBCOMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool PBKFKPPNGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool MJGKMFCADEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool OFNCDOGJBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool BMEFNLHKNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool OABPAKIBDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool PIKDJAKMOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool NOMCNLLMPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool ACHMDLKCHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public Vector3? GBAMBKIIHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public GHCICEFBOGM LLCECCCBKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public GHCICEFBOGM LIBAPKACAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public float AOKFEJLALJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float GIGJPDBOIIN;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KNGMOOLONDN
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDPHPFGBBLM();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EHOCIICLNGN<Texture2D> OOMLGNKLEMG(LINLOKECLME LNKODFBLOKJ, [Optional] NPONIOGJIAI HMJOKPKOPCN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GLDFLDHKJIJ : KNGMOOLONDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private DIIJMGOGNLM LNLOOMAPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private IRecRoomQualityConfigProvider HIEOMHJMALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool MBHFDAJBDEO;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private const uint OCDKCOEMGMH = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x631BA90", Offset = "0x631AC90", VA = "0x18631BA90")]
	[IOFOCEAPGPD(NPBJMIOJGOK.None)]
	private static void FHCJHIEHNLG(MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	[Preserve]
	public GLDFLDHKJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x631BB80", Offset = "0x631AD80", VA = "0x18631BB80")]
	private void KHKCCJIPHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x631B820", Offset = "0x631AA20", VA = "0x18631B820", Slot = "4")]
	public void BDPHPFGBBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x631BC30", Offset = "0x631AE30", VA = "0x18631BC30", Slot = "5")]
	public global::EHOCIICLNGN<Texture2D> OOMLGNKLEMG(LINLOKECLME LNKODFBLOKJ, [Optional] NPONIOGJIAI HMJOKPKOPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x631B880", Offset = "0x631AA80", VA = "0x18631B880")]
	private uint FEDHIDNBFCD(LINLOKECLME LNKODFBLOKJ, NPONIOGJIAI HMJOKPKOPCN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DLEDANBFNON
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NPONIOGJIAI
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly NPONIOGJIAI FBJHBFFDBDJ;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int ONEPJHCAAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E49D0", Offset = "0x7E3BD0", VA = "0x1807E49D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DLEDANBFNON HCIGPAGOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830")]
		[CompilerGenerated]
		get
		{
			return default(DLEDANBFNON);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E49E0", Offset = "0x7E3BE0", VA = "0x1807E49E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NPONIOGJIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x631E5A0", Offset = "0x631D7A0", VA = "0x18631E5A0")]
	public NPONIOGJIAI(DLEDANBFNON DNLPIHIBJDP, int KGKIDBLHOLL)
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
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x631A220", Offset = "0x6319420", VA = "0x18631A220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x631A160", Offset = "0x6319360", VA = "0x18631A160")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6319960", Offset = "0x6318B60", VA = "0x186319960")]
		public void CNDCFHCHDOL(FitMeshHemisphere PACEHLCICOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x63199B0", Offset = "0x6318BB0", VA = "0x1863199B0")]
		public Vector3 DHEDODPMONG(Vector2 JFKENNAIEBE, bool GJAFFEJGIKG = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6319CF0", Offset = "0x6318EF0", VA = "0x186319CF0")]
		public Vector3 EGMFPIJFDKA(Vector2 JFKENNAIEBE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6319D90", Offset = "0x6318F90", VA = "0x186319D90")]
		public Quaternion HCNLPOFMHLF(Vector2 JFKENNAIEBE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6319EC0", Offset = "0x63190C0", VA = "0x186319EC0")]
		public Quaternion HCNLPOFMHLF(Vector2 JFKENNAIEBE, Vector3 OKAIJMIFELI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6319D50", Offset = "0x6318F50", VA = "0x186319D50")]
		private Vector2 FJGLHLOENKD(Vector2 NBDAOIJKIEA)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct BKFAEPELDIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly GameObject EAIJHGJOCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly AvatarItemMaterial EFKDFAJHFCO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AEB30", VA = "0x1807AF930")]
	public BKFAEPELDIB(GameObject EAIJHGJOCNP, AvatarItemMaterial EFKDFAJHFCO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GGIPJKGNPJF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x631B7F0", Offset = "0x631A9F0", VA = "0x18631B7F0")]
	public static bool LECNNLFOPJM(this OutfitType EHGPLLEIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x631B7B0", Offset = "0x631A9B0", VA = "0x18631B7B0")]
	public static bool DDDJLGGAKIG(this OutfitType EHGPLLEIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x631B7E0", Offset = "0x631A9E0", VA = "0x18631B7E0")]
	public static bool IABEMPFOLPE(this OutfitType EHGPLLEIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x631B7D0", Offset = "0x631A9D0", VA = "0x18631B7D0")]
	public static bool GLMDKPFFAKA(this OutfitType EHGPLLEIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x631B7A0", Offset = "0x631A9A0", VA = "0x18631B7A0")]
	public static bool ACHIALNMOLD(this OutfitType EHGPLLEIIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x631B810", Offset = "0x631AA10", VA = "0x18631B810")]
	public static bool LNHFDLKAAPE(this OutfitType EHGPLLEIIBB)
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
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private CFBDLFAJGKM LFKFHILDLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Collider[] CDAHDDJJBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Collider[] GDEBHGHGJAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x631E660", Offset = "0x631D860", VA = "0x18631E660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x631E5E0", Offset = "0x631D7E0", VA = "0x18631E5E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x631E820", Offset = "0x631DA20", VA = "0x18631E820")]
		public void UpdateBones(CFBDLFAJGKM PAAINPJHDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x631E6D0", Offset = "0x631D8D0", VA = "0x18631E6D0")]
		public void SetCollidersEnabled(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x631E850", Offset = "0x631DA50", VA = "0x18631E850")]
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
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7A84C0", Offset = "0x7A76C0", VA = "0x1807A84C0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6317B90", Offset = "0x6316D90", VA = "0x186317B90")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6317B90", Offset = "0x6316D90", VA = "0x186317B90")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6318D00", Offset = "0x6317F00", VA = "0x186318D00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1767410", Offset = "0x1766610", VA = "0x181767410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x106C0A0", Offset = "0x106B2A0", VA = "0x18106C0A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x852BC0", Offset = "0x851DC0", VA = "0x180852BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6318BD0", Offset = "0x6317DD0", VA = "0x186318BD0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6318C80", Offset = "0x6317E80", VA = "0x186318C80")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6318BB0", Offset = "0x6317DB0", VA = "0x186318BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4175360", Offset = "0x4174560", VA = "0x184175360")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x853030", Offset = "0x852230", VA = "0x180853030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x63189E0", Offset = "0x6317BE0", VA = "0x1863189E0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6318A50", Offset = "0x6317C50", VA = "0x186318A50", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6318AD0", Offset = "0x6317CD0", VA = "0x186318AD0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class HIDAODIFFIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class ACIBGKEJGAP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly Texture2DArray NAFKHKHEFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly Dictionary<string, int> MGFFEGMMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly FIHGBEHGLGB JKONHCJJAIL;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool BLJCBDJOEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x112E5A0", Offset = "0x112D7A0", VA = "0x18112E5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6316A80", Offset = "0x6315C80", VA = "0x186316A80")]
		public ACIBGKEJGAP(Texture2DArray JAPEFKNEPJD, Dictionary<string, int> HIJBFNOJCLF, HIDAODIFFIL IJDNAFPINKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x861760", Offset = "0x860960", VA = "0x180861760")]
		public void BBODGMJNGOJ(HIDAODIFFIL IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x861CD0", Offset = "0x860ED0", VA = "0x180861CD0")]
		public void OPFOIOBPKNA(HIDAODIFFIL IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xD2BD50", Offset = "0xD2AF50", VA = "0x180D2BD50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MPBIAABFPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string OKGCIPDBBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly string GHFIHOJPNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private readonly string DDEPCCJLFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly string KMFOOAKNNND;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x501FDC0", Offset = "0x501EFC0", VA = "0x18501FDC0")]
		public MPBIAABFPCM(string EPPBCCEKNCB, string GLMDNMPIDIN, string AAOFCEFEGOP, string LLKMMEOJADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x631DE50", Offset = "0x631D050", VA = "0x18631DE50")]
		public bool OFPEIHMPLIL(MPBIAABFPCM HNPEBINPOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x631DCA0", Offset = "0x631CEA0", VA = "0x18631DCA0", Slot = "0")]
		public override bool Equals(object ICHBECDKHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x631DD80", Offset = "0x631CF80", VA = "0x18631DD80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x631DE50", Offset = "0x631D050", VA = "0x18631DE50")]
		public static bool IGOCGGBJBII(MPBIAABFPCM DNDNMGOKFEI, MPBIAABFPCM OHMMPNACNJO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x631DC10", Offset = "0x631CE10", VA = "0x18631DC10")]
		public static bool BHBKJCPJNJN(MPBIAABFPCM DNDNMGOKFEI, MPBIAABFPCM OHMMPNACNJO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Dictionary<string, int> HIJBFNOJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly MPBIAABFPCM JFODGLAHLDP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Texture2DArray AHHPFOMGPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB00", Offset = "0x6FED00", VA = "0x1806FFB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature NFCAOBKMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public SymmetricalFaceFeature NMBAJMAGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public SymmetricalFaceFeature LIIPILMIMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FaceFeature CIPJKDMDMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x814E40", Offset = "0x814040", VA = "0x180814E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x631C040", Offset = "0x631B240", VA = "0x18631C040")]
	private static void CGBLMFCPJBM(Sprite KACGCLMJFGF, Sprite MPECELGBHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x631C360", Offset = "0x631B560", VA = "0x18631C360")]
	private static void KJJBDCCHMCH(Sprite DLADPCHJMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x631D020", Offset = "0x631C220", VA = "0x18631D020")]
	public HIDAODIFFIL(SymmetricalFaceFeature CDHADFCPLAF, FaceFeature FCOBEDNIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x631C3D0", Offset = "0x631B5D0", VA = "0x18631C3D0")]
	public HIDAODIFFIL(SymmetricalFaceFeature IEIIDFDJPMA, SymmetricalFaceFeature CDHADFCPLAF, SymmetricalFaceFeature EPOBNGCIPEP, FaceFeature FCOBEDNIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x631C150", Offset = "0x631B350", VA = "0x18631C150")]
	public bool HAOEDCEKOKH(Sprite DLADPCHJMME, out int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x631C140", Offset = "0x631B340", VA = "0x18631C140", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		EyeGleams = 4,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public SymmetricalFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public SymmetricalFaceFeature[] EyeGleams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, SymmetricalFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private Dictionary<string, SymmetricalFaceFeature> eyeGleamFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6319930", Offset = "0x6318B30", VA = "0x186319930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6319220", Offset = "0x6318420", VA = "0x186319220")]
		public HIDAODIFFIL MDIFLHFJODN(int CDHADFCPLAF, int FCOBEDNIIOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6318FA0", Offset = "0x63181A0", VA = "0x186318FA0")]
		public HIDAODIFFIL MDIFLHFJODN(int KPFGMGFKDOK, int CDHADFCPLAF, int MGHMDGGAEEO, int FCOBEDNIIOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6318D20", Offset = "0x6317F20", VA = "0x186318D20")]
		public FaceFeatureBase BCCOBBOMHIB(FaceFeatureType OABKPMOCHBJ, string JMIFIJDBMNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6319820", Offset = "0x6318A20", VA = "0x186319820")]
		public int PIMNDIKFKKI(string JMIFIJDBMNM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x63194C0", Offset = "0x63186C0", VA = "0x1863194C0")]
		private void OCMHKLJCPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x149B760", Offset = "0x149A960", VA = "0x18149B760")]
		private void MKANOHDACCF<T>(Dictionary<string, T> OEGCIGPEFGP, T[] PDOBLDEMNEK) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6318EB0", Offset = "0x63180B0", VA = "0x186318EB0")]
		public string KDNNLIIFOEM(FaceFeatureType OABKPMOCHBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x63196A0", Offset = "0x63188A0", VA = "0x1863196A0")]
		public string OMJDJPDKMAK(FaceFeatureType OABKPMOCHBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x63198B0", Offset = "0x6318AB0", VA = "0x1863198B0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AA0", Offset = "0x7A6CA0", VA = "0x1807A7AA0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x631DEE0", Offset = "0x631D0E0", VA = "0x18631DEE0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7DA680", VA = "0x1807DB480", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x631DEE0", Offset = "0x631D0E0", VA = "0x18631DEE0")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x631EAB0", Offset = "0x631DCB0", VA = "0x18631EAB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3EFC570", Offset = "0x3EFB770", VA = "0x183EFC570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xD4D6E0", Offset = "0xD4C8E0", VA = "0x180D4D6E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3EFC560", Offset = "0x3EFB760", VA = "0x183EFC560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xD4D6A0", Offset = "0xD4C8A0", VA = "0x180D4D6A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2303290", Offset = "0x2302490", VA = "0x182303290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xD4D600", Offset = "0xD4C800", VA = "0x180D4D600")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x631EAD0", Offset = "0x631DCD0", VA = "0x18631EAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x631E9A0", Offset = "0x631DBA0", VA = "0x18631E9A0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6317B90", Offset = "0x6316D90", VA = "0x186317B90")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x631DEF0", Offset = "0x631D0F0", VA = "0x18631DEF0")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x631E000", Offset = "0x631D200", VA = "0x18631E000")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
