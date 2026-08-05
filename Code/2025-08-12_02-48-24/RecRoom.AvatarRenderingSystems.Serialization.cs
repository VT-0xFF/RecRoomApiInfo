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
public class PFPHOAAGCMF : OABKFOFEKEL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1ED40", Offset = "0xD1D340", VA = "0x180D1ED40", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x82CEC60", Offset = "0x82CD260", VA = "0x1882CEC60", Slot = "36")]
	protected override Vector3 MKMLKCAKKLA(float[] DMJEPOICLBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82CECB0", Offset = "0x82CD2B0", VA = "0x1882CECB0", Slot = "37")]
	protected override float[] POAGEPOACJA(Vector3 FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82CED30", Offset = "0x82CD330", VA = "0x1882CED30")]
	public PFPHOAAGCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CFFFPGKJLGF : OABKFOFEKEL<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF6010", Offset = "0xAF4610", VA = "0x180AF6010", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82CA8A0", Offset = "0x82C8EA0", VA = "0x1882CA8A0", Slot = "36")]
	protected override Vector2 MKMLKCAKKLA(float[] DMJEPOICLBJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82CA8E0", Offset = "0x82C8EE0", VA = "0x1882CA8E0", Slot = "37")]
	protected override float[] POAGEPOACJA(Vector2 FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82CA950", Offset = "0x82C8F50", VA = "0x1882CA950")]
	public CFFFPGKJLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HEGPALAAKAB : OABKFOFEKEL<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB9A9C0", Offset = "0xB98FC0", VA = "0x180B9A9C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82CC320", Offset = "0x82CA920", VA = "0x1882CC320", Slot = "36")]
	protected override Quaternion MKMLKCAKKLA(float[] DMJEPOICLBJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82CC380", Offset = "0x82CA980", VA = "0x1882CC380", Slot = "37")]
	protected override float[] POAGEPOACJA(Quaternion FKMNCAKIOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82CC410", Offset = "0x82CAA10", VA = "0x1882CC410")]
	public HEGPALAAKAB()
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
		public enum GGBHPICIKGP
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
		public GGBHPICIKGP Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
			[CompilerGenerated]
			get
			{
				return default(GGBHPICIKGP);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82C9750", Offset = "0x82C7D50", VA = "0x1882C9750", Slot = "0")]
		public override bool Equals(object IBCMCOKAJEM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82C99C0", Offset = "0x82C7FC0", VA = "0x1882C99C0")]
		public static bool LMIMJGGKHMP(AvatarItemDownloadableConfig LEOAACGBJCD, AvatarItemDownloadableConfig GDBFOEGEGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82C9880", Offset = "0x82C7E80", VA = "0x1882C9880", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82C9950", Offset = "0x82C7F50", VA = "0x1882C9950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10911E0", Offset = "0x108F7E0", VA = "0x1810911E0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, NFJHEOPKPGK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x82CFD60", Offset = "0x82CE360", VA = "0x1882CFD60")]
		private void HFIMLKJDDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBE0", Offset = "0x82CE1E0", VA = "0x1882CFBE0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82CFC60", Offset = "0x82CE260", VA = "0x1882CFC60", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD60", Offset = "0x82CE360", VA = "0x1882CFD60", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82CFDD0", Offset = "0x82CE3D0", VA = "0x1882CFDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MKNAGGCDIPK : NFCONJKAELH<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ADHDHKHICFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ADHDHKHICFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82C8C70", Offset = "0x82C7270", VA = "0x1882C8C70")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82C8E70", Offset = "0x82C7470", VA = "0x1882C8E70")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82C8BC0", Offset = "0x82C71C0", VA = "0x1882C8BC0")]
		internal void CPCPBIMFIKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82C8FD0", Offset = "0x82C75D0", VA = "0x1882C8FD0")]
		internal void INECPABMHNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82C91D0", Offset = "0x82C77D0", VA = "0x1882C91D0")]
		internal void PIHBCECGMOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82C8F20", Offset = "0x82C7520", VA = "0x1882C8F20")]
		internal void IHPAIKHPKDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82C9120", Offset = "0x82C7720", VA = "0x1882C9120")]
		internal void OKAMODMMFHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82C8DC0", Offset = "0x82C73C0", VA = "0x1882C8DC0")]
		internal void HHKMIGPCMHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82C8D20", Offset = "0x82C7320", VA = "0x1882C8D20")]
		internal void EPGLCFIHGLF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82C9080", Offset = "0x82C7680", VA = "0x1882C9080")]
		internal void MLFPCLFMLCH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BFBFEEKHLKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82CCF10", Offset = "0x82CB510", VA = "0x1882CCF10", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, AnchorParamsRestrictions KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82CD430", Offset = "0x82CBA30", VA = "0x1882CD430", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, AnchorParamsRestrictions FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82CD8D0", Offset = "0x82CBED0", VA = "0x1882CD8D0")]
	public MKNAGGCDIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC7C0", Offset = "0x3EAADC0", VA = "0x183EAC7C0")]
	[CompilerGenerated]
	internal static void JLCHJKBHKEG<T>(string NBPDNNFOMKB, T PGNMBFKGLAH, T LINPOJPHBNG, BFBFEEKHLKI P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FCCJMPKCHJM : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void NLMKCJGPPOG(Utf8JsonReader FIECNFDCBKN);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MLAHDIFFKJG
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
		public FCCJMPKCHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NLMKCJGPPOG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NLMKCJGPPOG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NLMKCJGPPOG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NLMKCJGPPOG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public NLMKCJGPPOG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NLMKCJGPPOG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NLMKCJGPPOG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NLMKCJGPPOG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NLMKCJGPPOG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NLMKCJGPPOG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NLMKCJGPPOG <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MLAHDIFFKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82CDC00", Offset = "0x82CC200", VA = "0x1882CDC00")]
		internal void GJGDLGMIBNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82CDDB0", Offset = "0x82CC3B0", VA = "0x1882CDDB0")]
		internal void OAPKODHDNIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82CD910", Offset = "0x82CBF10", VA = "0x1882CD910")]
		internal void DEJGPNGNLHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82CDAA0", Offset = "0x82CC0A0", VA = "0x1882CDAA0")]
		internal void EFOKDEOGNFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82CDB50", Offset = "0x82CC150", VA = "0x1882CDB50")]
		internal void FBBHPFFFIDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE60", Offset = "0x82CC460", VA = "0x1882CDE60")]
		internal void OEIFLEIAAOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82CDCE0", Offset = "0x82CC2E0", VA = "0x1882CDCE0")]
		internal void JFADFGAMICN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82CD9C0", Offset = "0x82CBFC0", VA = "0x1882CD9C0")]
		internal void EEADKIPIONB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE90", Offset = "0x82CC490", VA = "0x1882CDE90")]
		internal void PPKCOIGHPEP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82CDC40", Offset = "0x82CC240", VA = "0x1882CDC40")]
		internal void GKFFMDCIGLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82CDD60", Offset = "0x82CC360", VA = "0x1882CDD60")]
		internal void KGJGHBLODPG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MPGKBICNHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MPGKBICNHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82CDED0", Offset = "0x82CC4D0", VA = "0x1882CDED0")]
		internal void GPINDKIDGIK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82CAFB0", Offset = "0x82C95B0", VA = "0x1882CAFB0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82CBBB0", Offset = "0x82CA1B0", VA = "0x1882CBBB0", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, SerializedAvatarItemData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82CACD0", Offset = "0x82C92D0", VA = "0x1882CACD0")]
	private AdditionalOutfitTypeData PCPLGNDKPFC(Utf8JsonReader EMPLJNKCONI, OutfitType EHLAHNIAPLD, JsonSerializerOptions EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82CBFF0", Offset = "0x82CA5F0", VA = "0x1882CBFF0")]
	public FCCJMPKCHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OOAHNCPICLF : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82CE760", Offset = "0x82CCD60", VA = "0x1882CE760", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader EMPLJNKCONI, Type FEAPJKAJCPI, JsonSerializerOptions EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82CEAF0", Offset = "0x82CD0F0", VA = "0x1882CEAF0", Slot = "28")]
	public override void Write(Utf8JsonWriter ENKMBIEHHDM, AvatarItemDownloadableConfig FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82CEC20", Offset = "0x82CD220", VA = "0x1882CEC20")]
	public OOAHNCPICLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EPELPCBILFH : NFCONJKAELH<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82CAA30", Offset = "0x82C9030", VA = "0x1882CAA30", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, BeardData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82CABD0", Offset = "0x82C91D0", VA = "0x1882CABD0", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, BeardData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82CAC90", Offset = "0x82C9290", VA = "0x1882CAC90")]
	public EPELPCBILFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JNFDDDHEKLH : KIJMAKAPMFM<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82CC490", Offset = "0x82CAA90", VA = "0x1882CC490")]
	public JNFDDDHEKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CAKJJMMIKAH : KIJMAKAPMFM<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82CA820", Offset = "0x82C8E20", VA = "0x1882CA820")]
	public CAKJJMMIKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IMDKMLCHOGE : KIJMAKAPMFM<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82CC450", Offset = "0x82CAA50", VA = "0x1882CC450")]
	public IMDKMLCHOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BKKDIMMCHCI : OHFBNPALMGD<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82CA580", Offset = "0x82C8B80", VA = "0x1882CA580")]
	public BKKDIMMCHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LJNNIHDBAFI : NFCONJKAELH<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BJANNFONCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BJANNFONCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82CA520", Offset = "0x82C8B20", VA = "0x1882CA520")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82CA550", Offset = "0x82C8B50", VA = "0x1882CA550")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82CC6E0", Offset = "0x82CACE0", VA = "0x1882CC6E0", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, AdditionalFeetData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82CC870", Offset = "0x82CAE70", VA = "0x1882CC870", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, AdditionalFeetData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82CC940", Offset = "0x82CAF40", VA = "0x1882CC940")]
	public LJNNIHDBAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PPMPHLMIDNM : NFCONJKAELH<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HADBKBHHEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HADBKBHHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82CC060", Offset = "0x82CA660", VA = "0x1882CC060")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82CC110", Offset = "0x82CA710", VA = "0x1882CC110")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82CC030", Offset = "0x82CA630", VA = "0x1882CC030")]
		internal void CPCPBIMFIKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82CC1E0", Offset = "0x82CA7E0", VA = "0x1882CC1E0")]
		internal void INECPABMHNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82CC280", Offset = "0x82CA880", VA = "0x1882CC280")]
		internal void PIHBCECGMOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82CC140", Offset = "0x82CA740", VA = "0x1882CC140")]
		internal void IHPAIKHPKDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82CA520", Offset = "0x82C8B20", VA = "0x1882CA520")]
		internal void OKAMODMMFHF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82CEFD0", Offset = "0x82CD5D0", VA = "0x1882CEFD0", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, HairData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82CF3C0", Offset = "0x82CD9C0", VA = "0x1882CF3C0", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, HairData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82CF6A0", Offset = "0x82CDCA0", VA = "0x1882CF6A0")]
	public PPMPHLMIDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OGNGLEHFAHN : NFCONJKAELH<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AJBLNLGLMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public AJBLNLGLMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82C9330", Offset = "0x82C7930", VA = "0x1882C9330")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82C9400", Offset = "0x82C7A00", VA = "0x1882C9400")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82C9280", Offset = "0x82C7880", VA = "0x1882C9280")]
		internal void CPCPBIMFIKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82C9550", Offset = "0x82C7B50", VA = "0x1882C9550")]
		internal void INECPABMHNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82C96A0", Offset = "0x82C7CA0", VA = "0x1882C96A0")]
		internal void PIHBCECGMOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82C94B0", Offset = "0x82C7AB0", VA = "0x1882C94B0")]
		internal void IHPAIKHPKDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82C9600", Offset = "0x82C7C00", VA = "0x1882C9600")]
		internal void OKAMODMMFHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82C9360", Offset = "0x82C7960", VA = "0x1882C9360")]
		internal void HHKMIGPCMHK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82CDF70", Offset = "0x82CC570", VA = "0x1882CDF70", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, AdditionalHatData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82CE3D0", Offset = "0x82CC9D0", VA = "0x1882CE3D0", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, AdditionalHatData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82CE720", Offset = "0x82CCD20", VA = "0x1882CE720")]
	public OGNGLEHFAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KJAHKNIKDFP : NFCONJKAELH<RoomieEquipmentData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ONIILGEGDNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieEquipmentData item;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ONIILGEGDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82C9330", Offset = "0x82C7930", VA = "0x1882C9330")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82CC4D0", Offset = "0x82CAAD0", VA = "0x1882CC4D0", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, RoomieEquipmentData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82CC610", Offset = "0x82CAC10", VA = "0x1882CC610", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, RoomieEquipmentData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82CC6A0", Offset = "0x82CACA0", VA = "0x1882CC6A0")]
	public KJAHKNIKDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CAJJCLMDBEK : NFCONJKAELH<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LAEPJLGKFJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LAEPJLGKFJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x82C8C70", Offset = "0x82C7270", VA = "0x1882C8C70")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82CA860", Offset = "0x82C8E60", VA = "0x1882CA860")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82CA5C0", Offset = "0x82C8BC0", VA = "0x1882CA5C0", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, RoomieEyeData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82CA750", Offset = "0x82C8D50", VA = "0x1882CA750", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, RoomieEyeData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82CA7E0", Offset = "0x82C8DE0", VA = "0x1882CA7E0")]
	public CAJJCLMDBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MGEFJIBFGBH : NFCONJKAELH<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CNLDAACHMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CNLDAACHMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82C8C70", Offset = "0x82C7270", VA = "0x1882C8C70")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82CA860", Offset = "0x82C8E60", VA = "0x1882CA860")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82CA990", Offset = "0x82C8F90", VA = "0x1882CA990")]
		internal void CPCPBIMFIKM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82CCBE0", Offset = "0x82CB1E0", VA = "0x1882CCBE0", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, RoomieHatData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82CCDD0", Offset = "0x82CB3D0", VA = "0x1882CCDD0", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, RoomieHatData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82CCED0", Offset = "0x82CB4D0", VA = "0x1882CCED0")]
	public MGEFJIBFGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LNCEJNIFCEK : NFCONJKAELH<RoomieMouthData>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CBNFGMFOLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public RoomieMouthData item;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CBNFGMFOLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82C8C70", Offset = "0x82C7270", VA = "0x1882C8C70")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82CA860", Offset = "0x82C8E60", VA = "0x1882CA860")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82CC980", Offset = "0x82CAF80", VA = "0x1882CC980", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, RoomieMouthData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82CCB10", Offset = "0x82CB110", VA = "0x1882CCB10", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, RoomieMouthData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82CCBA0", Offset = "0x82CB1A0", VA = "0x1882CCBA0")]
	public LNCEJNIFCEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PILAKOJIKNI : NFCONJKAELH<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IHFPOBJICIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IHFPOBJICIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x82C8C70", Offset = "0x82C7270", VA = "0x1882C8C70")]
		internal void EJNMPDPIKLJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82CA860", Offset = "0x82C8E60", VA = "0x1882CA860")]
		internal void HIINPPJCKEH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82CED70", Offset = "0x82CD370", VA = "0x1882CED70", Slot = "35")]
	public override void BJEEGLNFIDB(Utf8JsonReader EMPLJNKCONI, JsonSerializerOptions EEPOAHLOJPI, string NBPDNNFOMKB, RoomieWaistData KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82CEF00", Offset = "0x82CD500", VA = "0x1882CEF00", Slot = "36")]
	public override void HNGCGILABGE(Utf8JsonWriter ENKMBIEHHDM, RoomieWaistData FKMNCAKIOFK, JsonSerializerOptions EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82CEF90", Offset = "0x82CD590", VA = "0x1882CEF90")]
	public PILAKOJIKNI()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xF65250", Offset = "0xF63850", VA = "0x180F65250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xF65260", Offset = "0xF63860", VA = "0x180F65260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x10A5A10", Offset = "0x10A4010", VA = "0x1810A5A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x10A5E10", Offset = "0x10A4410", VA = "0x1810A5E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2292370", Offset = "0x2290970", VA = "0x182292370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x82CFBB0", Offset = "0x82CE1B0", VA = "0x1882CFBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2F248E0", Offset = "0x2F22EE0", VA = "0x182F248E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2F24820", Offset = "0x2F22E20", VA = "0x182F24820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAE3800", Offset = "0xAE1E00", VA = "0x180AE3800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE1E10", VA = "0x180AE3810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LINIKLIADHK.NMCDOKKFLGH ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			[CompilerGenerated]
			get
			{
				return default(LINIKLIADHK.NMCDOKKFLGH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x13DE260", Offset = "0x13DC860", VA = "0x1813DE260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA96310", Offset = "0xA94910", VA = "0x180A96310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x82CF6E0", Offset = "0x82CDCE0", VA = "0x1882CF6E0", Slot = "0")]
		public override bool Equals(object IBCMCOKAJEM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82CFB60", Offset = "0x82CE160", VA = "0x1882CFB60")]
		public static bool LMIMJGGKHMP(SerializedAvatarItemData LEOAACGBJCD, SerializedAvatarItemData GDBFOEGEGHN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82CFB80", Offset = "0x82CE180", VA = "0x1882CFB80")]
		public static bool PACMOMIAEBP(SerializedAvatarItemData LEOAACGBJCD, SerializedAvatarItemData GDBFOEGEGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82CF770", Offset = "0x82CDD70", VA = "0x1882CF770", Slot = "4")]
		public bool Equals(SerializedAvatarItemData IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82CFA90", Offset = "0x82CE090", VA = "0x1882CFA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
