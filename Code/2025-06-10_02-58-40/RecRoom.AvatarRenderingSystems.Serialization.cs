using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DPPKCEMMDPI : IADOEIIHEDH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC216D0", Offset = "0xC208D0", VA = "0x180C216D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0630", Offset = "0x7ACF830", VA = "0x187AD0630", Slot = "36")]
	protected override Vector3 OIMHDIKDLDO(float[] LMKJLPPFOFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AD05B0", Offset = "0x7ACF7B0", VA = "0x187AD05B0", Slot = "37")]
	protected override float[] LAKGJCBGJBH(Vector3 KJIOHKMJAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0680", Offset = "0x7ACF880", VA = "0x187AD0680")]
	public DPPKCEMMDPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PAMBJKHFOIA : IADOEIIHEDH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC38130", Offset = "0xC37330", VA = "0x180C38130", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4A20", Offset = "0x7AD3C20", VA = "0x187AD4A20", Slot = "36")]
	protected override Vector2 OIMHDIKDLDO(float[] LMKJLPPFOFC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AD49B0", Offset = "0x7AD3BB0", VA = "0x187AD49B0", Slot = "37")]
	protected override float[] LAKGJCBGJBH(Vector2 KJIOHKMJAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4A60", Offset = "0x7AD3C60", VA = "0x187AD4A60")]
	public PAMBJKHFOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AJHEFMFCCFH : IADOEIIHEDH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA7210", Offset = "0xAA6410", VA = "0x180AA7210", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF060", Offset = "0x7ACE260", VA = "0x187ACF060", Slot = "36")]
	protected override Quaternion OIMHDIKDLDO(float[] LMKJLPPFOFC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEFD0", Offset = "0x7ACE1D0", VA = "0x187ACEFD0", Slot = "37")]
	protected override float[] LAKGJCBGJBH(Quaternion KJIOHKMJAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF0C0", Offset = "0x7ACE2C0", VA = "0x187ACF0C0")]
	public AJHEFMFCCFH()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum IANHGOEJFCK
		{
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			Prerelease = 0,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			InitialRelease = 1,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CurrentPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Current = 1
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static JsonSerializerOptions Options;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IANHGOEJFCK Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
			[CompilerGenerated]
			get
			{
				return default(IANHGOEJFCK);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF200", Offset = "0x7ACE400", VA = "0x187ACF200", Slot = "0")]
		public override bool Equals(object CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF100", Offset = "0x7ACE300", VA = "0x187ACF100")]
		public static bool EEDHALGLIEL(AvatarItemDownloadableConfig KEAFHNNEEAN, AvatarItemDownloadableConfig FNKKBNJEBAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF330", Offset = "0x7ACE530", VA = "0x187ACF330", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF400", Offset = "0x7ACE600", VA = "0x187ACF400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF46BB0", Offset = "0xF45DB0", VA = "0x180F46BB0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, DAGBLJJIGGP, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SerializedAvatarItemId AvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SerializedCombinationId CombinationId;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4F70", Offset = "0x7AD4170", VA = "0x187AD4F70")]
		private void CGBLILPPPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5000", Offset = "0x7AD4200", VA = "0x187AD5000", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5080", Offset = "0x7AD4280", VA = "0x187AD5080", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4F70", Offset = "0x7AD4170", VA = "0x187AD4F70", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5180", Offset = "0x7AD4380", VA = "0x187AD5180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNBJNMGNPPH : JCBKMEFONLN<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NJGBGNIKHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NJGBGNIKHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4030", Offset = "0x7AD3230", VA = "0x187AD4030")]
		internal void MAHMFOBMKGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3C30", Offset = "0x7AD2E30", VA = "0x187AD3C30")]
		internal void BICDAHFLOGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3EE0", Offset = "0x7AD30E0", VA = "0x187AD3EE0")]
		internal void GICHGEGJDAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4190", Offset = "0x7AD3390", VA = "0x187AD4190")]
		internal void OHCMHHMDMDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3B80", Offset = "0x7AD2D80", VA = "0x187AD3B80")]
		internal void BANMHLFIGBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3D90", Offset = "0x7AD2F90", VA = "0x187AD3D90")]
		internal void DMDEHAJJOJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3CE0", Offset = "0x7AD2EE0", VA = "0x187AD3CE0")]
		internal void CAIIJJHOEEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD40E0", Offset = "0x7AD32E0", VA = "0x187AD40E0")]
		internal void NKPOEIKILCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3F90", Offset = "0x7AD3190", VA = "0x187AD3F90")]
		internal void JNNMCEPLKCP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3E40", Offset = "0x7AD3040", VA = "0x187AD3E40")]
		internal void FANIAOMFBBH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EBKGAIIDAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3330", Offset = "0x7AD2530", VA = "0x187AD3330", Slot = "35")]
	public override void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, AnchorParamsRestrictions LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2EA0", Offset = "0x7AD20A0", VA = "0x187AD2EA0", Slot = "36")]
	public override void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, AnchorParamsRestrictions KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3850", Offset = "0x7AD2A50", VA = "0x187AD3850")]
	public LNBJNMGNPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3ACCE90", Offset = "0x3ACC090", VA = "0x183ACCE90")]
	[CompilerGenerated]
	internal static void AMJCDLLHBPM<T>(string KGBLLKPNCLE, T DIPIKNPCGFJ, T CLENAHCIIEE, EBKGAIIDAEP P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KEAMKMABGFO : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void JJMHKHAELBB(Utf8JsonReader EJNMHOGNAED);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HICIKHJPBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public SerializedAvatarItemData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public bool hasReadOutfitType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KEAMKMABGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JJMHKHAELBB <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JJMHKHAELBB <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JJMHKHAELBB <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public JJMHKHAELBB <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JJMHKHAELBB <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JJMHKHAELBB <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JJMHKHAELBB <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JJMHKHAELBB <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JJMHKHAELBB <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JJMHKHAELBB <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JJMHKHAELBB <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HICIKHJPBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AD19F0", Offset = "0x7AD0BF0", VA = "0x187AD19F0")]
		internal void NPOEJKKIIAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1730", Offset = "0x7AD0930", VA = "0x187AD1730")]
		internal void IKFMLFOKKHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1500", Offset = "0x7AD0700", VA = "0x187AD1500")]
		internal void DKEEKIHOIEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1890", Offset = "0x7AD0A90", VA = "0x187AD1890")]
		internal void LNIPHDLDKIO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD17E0", Offset = "0x7AD09E0", VA = "0x187AD17E0")]
		internal void KDGMBFGIPJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD19C0", Offset = "0x7AD0BC0", VA = "0x187AD19C0")]
		internal void MIKIOGJNMKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1940", Offset = "0x7AD0B40", VA = "0x187AD1940")]
		internal void MBIGPGHCOPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD15B0", Offset = "0x7AD07B0", VA = "0x187AD15B0")]
		internal void GAHJEBIAOKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD14C0", Offset = "0x7AD06C0", VA = "0x187AD14C0")]
		internal void COAHBNNFFLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1690", Offset = "0x7AD0890", VA = "0x187AD1690")]
		internal void HPAFMPCNEPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1340", Offset = "0x7AD0540", VA = "0x187AD1340")]
		internal void AMLAHBLOHHG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BDFBNCNAICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BDFBNCNAICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFC90", Offset = "0x7ACEE90", VA = "0x187ACFC90")]
		internal void ANBDILKIBBA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1BA0", Offset = "0x7AD0DA0", VA = "0x187AD1BA0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2780", Offset = "0x7AD1980", VA = "0x187AD2780", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, SerializedAvatarItemData KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1A30", Offset = "0x7AD0C30", VA = "0x187AD1A30")]
	private AdditionalOutfitTypeData OICIPGDIELE(Utf8JsonReader GBOEOLHFKIL, OutfitType GDHKDBJPDLG, JsonSerializerOptions AFJJJNJGALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2BC0", Offset = "0x7AD1DC0", VA = "0x187AD2BC0")]
	public KEAMKMABGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EJBJPGPNLHM : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AD06C0", Offset = "0x7ACF8C0", VA = "0x187AD06C0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader GBOEOLHFKIL, Type MLPFAKIMNHM, JsonSerializerOptions AFJJJNJGALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0A50", Offset = "0x7ACFC50", VA = "0x187AD0A50", Slot = "28")]
	public override void Write(Utf8JsonWriter HLPFOKGJOHH, AvatarItemDownloadableConfig KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0B80", Offset = "0x7ACFD80", VA = "0x187AD0B80")]
	public EJBJPGPNLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OKBOHOGDDDD : JCBKMEFONLN<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AD47D0", Offset = "0x7AD39D0", VA = "0x187AD47D0", Slot = "35")]
	public override void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, BeardData LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4710", Offset = "0x7AD3910", VA = "0x187AD4710", Slot = "36")]
	public override void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, BeardData KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4970", Offset = "0x7AD3B70", VA = "0x187AD4970")]
	public OKBOHOGDDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GOHLMNIGNPF : HANDCEDPGKH<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1300", Offset = "0x7AD0500", VA = "0x187AD1300")]
	public GOHLMNIGNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GBMOIEIMODL : HANDCEDPGKH<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD12C0", Offset = "0x7AD04C0", VA = "0x187AD12C0")]
	public GBMOIEIMODL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CILHOMAMDFD : HANDCEDPGKH<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFD90", Offset = "0x7ACEF90", VA = "0x187ACFD90")]
	public CILHOMAMDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AFKPPAIBPBJ : KDNCFFODNBL<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEF90", Offset = "0x7ACE190", VA = "0x187ACEF90")]
	public AFKPPAIBPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LILPIDJHOOE : JCBKMEFONLN<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CCEPENABHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CCEPENABHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFD60", Offset = "0x7ACEF60", VA = "0x187ACFD60")]
		internal void MAHMFOBMKGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFD30", Offset = "0x7ACEF30", VA = "0x187ACFD30")]
		internal void BICDAHFLOGA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2CD0", Offset = "0x7AD1ED0", VA = "0x187AD2CD0", Slot = "35")]
	public override void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, AdditionalFeetData LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2C00", Offset = "0x7AD1E00", VA = "0x187AD2C00", Slot = "36")]
	public override void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, AdditionalFeetData KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2E60", Offset = "0x7AD2060", VA = "0x187AD2E60")]
	public LILPIDJHOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ELDHJLKAKKA : JCBKMEFONLN<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MAIPDJOGLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MAIPDJOGLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3A30", Offset = "0x7AD2C30", VA = "0x187AD3A30")]
		internal void MAHMFOBMKGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3930", Offset = "0x7AD2B30", VA = "0x187AD3930")]
		internal void BICDAHFLOGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3A00", Offset = "0x7AD2C00", VA = "0x187AD3A00")]
		internal void GICHGEGJDAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3AE0", Offset = "0x7AD2CE0", VA = "0x187AD3AE0")]
		internal void OHCMHHMDMDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3890", Offset = "0x7AD2A90", VA = "0x187AD3890")]
		internal void BANMHLFIGBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3960", Offset = "0x7AD2B60", VA = "0x187AD3960")]
		internal void DMDEHAJJOJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFD60", Offset = "0x7ACEF60", VA = "0x187ACFD60")]
		internal void CAIIJJHOEEH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0E90", Offset = "0x7AD0090", VA = "0x187AD0E90", Slot = "35")]
	public override void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, HairData LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0BC0", Offset = "0x7ACFDC0", VA = "0x187AD0BC0", Slot = "36")]
	public override void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, HairData KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1280", Offset = "0x7AD0480", VA = "0x187AD1280")]
	public ELDHJLKAKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DHFBKGMDJJB : JCBKMEFONLN<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NNBHECMCFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NNBHECMCFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4590", Offset = "0x7AD3790", VA = "0x187AD4590")]
		internal void MAHMFOBMKGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AD42F0", Offset = "0x7AD34F0", VA = "0x187AD42F0")]
		internal void BICDAHFLOGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AD44E0", Offset = "0x7AD36E0", VA = "0x187AD44E0")]
		internal void GICHGEGJDAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4660", Offset = "0x7AD3860", VA = "0x187AD4660")]
		internal void OHCMHHMDMDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4240", Offset = "0x7AD3440", VA = "0x187AD4240")]
		internal void BANMHLFIGBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4440", Offset = "0x7AD3640", VA = "0x187AD4440")]
		internal void DMDEHAJJOJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD43A0", Offset = "0x7AD35A0", VA = "0x187AD43A0")]
		internal void CAIIJJHOEEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD45C0", Offset = "0x7AD37C0", VA = "0x187AD45C0")]
		internal void NKPOEIKILCA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0110", Offset = "0x7ACF310", VA = "0x187AD0110", Slot = "35")]
	public override void HPOIBLPMIOL(Utf8JsonReader GBOEOLHFKIL, JsonSerializerOptions AFJJJNJGALF, string KGBLLKPNCLE, AdditionalHatData LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFDD0", Offset = "0x7ACEFD0", VA = "0x187ACFDD0", Slot = "36")]
	public override void DNJICJHEBDO(Utf8JsonWriter HLPFOKGJOHH, AdditionalHatData KJIOHKMJAPE, JsonSerializerOptions AFJJJNJGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0570", Offset = "0x7ACF770", VA = "0x187AD0570")]
	public DHFBKGMDJJB()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE222D0", Offset = "0xE214D0", VA = "0x180E222D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE222C0", Offset = "0xE214C0", VA = "0x180E222C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF6B010", Offset = "0xF6A210", VA = "0x180F6B010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF6B150", Offset = "0xF6A350", VA = "0x180F6B150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x20252C0", Offset = "0x20244C0", VA = "0x1820252C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7AD4F60", Offset = "0x7AD4160", VA = "0x187AD4F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2CADC90", Offset = "0x2CACE90", VA = "0x182CADC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2CADBE0", Offset = "0x2CACDE0", VA = "0x182CADBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD12D00", Offset = "0xD11F00", VA = "0x180D12D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD12D50", Offset = "0xD11F50", VA = "0x180D12D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OFCOHJLOKGA.PFHBFKIKAIN ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
			[CompilerGenerated]
			get
			{
				return default(OFCOHJLOKGA.PFHBFKIKAIN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6E89520", Offset = "0x6E88720", VA = "0x186E89520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4AC0", Offset = "0x7AD3CC0", VA = "0x187AD4AC0", Slot = "0")]
		public override bool Equals(object CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4AA0", Offset = "0x7AD3CA0", VA = "0x187AD4AA0")]
		public static bool EEDHALGLIEL(SerializedAvatarItemData KEAFHNNEEAN, SerializedAvatarItemData FNKKBNJEBAC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4F30", Offset = "0x7AD4130", VA = "0x187AD4F30")]
		public static bool JGFOFPDALHN(SerializedAvatarItemData KEAFHNNEEAN, SerializedAvatarItemData FNKKBNJEBAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4B40", Offset = "0x7AD3D40", VA = "0x187AD4B40", Slot = "4")]
		public bool Equals(SerializedAvatarItemData CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4E60", Offset = "0x7AD4060", VA = "0x187AD4E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public SerializedAvatarItemData()
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
