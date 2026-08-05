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
public class FGOLOCBBNHK : GEBLCJMBEGI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB705C0", Offset = "0xB6EDC0", VA = "0x180B705C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79A8930", Offset = "0x79A7130", VA = "0x1879A8930", Slot = "36")]
	protected override Vector3 APBJPKEFBJG(float[] MGEDIIGJIGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79A8980", Offset = "0x79A7180", VA = "0x1879A8980", Slot = "37")]
	protected override float[] FINOOPDOPBB(Vector3 OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79A8A00", Offset = "0x79A7200", VA = "0x1879A8A00")]
	public FGOLOCBBNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CNLNAIBECNI : GEBLCJMBEGI<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB36E0", VA = "0x180BB4EE0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x79A7270", Offset = "0x79A5A70", VA = "0x1879A7270", Slot = "36")]
	protected override Vector2 APBJPKEFBJG(float[] MGEDIIGJIGC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79A72B0", Offset = "0x79A5AB0", VA = "0x1879A72B0", Slot = "37")]
	protected override float[] FINOOPDOPBB(Vector2 OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79A7320", Offset = "0x79A5B20", VA = "0x1879A7320")]
	public CNLNAIBECNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NCCGNFJFAPH : GEBLCJMBEGI<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBB51B0", Offset = "0xBB39B0", VA = "0x180BB51B0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79A9660", Offset = "0x79A7E60", VA = "0x1879A9660", Slot = "36")]
	protected override Quaternion APBJPKEFBJG(float[] MGEDIIGJIGC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79A96C0", Offset = "0x79A7EC0", VA = "0x1879A96C0", Slot = "37")]
	protected override float[] FINOOPDOPBB(Quaternion OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79A9750", Offset = "0x79A7F50", VA = "0x1879A9750")]
	public NCCGNFJFAPH()
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
		public enum HMHLNDPKKNG
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
		public HMHLNDPKKNG Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(HMHLNDPKKNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79A5270", Offset = "0x79A3A70", VA = "0x1879A5270", Slot = "0")]
		public override bool Equals(object PGPJMFPAKOO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79A54E0", Offset = "0x79A3CE0", VA = "0x1879A54E0")]
		public static bool NIDGPKKMDPO(AvatarItemDownloadableConfig HKAFAMHBCLL, AvatarItemDownloadableConfig JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x79A53A0", Offset = "0x79A3BA0", VA = "0x1879A53A0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x79A5470", Offset = "0x79A3C70", VA = "0x1879A5470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEF10E0", Offset = "0xEEF8E0", VA = "0x180EF10E0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, EHKBGADHGBA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x79AA350", Offset = "0x79A8B50", VA = "0x1879AA350")]
		private void CAOEIBPFPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3E0", Offset = "0x79A8BE0", VA = "0x1879AA3E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79AA460", Offset = "0x79A8C60", VA = "0x1879AA460", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79AA350", Offset = "0x79A8B50", VA = "0x1879AA350", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x79AA560", Offset = "0x79A8D60", VA = "0x1879AA560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AAKGOCBMANL : AFKCBBDDCBO<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DBBOCFGEHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DBBOCFGEHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x79A80F0", Offset = "0x79A68F0", VA = "0x1879A80F0")]
		internal void JLGAGGEMGLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79A7D90", Offset = "0x79A6590", VA = "0x1879A7D90")]
		internal void GJOMANDGFND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x79A7EF0", Offset = "0x79A66F0", VA = "0x1879A7EF0")]
		internal void HGJOFLNCFLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x79A7E40", Offset = "0x79A6640", VA = "0x1879A7E40")]
		internal void GJOPOJMMBAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x79A7FA0", Offset = "0x79A67A0", VA = "0x1879A7FA0")]
		internal void IDFNHJHCPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x79A7CE0", Offset = "0x79A64E0", VA = "0x1879A7CE0")]
		internal void FPCLNEIDHAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x79A7C30", Offset = "0x79A6430", VA = "0x1879A7C30")]
		internal void ENPJDEPODFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B80", Offset = "0x79A6380", VA = "0x1879A7B80")]
		internal void CADBKANIBPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x79A81A0", Offset = "0x79A69A0", VA = "0x1879A81A0")]
		internal void OKGBKAAONBK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79A8050", Offset = "0x79A6850", VA = "0x1879A8050")]
		internal void IIHMJDKMNNA(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CNONMOOGMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79A4810", Offset = "0x79A3010", VA = "0x1879A4810", Slot = "35")]
	public override void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, AnchorParamsRestrictions BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79A4380", Offset = "0x79A2B80", VA = "0x1879A4380", Slot = "36")]
	public override void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, AnchorParamsRestrictions OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79A4D30", Offset = "0x79A3530", VA = "0x1879A4D30")]
	public AAKGOCBMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCF60", Offset = "0x3EFB760", VA = "0x183EFCF60")]
	[CompilerGenerated]
	internal static void POJCFFJAKPG<T>(string KCHPJMPLPDP, T DDLBJHGGANE, T AAKLAFGNGHI, CNONMOOGMMB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CNKOFBCHAJP : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void GEDCIHEDBLG(Utf8JsonReader GGILEDABHIF);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EPHFPJCADIN
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
		public CNKOFBCHAJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GEDCIHEDBLG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GEDCIHEDBLG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GEDCIHEDBLG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public GEDCIHEDBLG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GEDCIHEDBLG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GEDCIHEDBLG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GEDCIHEDBLG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GEDCIHEDBLG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GEDCIHEDBLG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GEDCIHEDBLG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GEDCIHEDBLG <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EPHFPJCADIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79A8640", Offset = "0x79A6E40", VA = "0x1879A8640")]
		internal void HPKKCGIAFJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79A8880", Offset = "0x79A7080", VA = "0x1879A8880")]
		internal void MMHJIELPLLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79A8240", Offset = "0x79A6A40", VA = "0x1879A8240")]
		internal void AKJDHFPABJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79A82F0", Offset = "0x79A6AF0", VA = "0x1879A82F0")]
		internal void APLGDNGHOBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79A8590", Offset = "0x79A6D90", VA = "0x1879A8590")]
		internal void GLECMJILDHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x79A8520", Offset = "0x79A6D20", VA = "0x1879A8520")]
		internal void FEOPBIAMPEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79A8680", Offset = "0x79A6E80", VA = "0x1879A8680")]
		internal void JMPKKHDLILD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x79A83A0", Offset = "0x79A6BA0", VA = "0x1879A83A0")]
		internal void BBAFEJPMIPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x79A8550", Offset = "0x79A6D50", VA = "0x1879A8550")]
		internal void GAHNPAJAEKC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79A8480", Offset = "0x79A6C80", VA = "0x1879A8480")]
		internal void FAEBEELAEND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79A8700", Offset = "0x79A6F00", VA = "0x1879A8700")]
		internal void LIAGACKJNFG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NBNJAABNFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NBNJAABNFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x79A95C0", Offset = "0x79A7DC0", VA = "0x1879A95C0")]
		internal void MAJJDAAPJPA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x79A6210", Offset = "0x79A4A10", VA = "0x1879A6210", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79A6DF0", Offset = "0x79A55F0", VA = "0x1879A6DF0", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, SerializedAvatarItemData OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79A60A0", Offset = "0x79A48A0", VA = "0x1879A60A0")]
	private AdditionalOutfitTypeData GJCPDDJLABM(Utf8JsonReader DMPKKEDJKBJ, OutfitType PIJHKCJDAHO, JsonSerializerOptions AKIEDMONOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x79A7230", Offset = "0x79A5A30", VA = "0x1879A7230")]
	public CNKOFBCHAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AOHEEJDJLHI : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79A4D70", Offset = "0x79A3570", VA = "0x1879A4D70", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DMPKKEDJKBJ, Type BFFDAIGKELI, JsonSerializerOptions AKIEDMONOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79A5100", Offset = "0x79A3900", VA = "0x1879A5100", Slot = "28")]
	public override void Write(Utf8JsonWriter HIKMEOJBJOJ, AvatarItemDownloadableConfig OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x79A5230", Offset = "0x79A3A30", VA = "0x1879A5230")]
	public AOHEEJDJLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HDAEKIOENMI : AFKCBBDDCBO<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79A8BA0", Offset = "0x79A73A0", VA = "0x1879A8BA0", Slot = "35")]
	public override void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, BeardData BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79A8AE0", Offset = "0x79A72E0", VA = "0x1879A8AE0", Slot = "36")]
	public override void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, BeardData OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79A8D40", Offset = "0x79A7540", VA = "0x1879A8D40")]
	public HDAEKIOENMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DABMCBAMAEK : EJJIFOKHCPC<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79A7B40", Offset = "0x79A6340", VA = "0x1879A7B40")]
	public DABMCBAMAEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JNBPFGNBBFM : EJJIFOKHCPC<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79A8DC0", Offset = "0x79A75C0", VA = "0x1879A8DC0")]
	public JNBPFGNBBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IJHEAEPBOPP : EJJIFOKHCPC<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79A8D80", Offset = "0x79A7580", VA = "0x1879A8D80")]
	public IJHEAEPBOPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FNFHCIKOLCC : OINGPPAIFMB<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79A8A40", Offset = "0x79A7240", VA = "0x1879A8A40")]
	public FNFHCIKOLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BFDBJNLEPKI : AFKCBBDDCBO<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HACBPEEJIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HACBPEEJIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x79A8AB0", Offset = "0x79A72B0", VA = "0x1879A8AB0")]
		internal void JLGAGGEMGLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79A8A80", Offset = "0x79A7280", VA = "0x1879A8A80")]
		internal void GJOMANDGFND(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79A5ED0", Offset = "0x79A46D0", VA = "0x1879A5ED0", Slot = "35")]
	public override void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, AdditionalFeetData BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79A5E00", Offset = "0x79A4600", VA = "0x1879A5E00", Slot = "36")]
	public override void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, AdditionalFeetData OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x79A6060", Offset = "0x79A4860", VA = "0x1879A6060")]
	public BFDBJNLEPKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OEKGKHOLADI : AFKCBBDDCBO<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LEHAIEMCFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LEHAIEMCFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79A9040", Offset = "0x79A7840", VA = "0x1879A9040")]
		internal void JLGAGGEMGLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x79A8EA0", Offset = "0x79A76A0", VA = "0x1879A8EA0")]
		internal void GJOMANDGFND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79A8F70", Offset = "0x79A7770", VA = "0x1879A8F70")]
		internal void HGJOFLNCFLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x79A8ED0", Offset = "0x79A76D0", VA = "0x1879A8ED0")]
		internal void GJOPOJMMBAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79A8FA0", Offset = "0x79A77A0", VA = "0x1879A8FA0")]
		internal void IDFNHJHCPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79A8E00", Offset = "0x79A7600", VA = "0x1879A8E00")]
		internal void FPCLNEIDHAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79A8AB0", Offset = "0x79A72B0", VA = "0x1879A8AB0")]
		internal void ENPJDEPODFC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79A9A60", Offset = "0x79A8260", VA = "0x1879A9A60", Slot = "35")]
	public override void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, HairData BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79A9790", Offset = "0x79A7F90", VA = "0x1879A9790", Slot = "36")]
	public override void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, HairData OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x79A9E50", Offset = "0x79A8650", VA = "0x1879A9E50")]
	public OEKGKHOLADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class COBGOJPNAKN : AFKCBBDDCBO<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MBLNNGNBKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MBLNNGNBKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79A9590", Offset = "0x79A7D90", VA = "0x1879A9590")]
		internal void JLGAGGEMGLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x79A92D0", Offset = "0x79A7AD0", VA = "0x1879A92D0")]
		internal void GJOMANDGFND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79A9430", Offset = "0x79A7C30", VA = "0x1879A9430")]
		internal void HGJOFLNCFLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x79A9380", Offset = "0x79A7B80", VA = "0x1879A9380")]
		internal void GJOPOJMMBAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79A94E0", Offset = "0x79A7CE0", VA = "0x1879A94E0")]
		internal void IDFNHJHCPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79A9230", Offset = "0x79A7A30", VA = "0x1879A9230")]
		internal void FPCLNEIDHAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79A9190", Offset = "0x79A7990", VA = "0x1879A9190")]
		internal void ENPJDEPODFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79A90F0", Offset = "0x79A78F0", VA = "0x1879A90F0")]
		internal void CADBKANIBPO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79A76A0", Offset = "0x79A5EA0", VA = "0x1879A76A0", Slot = "35")]
	public override void OOGJENLGCFO(Utf8JsonReader DMPKKEDJKBJ, JsonSerializerOptions AKIEDMONOFM, string KCHPJMPLPDP, AdditionalHatData BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x79A7360", Offset = "0x79A5B60", VA = "0x1879A7360", Slot = "36")]
	public override void MOGDIDIMJKC(Utf8JsonWriter HIKMEOJBJOJ, AdditionalHatData OPMIAMEJKDH, JsonSerializerOptions AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x79A7B00", Offset = "0x79A6300", VA = "0x1879A7B00")]
	public COBGOJPNAKN()
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
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD83860", Offset = "0xD82060", VA = "0x180D83860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD83870", Offset = "0xD82070", VA = "0x180D83870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF06800", Offset = "0xF05000", VA = "0x180F06800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF06980", Offset = "0xF05180", VA = "0x180F06980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF2A930", Offset = "0xF29130", VA = "0x180F2A930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xF2BC90", Offset = "0xF2A490", VA = "0x180F2BC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B14550", Offset = "0x2B12D50", VA = "0x182B14550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B14480", Offset = "0x2B12C80", VA = "0x182B14480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC78FE0", Offset = "0xC777E0", VA = "0x180C78FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC79030", Offset = "0xC77830", VA = "0x180C79030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HHPKDLEJEOP.OOIFDIEICOH ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
			[CompilerGenerated]
			get
			{
				return default(HHPKDLEJEOP.OOIFDIEICOH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x79A9E90", Offset = "0x79A8690", VA = "0x1879A9E90", Slot = "0")]
		public override bool Equals(object PGPJMFPAKOO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79AA300", Offset = "0x79A8B00", VA = "0x1879AA300")]
		public static bool NIDGPKKMDPO(SerializedAvatarItemData HKAFAMHBCLL, SerializedAvatarItemData JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79AA320", Offset = "0x79A8B20", VA = "0x1879AA320")]
		public static bool ONONOJDPAAN(SerializedAvatarItemData HKAFAMHBCLL, SerializedAvatarItemData JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x79A9F10", Offset = "0x79A8710", VA = "0x1879A9F10", Slot = "4")]
		public bool Equals(SerializedAvatarItemData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x79AA230", Offset = "0x79A8A30", VA = "0x1879AA230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
