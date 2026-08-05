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
public class NDINNGCIHPC : FNCIJBJGMCP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91D180", Offset = "0x91B980", VA = "0x18091D180", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8480", Offset = "0x6DE6C80", VA = "0x186DE8480", Slot = "36")]
	protected override Vector3 FFHKMPFBLMA(float[] MCAFGDLBCDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DE84D0", Offset = "0x6DE6CD0", VA = "0x186DE84D0", Slot = "37")]
	protected override float[] KDPLNHBOMLF(Vector3 INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8550", Offset = "0x6DE6D50", VA = "0x186DE8550")]
	public NDINNGCIHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DMHAEEECPGD : FNCIJBJGMCP<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x926710", Offset = "0x924F10", VA = "0x180926710", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DE44D0", Offset = "0x6DE2CD0", VA = "0x186DE44D0", Slot = "36")]
	protected override Vector2 FFHKMPFBLMA(float[] MCAFGDLBCDD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4510", Offset = "0x6DE2D10", VA = "0x186DE4510", Slot = "37")]
	protected override float[] KDPLNHBOMLF(Vector2 INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4580", Offset = "0x6DE2D80", VA = "0x186DE4580")]
	public DMHAEEECPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HMJOAKPGFLD : FNCIJBJGMCP<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A74F0", Offset = "0x9A5CF0", VA = "0x1809A74F0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7E00", Offset = "0x6DE6600", VA = "0x186DE7E00", Slot = "36")]
	protected override Quaternion FFHKMPFBLMA(float[] MCAFGDLBCDD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7E60", Offset = "0x6DE6660", VA = "0x186DE7E60", Slot = "37")]
	protected override float[] KDPLNHBOMLF(Quaternion INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7EF0", Offset = "0x6DE66F0", VA = "0x186DE7EF0")]
	public HMJOAKPGFLD()
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
		public enum JDKNGMCMIHB
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
		public JDKNGMCMIHB Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
			[CompilerGenerated]
			get
			{
				return default(JDKNGMCMIHB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DE31A0", Offset = "0x6DE19A0", VA = "0x186DE31A0", Slot = "0")]
		public override bool Equals(object LIHCAHPMPHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3410", Offset = "0x6DE1C10", VA = "0x186DE3410")]
		public static bool PCBECHOJFKF(AvatarItemDownloadableConfig CBNNCMPLCDK, AvatarItemDownloadableConfig OKJLFDLNFEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DE32D0", Offset = "0x6DE1AD0", VA = "0x186DE32D0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DE33A0", Offset = "0x6DE1BA0", VA = "0x186DE33A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAE8680", Offset = "0xAE6E80", VA = "0x180AE8680")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, NLLKPNMALIA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6DE92F0", Offset = "0x6DE7AF0", VA = "0x186DE92F0")]
		private void MICBFJEEKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9170", Offset = "0x6DE7970", VA = "0x186DE9170", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DE91F0", Offset = "0x6DE79F0", VA = "0x186DE91F0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92F0", Offset = "0x6DE7AF0", VA = "0x186DE92F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9360", Offset = "0x6DE7B60", VA = "0x186DE9360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GKADMKIOEPI : MEPDFMPCCKM<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FILLCCLEBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FILLCCLEBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6DE61B0", Offset = "0x6DE49B0", VA = "0x186DE61B0")]
		internal void GHJNKEEDGBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DE63A0", Offset = "0x6DE4BA0", VA = "0x186DE63A0")]
		internal void LCOLCDMLLCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DE5FA0", Offset = "0x6DE47A0", VA = "0x186DE5FA0")]
		internal void BBEIBLCNMAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6500", Offset = "0x6DE4D00", VA = "0x186DE6500")]
		internal void OOEEKIFOAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6050", Offset = "0x6DE4850", VA = "0x186DE6050")]
		internal void DCJIADNMDBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6100", Offset = "0x6DE4900", VA = "0x186DE6100")]
		internal void FNLCPCJGIMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6450", Offset = "0x6DE4C50", VA = "0x186DE6450")]
		internal void NDFDODBJHHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE5EF0", Offset = "0x6DE46F0", VA = "0x186DE5EF0")]
		internal void AJDCLGGKLMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6300", Offset = "0x6DE4B00", VA = "0x186DE6300")]
		internal void IINMFLKPAMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6260", Offset = "0x6DE4A60", VA = "0x186DE6260")]
		internal void GLGHIEFBPPN(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OPJJONAEHFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DE68F0", Offset = "0x6DE50F0", VA = "0x186DE68F0", Slot = "35")]
	public override void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, AnchorParamsRestrictions DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DE6E10", Offset = "0x6DE5610", VA = "0x186DE6E10", Slot = "36")]
	public override void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, AnchorParamsRestrictions INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DE72B0", Offset = "0x6DE5AB0", VA = "0x186DE72B0")]
	public GKADMKIOEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x307E600", Offset = "0x307CE00", VA = "0x18307E600")]
	[CompilerGenerated]
	internal static void HNNNDJINGCD<T>(string FHDOKEGCLOA, T DBIIPNGMHFP, T DIOMHAIBFJM, OPJJONAEHFB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FAIJNCMDJDF : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void CKJNPLGGOJP(Utf8JsonReader EBAPCDIJGCL);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OCOIPDNCAOO
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
		public FAIJNCMDJDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CKJNPLGGOJP <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CKJNPLGGOJP <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CKJNPLGGOJP <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CKJNPLGGOJP <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CKJNPLGGOJP <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CKJNPLGGOJP <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CKJNPLGGOJP <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CKJNPLGGOJP <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CKJNPLGGOJP <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CKJNPLGGOJP <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CKJNPLGGOJP <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OCOIPDNCAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8AE0", Offset = "0x6DE72E0", VA = "0x186DE8AE0")]
		internal void MIGJHIFAEBE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DE88A0", Offset = "0x6DE70A0", VA = "0x186DE88A0")]
		internal void GEGMEBMCDFG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8950", Offset = "0x6DE7150", VA = "0x186DE8950")]
		internal void JGDBCDGIEBB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8B20", Offset = "0x6DE7320", VA = "0x186DE8B20")]
		internal void OECFBGMGDCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE87F0", Offset = "0x6DE6FF0", VA = "0x186DE87F0")]
		internal void FCABIFHBPDD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE72F0", Offset = "0x6DE5AF0", VA = "0x186DE72F0")]
		internal void JODHGGEDNJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8BD0", Offset = "0x6DE73D0", VA = "0x186DE8BD0")]
		internal void OEIJOJMAPDN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8590", Offset = "0x6DE6D90", VA = "0x186DE8590")]
		internal void BFIDFINEHBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8A00", Offset = "0x6DE7200", VA = "0x186DE8A00")]
		internal void LJOCPHNKCHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8A40", Offset = "0x6DE7240", VA = "0x186DE8A40")]
		internal void MAGGKDIOEEP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8670", Offset = "0x6DE6E70", VA = "0x186DE8670")]
		internal void EJLKBLOFLOM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GAPNCIOMALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GAPNCIOMALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DE65B0", Offset = "0x6DE4DB0", VA = "0x186DE65B0")]
		internal void OBFJHJAHEAL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4770", Offset = "0x6DE2F70", VA = "0x186DE4770", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5370", Offset = "0x6DE3B70", VA = "0x186DE5370", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, SerializedAvatarItemData INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4600", Offset = "0x6DE2E00", VA = "0x186DE4600")]
	private AdditionalOutfitTypeData CGNNDNNJINK(Utf8JsonReader GKMNBDEFGCI, OutfitType OCLAPBNMMGE, JsonSerializerOptions PJFCIKCGIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DE57A0", Offset = "0x6DE3FA0", VA = "0x186DE57A0")]
	public FAIJNCMDJDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DBHCONFJBCD : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3FD0", Offset = "0x6DE27D0", VA = "0x186DE3FD0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader GKMNBDEFGCI, Type DNGGJNIDMCF, JsonSerializerOptions PJFCIKCGIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4360", Offset = "0x6DE2B60", VA = "0x186DE4360", Slot = "28")]
	public override void Write(Utf8JsonWriter PAOHHJOJGFD, AvatarItemDownloadableConfig INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4490", Offset = "0x6DE2C90", VA = "0x186DE4490")]
	public DBHCONFJBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GDMNBAGNOBH : MEPDFMPCCKM<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE6650", Offset = "0x6DE4E50", VA = "0x186DE6650", Slot = "35")]
	public override void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, BeardData DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE67F0", Offset = "0x6DE4FF0", VA = "0x186DE67F0", Slot = "36")]
	public override void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, BeardData INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE68B0", Offset = "0x6DE50B0", VA = "0x186DE68B0")]
	public GDMNBAGNOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LBAOIAHHICH : FJOKGBGEHBE<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8400", Offset = "0x6DE6C00", VA = "0x186DE8400")]
	public LBAOIAHHICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LENOKAMNHAA : FJOKGBGEHBE<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8440", Offset = "0x6DE6C40", VA = "0x186DE8440")]
	public LENOKAMNHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DOGINHDFCPG : FJOKGBGEHBE<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DE45C0", Offset = "0x6DE2DC0", VA = "0x186DE45C0")]
	public DOGINHDFCPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ACJFAAMBKCO : NLJKHONKJHN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3160", Offset = "0x6DE1960", VA = "0x186DE3160")]
	public ACJFAAMBKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BPKEGACBLAC : MEPDFMPCCKM<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OFAEIFBNPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OFAEIFBNPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7540", Offset = "0x6DE5D40", VA = "0x186DE7540")]
		internal void GHJNKEEDGBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8C50", Offset = "0x6DE7450", VA = "0x186DE8C50")]
		internal void LCOLCDMLLCD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3D30", Offset = "0x6DE2530", VA = "0x186DE3D30", Slot = "35")]
	public override void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, AdditionalFeetData DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3EC0", Offset = "0x6DE26C0", VA = "0x186DE3EC0", Slot = "36")]
	public override void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, AdditionalFeetData INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3F90", Offset = "0x6DE2790", VA = "0x186DE3F90")]
	public BPKEGACBLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FFAHDJNCPGH : MEPDFMPCCKM<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GMACPOIANCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GMACPOIANCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7460", Offset = "0x6DE5C60", VA = "0x186DE7460")]
		internal void GHJNKEEDGBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7510", Offset = "0x6DE5D10", VA = "0x186DE7510")]
		internal void LCOLCDMLLCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE72F0", Offset = "0x6DE5AF0", VA = "0x186DE72F0")]
		internal void BBEIBLCNMAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7570", Offset = "0x6DE5D70", VA = "0x186DE7570")]
		internal void OOEEKIFOAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7320", Offset = "0x6DE5B20", VA = "0x186DE7320")]
		internal void DCJIADNMDBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DE73C0", Offset = "0x6DE5BC0", VA = "0x186DE73C0")]
		internal void FNLCPCJGIMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7540", Offset = "0x6DE5D40", VA = "0x186DE7540")]
		internal void NDFDODBJHHL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DE57E0", Offset = "0x6DE3FE0", VA = "0x186DE57E0", Slot = "35")]
	public override void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, HairData DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5BD0", Offset = "0x6DE43D0", VA = "0x186DE5BD0", Slot = "36")]
	public override void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, HairData INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5EB0", Offset = "0x6DE46B0", VA = "0x186DE5EB0")]
	public FFAHDJNCPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GPPNPMJNCNI : MEPDFMPCCKM<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class INMPNHMGPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public INMPNHMGPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DE81D0", Offset = "0x6DE69D0", VA = "0x186DE81D0")]
		internal void GHJNKEEDGBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8200", Offset = "0x6DE6A00", VA = "0x186DE8200")]
		internal void LCOLCDMLLCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7FD0", Offset = "0x6DE67D0", VA = "0x186DE7FD0")]
		internal void BBEIBLCNMAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8350", Offset = "0x6DE6B50", VA = "0x186DE8350")]
		internal void OOEEKIFOAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8080", Offset = "0x6DE6880", VA = "0x186DE8080")]
		internal void DCJIADNMDBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8130", Offset = "0x6DE6930", VA = "0x186DE8130")]
		internal void FNLCPCJGIMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE82B0", Offset = "0x6DE6AB0", VA = "0x186DE82B0")]
		internal void NDFDODBJHHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7F30", Offset = "0x6DE6730", VA = "0x186DE7F30")]
		internal void AJDCLGGKLMP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7610", Offset = "0x6DE5E10", VA = "0x186DE7610", Slot = "35")]
	public override void EOMLPMAHEIH(Utf8JsonReader GKMNBDEFGCI, JsonSerializerOptions PJFCIKCGIIA, string FHDOKEGCLOA, AdditionalHatData DEDDGCENOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7A70", Offset = "0x6DE6270", VA = "0x186DE7A70", Slot = "36")]
	public override void IJJMKJLJMHD(Utf8JsonWriter PAOHHJOJGFD, AdditionalHatData INDENPJBLHO, JsonSerializerOptions PJFCIKCGIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7DC0", Offset = "0x6DE65C0", VA = "0x186DE7DC0")]
	public GPPNPMJNCNI()
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
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8C38D0", Offset = "0x8C20D0", VA = "0x1808C38D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA028C0", Offset = "0xA010C0", VA = "0x180A028C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA02A10", Offset = "0xA01210", VA = "0x180A02A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA028D0", Offset = "0xA010D0", VA = "0x180A028D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB07790", Offset = "0xB05F90", VA = "0x180B07790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB07C10", Offset = "0xB06410", VA = "0x180B07C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x192C7B0", Offset = "0x192AFB0", VA = "0x18192C7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6DE9140", Offset = "0x6DE7940", VA = "0x186DE9140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x26B0890", Offset = "0x26AF090", VA = "0x1826B0890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x26B07B0", Offset = "0x26AEFB0", VA = "0x1826B07B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1F06EF0", Offset = "0x1F056F0", VA = "0x181F06EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1F06F00", Offset = "0x1F05700", VA = "0x181F06F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EAIGMANLNFK.LFNICJCICHD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x95B900", Offset = "0x95A100", VA = "0x18095B900")]
			[CompilerGenerated]
			get
			{
				return default(EAIGMANLNFK.LFNICJCICHD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA88430", Offset = "0xA86C30", VA = "0x180A88430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFC0", Offset = "0x8B97C0", VA = "0x1808BAFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8CB0", Offset = "0x6DE74B0", VA = "0x186DE8CB0", Slot = "0")]
		public override bool Equals(object LIHCAHPMPHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9120", Offset = "0x6DE7920", VA = "0x186DE9120")]
		public static bool PCBECHOJFKF(SerializedAvatarItemData CBNNCMPLCDK, SerializedAvatarItemData OKJLFDLNFEM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8C80", Offset = "0x6DE7480", VA = "0x186DE8C80")]
		public static bool DJBIFFEEEPL(SerializedAvatarItemData CBNNCMPLCDK, SerializedAvatarItemData OKJLFDLNFEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6DE8D30", Offset = "0x6DE7530", VA = "0x186DE8D30", Slot = "4")]
		public bool Equals(SerializedAvatarItemData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9050", Offset = "0x6DE7850", VA = "0x186DE9050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
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
