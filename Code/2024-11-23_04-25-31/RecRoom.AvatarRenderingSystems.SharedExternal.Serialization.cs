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
public class NONMBCAPGAF : MEMONMNJFAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x941530", Offset = "0x93FF30", VA = "0x180941530", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C92D50", Offset = "0x6C91750", VA = "0x186C92D50", Slot = "36")]
	protected override Vector3 HCGMJONKNPD(float[] KJCKFFGBDON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C92DA0", Offset = "0x6C917A0", VA = "0x186C92DA0", Slot = "37")]
	protected override float[] KLJILCNGCPK(Vector3 PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C92E20", Offset = "0x6C91820", VA = "0x186C92E20")]
	public NONMBCAPGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OPIBGDPFGBE : MEMONMNJFAG<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x93C4F0", Offset = "0x93AEF0", VA = "0x18093C4F0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C93220", Offset = "0x6C91C20", VA = "0x186C93220", Slot = "36")]
	protected override Vector2 HCGMJONKNPD(float[] KJCKFFGBDON)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C93260", Offset = "0x6C91C60", VA = "0x186C93260", Slot = "37")]
	protected override float[] KLJILCNGCPK(Vector2 PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C932D0", Offset = "0x6C91CD0", VA = "0x186C932D0")]
	public OPIBGDPFGBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EEBFBFLFABG : MEMONMNJFAG<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x949760", Offset = "0x948160", VA = "0x180949760", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F300", Offset = "0x6C8DD00", VA = "0x186C8F300", Slot = "36")]
	protected override Quaternion HCGMJONKNPD(float[] KJCKFFGBDON)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F360", Offset = "0x6C8DD60", VA = "0x186C8F360", Slot = "37")]
	protected override float[] KLJILCNGCPK(Quaternion PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F3F0", Offset = "0x6C8DDF0", VA = "0x186C8F3F0")]
	public EEBFBFLFABG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum GCNDABGJBJA
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
		public GCNDABGJBJA Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0")]
			[CompilerGenerated]
			get
			{
				return default(GCNDABGJBJA);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA869C0", Offset = "0xA853C0", VA = "0x180A869C0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, CHMODCOCIAL, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C935A0", Offset = "0x6C91FA0", VA = "0x186C935A0")]
		public SerializedAvatarItemSelection(KPJKPOMJGHE IPNEJFBPGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C93320", Offset = "0x6C91D20", VA = "0x186C93320")]
		private void CAKMHIJGMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C933B0", Offset = "0x6C91DB0", VA = "0x186C933B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C93430", Offset = "0x6C91E30", VA = "0x186C93430", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C93320", Offset = "0x6C91D20", VA = "0x186C93320", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C93530", Offset = "0x6C91F30", VA = "0x186C93530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MABAFKHIPLH : JDLKEOMFPEG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KPIIIBAOIOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KPIIIBAOIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C91590", Offset = "0x6C8FF90", VA = "0x186C91590")]
		internal void LLMEGFFDNBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C91230", Offset = "0x6C8FC30", VA = "0x186C91230")]
		internal void ECJHBABHPHH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C91390", Offset = "0x6C8FD90", VA = "0x186C91390")]
		internal void FGHNMNIJDPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C912E0", Offset = "0x6C8FCE0", VA = "0x186C912E0")]
		internal void EDEBMLCCIFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C91440", Offset = "0x6C8FE40", VA = "0x186C91440")]
		internal void HGFMBMGLJMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C91640", Offset = "0x6C90040", VA = "0x186C91640")]
		internal void MOJEFFMLODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C910D0", Offset = "0x6C8FAD0", VA = "0x186C910D0")]
		internal void BEKEELCNCII(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C91180", Offset = "0x6C8FB80", VA = "0x186C91180")]
		internal void DENJPPADMBK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C916F0", Offset = "0x6C900F0", VA = "0x186C916F0")]
		internal void OENFJHKFCGD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C914F0", Offset = "0x6C8FEF0", VA = "0x186C914F0")]
		internal void HOODGCOGILI(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AKDOILAJJDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C91790", Offset = "0x6C90190", VA = "0x186C91790", Slot = "35")]
	public override void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, AnchorParamsRestrictions GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C91CB0", Offset = "0x6C906B0", VA = "0x186C91CB0", Slot = "36")]
	public override void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, AnchorParamsRestrictions PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C92140", Offset = "0x6C90B40", VA = "0x186C92140")]
	public MABAFKHIPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1B80", Offset = "0x2FD0580", VA = "0x182FD1B80")]
	[CompilerGenerated]
	internal static void HDGMJHACFBG<T>(string NHDAMJEEJKD, T JBKDPHAINMM, T OHIIICDFHLK, AKDOILAJJDD P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HNGJCNKBLCM : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void MEBPNMEMECH(Utf8JsonReader ECOIDHGKBHK);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NNFJCGPNNBI
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
		public HNGJCNKBLCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public MEBPNMEMECH <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MEBPNMEMECH <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MEBPNMEMECH <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public MEBPNMEMECH <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MEBPNMEMECH <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MEBPNMEMECH <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MEBPNMEMECH <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MEBPNMEMECH <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MEBPNMEMECH <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MEBPNMEMECH <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MEBPNMEMECH <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NNFJCGPNNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C92810", Offset = "0x6C91210", VA = "0x186C92810")]
		internal void GBLCJAFPCLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C92900", Offset = "0x6C91300", VA = "0x186C92900")]
		internal void IDEMLJKKCJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C92A60", Offset = "0x6C91460", VA = "0x186C92A60")]
		internal void LNICBHJFHKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C92850", Offset = "0x6C91250", VA = "0x186C92850")]
		internal void HDJAGHNOGMA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C929B0", Offset = "0x6C913B0", VA = "0x186C929B0")]
		internal void JPHPKHBHEGK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C90E80", Offset = "0x6C8F880", VA = "0x186C90E80")]
		internal void BPGJPCDDEGB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C92B50", Offset = "0x6C91550", VA = "0x186C92B50")]
		internal void OCKDLOOIGLK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C92690", Offset = "0x6C91090", VA = "0x186C92690")]
		internal void CJGPAOCAKEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C92B10", Offset = "0x6C91510", VA = "0x186C92B10")]
		internal void NOMDEIMKKJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6C92770", Offset = "0x6C91170", VA = "0x186C92770")]
		internal void FDBILIFJCCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C92BD0", Offset = "0x6C915D0", VA = "0x186C92BD0")]
		internal void PCNKIBNCNEK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OCMLICMCADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OCMLICMCADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C93140", Offset = "0x6C91B40", VA = "0x186C93140")]
		internal void KBNMGMCBIKL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FA90", Offset = "0x6C8E490", VA = "0x186C8FA90", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C90670", Offset = "0x6C8F070", VA = "0x186C90670", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, SerializedAvatarItemData PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F920", Offset = "0x6C8E320", VA = "0x186C8F920")]
	private AdditionalOutfitTypeData DAACHPHHNDJ(Utf8JsonReader NIEHEDECLKP, OutfitType BKKHBFLPOHJ, JsonSerializerOptions JKPMAFPDDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C90AA0", Offset = "0x6C8F4A0", VA = "0x186C90AA0")]
	public HNGJCNKBLCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HMHHGFFGCNJ : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F430", Offset = "0x6C8DE30", VA = "0x186C8F430", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader NIEHEDECLKP, Type OMHNIBBACOF, JsonSerializerOptions JKPMAFPDDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F7C0", Offset = "0x6C8E1C0", VA = "0x186C8F7C0", Slot = "28")]
	public override void Write(Utf8JsonWriter KPBMLLGEOOP, AvatarItemDownloadableConfig PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F8E0", Offset = "0x6C8E2E0", VA = "0x186C8F8E0")]
	public HMHHGFFGCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OAGGOOFBLCK : JDLKEOMFPEG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C92E60", Offset = "0x6C91860", VA = "0x186C92E60", Slot = "35")]
	public override void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, BeardData GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C93000", Offset = "0x6C91A00", VA = "0x186C93000", Slot = "36")]
	public override void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, BeardData PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C930C0", Offset = "0x6C91AC0", VA = "0x186C930C0")]
	public OAGGOOFBLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MJPNGLKBHDH : GJDGOPCAMDP<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C92650", Offset = "0x6C91050", VA = "0x186C92650")]
	public MJPNGLKBHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OBOHBHPIDJD : GJDGOPCAMDP<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C93100", Offset = "0x6C91B00", VA = "0x186C93100")]
	public OBOHBHPIDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OMIKOCDALEM : GJDGOPCAMDP<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C931E0", Offset = "0x6C91BE0", VA = "0x186C931E0")]
	public OMIKOCDALEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DLABGLKPJFN : MBGFFLLLMGL<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EAE0", Offset = "0x6C8D4E0", VA = "0x186C8EAE0")]
	public DLABGLKPJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JAOODFJBOJK : JDLKEOMFPEG<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KJNEFACFDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KJNEFACFDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C90D80", Offset = "0x6C8F780", VA = "0x186C90D80")]
		internal void LLMEGFFDNBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C910A0", Offset = "0x6C8FAA0", VA = "0x186C910A0")]
		internal void ECJHBABHPHH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C90AE0", Offset = "0x6C8F4E0", VA = "0x186C90AE0", Slot = "35")]
	public override void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, AdditionalFeetData GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C90C70", Offset = "0x6C8F670", VA = "0x186C90C70", Slot = "36")]
	public override void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, AdditionalFeetData PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C90D40", Offset = "0x6C8F740", VA = "0x186C90D40")]
	public JAOODFJBOJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CLFNADBMNLG : JDLKEOMFPEG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KDDCPIHPLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KDDCPIHPLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C90F50", Offset = "0x6C8F950", VA = "0x186C90F50")]
		internal void LLMEGFFDNBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C90DB0", Offset = "0x6C8F7B0", VA = "0x186C90DB0")]
		internal void ECJHBABHPHH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C90E80", Offset = "0x6C8F880", VA = "0x186C90E80")]
		internal void FGHNMNIJDPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C90DE0", Offset = "0x6C8F7E0", VA = "0x186C90DE0")]
		internal void EDEBMLCCIFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C90EB0", Offset = "0x6C8F8B0", VA = "0x186C90EB0")]
		internal void HGFMBMGLJMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C91000", Offset = "0x6C8FA00", VA = "0x186C91000")]
		internal void MOJEFFMLODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C90D80", Offset = "0x6C8F780", VA = "0x186C90D80")]
		internal void BEKEELCNCII(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E3E0", Offset = "0x6C8CDE0", VA = "0x186C8E3E0", Slot = "35")]
	public override void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, HairData GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E7D0", Offset = "0x6C8D1D0", VA = "0x186C8E7D0", Slot = "36")]
	public override void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, HairData PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EAA0", Offset = "0x6C8D4A0", VA = "0x186C8EAA0")]
	public CLFNADBMNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EBIJKGPJOAD : JDLKEOMFPEG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MDHGAIFFLCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MDHGAIFFLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C92580", Offset = "0x6C90F80", VA = "0x186C92580")]
		internal void LLMEGFFDNBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C922C0", Offset = "0x6C90CC0", VA = "0x186C922C0")]
		internal void ECJHBABHPHH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C92420", Offset = "0x6C90E20", VA = "0x186C92420")]
		internal void FGHNMNIJDPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C92370", Offset = "0x6C90D70", VA = "0x186C92370")]
		internal void EDEBMLCCIFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C924D0", Offset = "0x6C90ED0", VA = "0x186C924D0")]
		internal void HGFMBMGLJMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C925B0", Offset = "0x6C90FB0", VA = "0x186C925B0")]
		internal void MOJEFFMLODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C92180", Offset = "0x6C90B80", VA = "0x186C92180")]
		internal void BEKEELCNCII(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C92220", Offset = "0x6C90C20", VA = "0x186C92220")]
		internal void DENJPPADMBK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EB20", Offset = "0x6C8D520", VA = "0x186C8EB20", Slot = "35")]
	public override void AEODACKECBB(Utf8JsonReader NIEHEDECLKP, JsonSerializerOptions JKPMAFPDDOK, string NHDAMJEEJKD, AdditionalHatData GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EF80", Offset = "0x6C8D980", VA = "0x186C8EF80", Slot = "36")]
	public override void AKNCPIBGBCB(Utf8JsonWriter KPBMLLGEOOP, AdditionalHatData PKCLPFEIPFH, JsonSerializerOptions JKPMAFPDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F2C0", Offset = "0x6C8DCC0", VA = "0x186C8F2C0")]
	public EBIJKGPJOAD()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D40", Offset = "0x8B3740", VA = "0x1808B4D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9A2DD0", Offset = "0x9A17D0", VA = "0x1809A2DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C90", Offset = "0x9A1690", VA = "0x1809A2C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A2DE0", Offset = "0x9A17E0", VA = "0x1809A2DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A2CA0", Offset = "0x9A16A0", VA = "0x1809A2CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA9D880", Offset = "0xA9C280", VA = "0x180A9D880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA9D870", Offset = "0xA9C270", VA = "0x180A9D870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1886780", Offset = "0x1885180", VA = "0x181886780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6C93310", Offset = "0x6C91D10", VA = "0x186C93310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x25FC900", Offset = "0x25FB300", VA = "0x1825FC900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x25FC8F0", Offset = "0x25FB2F0", VA = "0x1825FC8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1E99690", Offset = "0x1E98090", VA = "0x181E99690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1E996A0", Offset = "0x1E980A0", VA = "0x181E996A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NFCEEHLKBBE.NIHDBPDBFFB ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA14640", Offset = "0xA13040", VA = "0x180A14640")]
			[CompilerGenerated]
			get
			{
				return default(NFCEEHLKBBE.NIHDBPDBFFB);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA146D0", Offset = "0xA130D0", VA = "0x180A146D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8B0120", Offset = "0x8AEB20", VA = "0x1808B0120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
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
