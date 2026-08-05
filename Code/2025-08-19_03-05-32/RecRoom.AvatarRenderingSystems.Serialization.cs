using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Avatars.Data.Shared;
using RecRoom.JsonSerialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83FD3E0", Offset = "0x83FC1E0", VA = "0x1883FD3E0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class QEXPPHBBSKC : HVWLPALAQCI<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83FEF40", Offset = "0x83FDD40", VA = "0x1883FEF40", Slot = "36")]
		protected override Vector3 XISYXUYXEZW(float[] a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83FEEC0", Offset = "0x83FDCC0", VA = "0x1883FEEC0", Slot = "37")]
		protected override float[] CGTPUCJMRRV(Vector3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83FEF90", Offset = "0x83FDD90", VA = "0x1883FEF90")]
		public QEXPPHBBSKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ULKIIPIIOUJ : HVWLPALAQCI<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83FFC70", Offset = "0x83FEA70", VA = "0x1883FFC70", Slot = "36")]
		protected override Vector2 XISYXUYXEZW(float[] a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83FFC00", Offset = "0x83FEA00", VA = "0x1883FFC00", Slot = "37")]
		protected override float[] CGTPUCJMRRV(Vector2 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83FFCB0", Offset = "0x83FEAB0", VA = "0x1883FFCB0")]
		public ULKIIPIIOUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RFAXWEVIYLC : HVWLPALAQCI<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBCD920", Offset = "0xBCC720", VA = "0x180BCD920", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83FF060", Offset = "0x83FDE60", VA = "0x1883FF060", Slot = "36")]
		protected override Quaternion XISYXUYXEZW(float[] a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83FEFD0", Offset = "0x83FDDD0", VA = "0x1883FEFD0", Slot = "37")]
		protected override float[] CGTPUCJMRRV(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83FF0C0", Offset = "0x83FDEC0", VA = "0x1883FF0C0")]
		public RFAXWEVIYLC()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum VersionCode
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
		public VersionCode Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(VersionCode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83FAC30", Offset = "0x83F9A30", VA = "0x1883FAC30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83FAE20", Offset = "0x83F9C20", VA = "0x1883FAE20")]
		public static bool GFBRUTYEXQF(AvatarItemDownloadableConfig a, AvatarItemDownloadableConfig b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83FAD70", Offset = "0x83F9B70", VA = "0x1883FAD70", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83FAF00", Offset = "0x83F9D00", VA = "0x1883FAF00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x10AA250", Offset = "0x10A9050", VA = "0x1810AA250")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, EIVNCZEQAWW, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83FFAB0", Offset = "0x83FE8B0", VA = "0x1883FFAB0")]
		private void SUALLWAFJHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83FF930", Offset = "0x83FE730", VA = "0x1883FF930", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83FF9B0", Offset = "0x83FE7B0", VA = "0x1883FF9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83FFAA0", Offset = "0x83FE8A0", VA = "0x1883FFAA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83FF910", Offset = "0x83FE710", VA = "0x1883FF910", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60", Slot = "6")]
		public Guid AHMIUJRQYWK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83FFAB0", Offset = "0x83FE8B0", VA = "0x1883FFAB0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83FFB20", Offset = "0x83FE920", VA = "0x1883FFB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HTTGFOEXCAA : SCBOBNLFTVM<AnchorParamsRestrictions>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AnchorParamsRestrictions TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JsonSerializerOptions SNLHOFQDXBV;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FF230", VA = "0x188400430")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8400740", Offset = "0x83FF540", VA = "0x188400740")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8400180", Offset = "0x83FEF80", VA = "0x188400180")]
			internal void DZKWOCWFFDW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84002D0", Offset = "0x83FF0D0", VA = "0x1884002D0")]
			internal void DZQDLJQCOPF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8400B30", Offset = "0x83FF930", VA = "0x188400B30")]
			internal void EAQLXRLPJTY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8400D30", Offset = "0x83FFB30", VA = "0x188400D30")]
			internal void EAVSUYFMTFH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84007F0", Offset = "0x83FF5F0", VA = "0x1884007F0")]
			internal void EAFYDDXUQXG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8400940", Offset = "0x83FF740", VA = "0x188400940")]
			internal void EALFAKRSAIP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8400E80", Offset = "0x83FFC80", VA = "0x188400E80")]
			internal void EBLNMSNEVNI(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8400F20", Offset = "0x83FFD20", VA = "0x188400F20")]
			internal void EBQUJZHCEYR(Utf8JsonReader a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <>c__DisplayClass1_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Utf8JsonWriter writer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public JsonSerializerOptions options;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83FC4B0", Offset = "0x83FB2B0", VA = "0x1883FC4B0", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, AnchorParamsRestrictions d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83FC020", Offset = "0x83FAE20", VA = "0x1883FC020", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, AnchorParamsRestrictions b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83FC960", Offset = "0x83FB760", VA = "0x1883FC960")]
		public HTTGFOEXCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3933860", Offset = "0x3932660", VA = "0x183933860")]
		[CompilerGenerated]
		internal static void BJXLXHRIHQW<a>(string a, a b, a c, <>c__DisplayClass1_0 d) where a : IEquatable<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PTBXWTGZRKI : JsonConverter<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public SerializedAvatarItemData TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public JsonSerializerOptions SNLHOFQDXBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public bool RZLPEXEZWVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PTBXWTGZRKI WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public ReaderAction CBANWYGKPPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ReaderAction CAQACKSPWSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ReaderAction CAVGZRMNGDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ReaderAction CBVPLZIABIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ReaderAction CCAWJGBXKTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public ReaderAction CBLBRLUFILW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ReaderAction CCVXYHDMWNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public ReaderAction AUYACGJUQSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ReaderAction AUSTEZPXHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ReaderAction AVINWTXPJPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ReaderAction AVDGZNDSAEG;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83FBD70", Offset = "0x83FAB70", VA = "0x1883FBD70")]
			internal void KVRILDZRJBL(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83FBCC0", Offset = "0x83FAAC0", VA = "0x1883FBCC0")]
			internal void KVGUQQLWQET(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83FBC10", Offset = "0x83FAA10", VA = "0x1883FBC10")]
			internal void KVBNTJRZGTK(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83FBE90", Offset = "0x83FAC90", VA = "0x1883FBE90")]
			internal void KWMKAFBGUUV(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x83FBDE0", Offset = "0x83FABE0", VA = "0x1883FBDE0")]
			internal void KWHDCYHJLJM(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83FBDB0", Offset = "0x83FABB0", VA = "0x1883FBDB0")]
			internal void KWBWFRNMBYD(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83FBB90", Offset = "0x83FA990", VA = "0x1883FBB90")]
			internal void KTVYJVCPCDI(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x83FBA70", Offset = "0x83FA870", VA = "0x1883FBA70")]
			internal void HVXGDLBHNWC(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83FBB50", Offset = "0x83FA950", VA = "0x1883FBB50")]
			internal void HWCNARVEXHL(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83FB980", Offset = "0x83FA780", VA = "0x1883FB980")]
			internal void HVMSIXNMUZK(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83FBA20", Offset = "0x83FA820", VA = "0x1883FBA20")]
			internal void HVRZGEHKEKT(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CFCMCYVGPQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string TLUGXCCMEVT;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CFCMCYVGPQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83FBF40", Offset = "0x83FAD40", VA = "0x1883FBF40")]
			internal void HVCEOJZSCCS(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83FDEF0", Offset = "0x83FCCF0", VA = "0x1883FDEF0", Slot = "27")]
		public override SerializedAvatarItemData Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83FEA40", Offset = "0x83FD840", VA = "0x1883FEA40", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, SerializedAvatarItemData value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83FDC10", Offset = "0x83FCA10", VA = "0x1883FDC10")]
		private AdditionalOutfitTypeData RLKAUMNHXPD(Utf8JsonReader a, OutfitType b, JsonSerializerOptions c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83FEE80", Offset = "0x83FDC80", VA = "0x1883FEE80")]
		public PTBXWTGZRKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class IIXKKVANQRX : JsonConverter<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83FC9A0", Offset = "0x83FB7A0", VA = "0x1883FC9A0", Slot = "27")]
		public override AvatarItemDownloadableConfig Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83FCD00", Offset = "0x83FBB00", VA = "0x1883FCD00", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, AvatarItemDownloadableConfig value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83FCEC0", Offset = "0x83FBCC0", VA = "0x1883FCEC0")]
		public IIXKKVANQRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class NMELBGWCGAR : SCBOBNLFTVM<BeardData>
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83FD520", Offset = "0x83FC320", VA = "0x1883FD520", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, BeardData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83FD460", Offset = "0x83FC260", VA = "0x1883FD460", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, BeardData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83FD6B0", Offset = "0x83FC4B0", VA = "0x1883FD6B0")]
		public NMELBGWCGAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BQDRAMFDBKD : XNVTDDIPLGI<HelmetHairMode>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83FB940", Offset = "0x83FA740", VA = "0x1883FB940")]
		public BQDRAMFDBKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DTDMORXXAYV : XNVTDDIPLGI<HelmetHairStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83FBFE0", Offset = "0x83FADE0", VA = "0x1883FBFE0")]
		public DTDMORXXAYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PPACYFDJNEQ : XNVTDDIPLGI<HairPatternStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83FDBD0", Offset = "0x83FC9D0", VA = "0x1883FDBD0")]
		public PPACYFDJNEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OASRRUUYYWL : LPQIFATGDMX<OutfitType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83FD940", Offset = "0x83FC740", VA = "0x1883FD940")]
		public OASRRUUYYWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class JODDZHPOEIR : SCBOBNLFTVM<AdditionalFeetData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AdditionalFeetData TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84005C0", Offset = "0x83FF3C0", VA = "0x1884005C0")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8400660", Offset = "0x83FF460", VA = "0x188400660")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83FD220", Offset = "0x83FC020", VA = "0x1883FD220", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalFeetData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83FD150", Offset = "0x83FBF50", VA = "0x1883FD150", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, AdditionalFeetData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83FD3A0", Offset = "0x83FC1A0", VA = "0x1883FD3A0")]
		public JODDZHPOEIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class XNSZVOOAFWV : SCBOBNLFTVM<HairData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HairData TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public JsonSerializerOptions SNLHOFQDXBV;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x84004E0", Offset = "0x83FF2E0", VA = "0x1884004E0")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84005F0", Offset = "0x83FF3F0", VA = "0x1884005F0")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8400150", Offset = "0x83FEF50", VA = "0x188400150")]
			internal void DZKWOCWFFDW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8400230", Offset = "0x83FF030", VA = "0x188400230")]
			internal void DZQDLJQCOPF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8400A90", Offset = "0x83FF890", VA = "0x188400A90")]
			internal void EAQLXRLPJTY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8400C90", Offset = "0x83FFA90", VA = "0x188400C90")]
			internal void EAVSUYFMTFH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x84005C0", Offset = "0x83FF3C0", VA = "0x1884005C0")]
			internal void EAFYDDXUQXG(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8401A10", Offset = "0x8400810", VA = "0x188401A10", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, HairData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8401740", Offset = "0x8400540", VA = "0x188401740", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, HairData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8401DB0", Offset = "0x8400BB0", VA = "0x188401DB0")]
		public XNSZVOOAFWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WVCONQIOQYM : SCBOBNLFTVM<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AdditionalHatData TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public JsonSerializerOptions SNLHOFQDXBV;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8400590", Offset = "0x83FF390", VA = "0x188400590")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8400690", Offset = "0x83FF490", VA = "0x188400690")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8400000", Offset = "0x83FEE00", VA = "0x188400000")]
			internal void DZKWOCWFFDW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8400380", Offset = "0x83FF180", VA = "0x188400380")]
			internal void DZQDLJQCOPF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8400BE0", Offset = "0x83FF9E0", VA = "0x188400BE0")]
			internal void EAQLXRLPJTY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8400DE0", Offset = "0x83FFBE0", VA = "0x188400DE0")]
			internal void EAVSUYFMTFH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84008A0", Offset = "0x83FF6A0", VA = "0x1884008A0")]
			internal void EAFYDDXUQXG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84009F0", Offset = "0x83FF7F0", VA = "0x1884009F0")]
			internal void EALFAKRSAIP(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8401300", Offset = "0x8400100", VA = "0x188401300", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8400FC0", Offset = "0x83FFDC0", VA = "0x188400FC0", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, AdditionalHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8401700", Offset = "0x8400500", VA = "0x188401700")]
		public WVCONQIOQYM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RoomieEquipmentDataConverter : SCBOBNLFTVM<RoomieEquipmentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public RoomieEquipmentData TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8400590", Offset = "0x83FF390", VA = "0x188400590")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83FF100", Offset = "0x83FDF00", VA = "0x1883FF100", Slot = "35")]
		protected override void JMWWDFIBQFZ(RoomieEquipmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83FF240", Offset = "0x83FE040", VA = "0x1883FF240", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieEquipmentData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83FF1B0", Offset = "0x83FDFB0", VA = "0x1883FF1B0", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, RoomieEquipmentData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83FF400", Offset = "0x83FE200", VA = "0x1883FF400")]
		public RoomieEquipmentDataConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class NPFGMCAXUMZ : SCBOBNLFTVM<RoomieEyeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public RoomieEyeData TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FF230", VA = "0x188400430")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8400620", Offset = "0x83FF420", VA = "0x188400620")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83FD780", Offset = "0x83FC580", VA = "0x1883FD780", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieEyeData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83FD6F0", Offset = "0x83FC4F0", VA = "0x1883FD6F0", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, RoomieEyeData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83FD900", Offset = "0x83FC700", VA = "0x1883FD900")]
		public NPFGMCAXUMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class VUMEZTSOVIN : SCBOBNLFTVM<RoomieHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RoomieHatData TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public JsonSerializerOptions SNLHOFQDXBV;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FF230", VA = "0x188400430")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8400620", Offset = "0x83FF420", VA = "0x188400620")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x84000B0", Offset = "0x83FEEB0", VA = "0x1884000B0")]
			internal void DZKWOCWFFDW(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83FFDF0", Offset = "0x83FEBF0", VA = "0x1883FFDF0", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83FFCF0", Offset = "0x83FEAF0", VA = "0x1883FFCF0", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, RoomieHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83FFFC0", Offset = "0x83FEDC0", VA = "0x1883FFFC0")]
		public VUMEZTSOVIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class OBKYRGOGJLN : SCBOBNLFTVM<RoomieMouthData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RoomieMouthData TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FF230", VA = "0x188400430")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8400620", Offset = "0x83FF420", VA = "0x188400620")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83FDA10", Offset = "0x83FC810", VA = "0x1883FDA10", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieMouthData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83FD980", Offset = "0x83FC780", VA = "0x1883FD980", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, RoomieMouthData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83FDB90", Offset = "0x83FC990", VA = "0x1883FDB90")]
		public OBKYRGOGJLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class IPBGTJVSHUS : SCBOBNLFTVM<RoomieWaistData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public RoomieWaistData TRCZVHNQMBW;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FF230", VA = "0x188400430")]
			internal void DZVKIQJZYAO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8400620", Offset = "0x83FF420", VA = "0x188400620")]
			internal void EAARFXDXHLX(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83FCF90", Offset = "0x83FBD90", VA = "0x1883FCF90", Slot = "37")]
		public override void WVFTTEPLKVQ(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieWaistData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83FCF00", Offset = "0x83FBD00", VA = "0x1883FCF00", Slot = "38")]
		public override void MGXNAOFOOGT(Utf8JsonWriter a, RoomieWaistData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83FD110", Offset = "0x83FBF10", VA = "0x1883FD110")]
		public IPBGTJVSHUS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xC330C0", Offset = "0xC31EC0", VA = "0x180C330C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xF6D410", Offset = "0xF6C210", VA = "0x180F6D410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF6D400", Offset = "0xF6C200", VA = "0x180F6D400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x10C8CA0", Offset = "0x10C7AA0", VA = "0x1810C8CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x10C8CB0", Offset = "0x10C7AB0", VA = "0x1810C8CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x83FF8F0", Offset = "0x83FE6F0", VA = "0x1883FF8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x83FF900", Offset = "0x83FE700", VA = "0x1883FF900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2A12FE0", Offset = "0x2A11DE0", VA = "0x182A12FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2A13000", Offset = "0x2A11E00", VA = "0x182A13000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB0B530", Offset = "0xB0A330", VA = "0x180B0B530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB0B540", Offset = "0xB0A340", VA = "0x180B0B540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FUNEGHNETHP.SkinCullingMask ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return default(FUNEGHNETHP.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x13EE3C0", Offset = "0x13ED1C0", VA = "0x1813EE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83FF470", Offset = "0x83FE270", VA = "0x1883FF470", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83FF800", Offset = "0x83FE600", VA = "0x1883FF800")]
		public static bool GFBRUTYEXQF(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83FF440", Offset = "0x83FE240", VA = "0x1883FF440")]
		public static bool CQBJVGKOTGK(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83FF4F0", Offset = "0x83FE2F0", VA = "0x1883FF4F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83FF820", Offset = "0x83FE620", VA = "0x1883FF820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
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
