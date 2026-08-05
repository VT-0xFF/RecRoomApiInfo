using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetIds;
using RecRoom.Avatars.Data.Shared;
using RecRoom.JsonSerialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x969F670", Offset = "0x969E470", VA = "0x18969F670")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x969F240", Offset = "0x969E040", VA = "0x18969F240", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LVNAJKGHGQI : CHWTIPZIMBA<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "41")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x969F1B0", Offset = "0x969DFB0", VA = "0x18969F1B0", Slot = "42")]
		protected override Vector3 IDLWEJSYWKO(float[] a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x969F130", Offset = "0x969DF30", VA = "0x18969F130", Slot = "43")]
		protected override float[] GVVLPKOYPSV(Vector3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x969F200", Offset = "0x969E000", VA = "0x18969F200")]
		public LVNAJKGHGQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HOSHAMVOSSX : CHWTIPZIMBA<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "41")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x969D260", Offset = "0x969C060", VA = "0x18969D260", Slot = "42")]
		protected override Vector2 IDLWEJSYWKO(float[] a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x969D1F0", Offset = "0x969BFF0", VA = "0x18969D1F0", Slot = "43")]
		protected override float[] GVVLPKOYPSV(Vector2 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x969D2A0", Offset = "0x969C0A0", VA = "0x18969D2A0")]
		public HOSHAMVOSSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CVPUHGJHAKW : CHWTIPZIMBA<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "41")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x969BF00", Offset = "0x969AD00", VA = "0x18969BF00", Slot = "42")]
		protected override Quaternion IDLWEJSYWKO(float[] a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x969BE70", Offset = "0x969AC70", VA = "0x18969BE70", Slot = "43")]
		protected override float[] GVVLPKOYPSV(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x969BF60", Offset = "0x969AD60", VA = "0x18969BF60")]
		public CVPUHGJHAKW()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum VersionCode
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Prerelease = 0,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			InitialRelease = 1,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			CurrentPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Current = 1
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Log Log;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static JsonSerializerOptions Options;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public VersionCode Version
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			[CompilerGenerated]
			get
			{
				return default(VersionCode);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7D30", VA = "0x180CE8F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9699CB0", Offset = "0x9698AB0", VA = "0x189699CB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9699DF0", Offset = "0x9698BF0", VA = "0x189699DF0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9699EA0", Offset = "0x9698CA0", VA = "0x189699EA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9699F10", Offset = "0x9698D10", VA = "0x189699F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x108B850", Offset = "0x108A650", VA = "0x18108B850")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, KDOUHRCNUXS, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SerializedAvatarItemId AvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SerializedCombinationId CombinationId;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96A0540", Offset = "0x969F340", VA = "0x1896A0540")]
		private void OXDORKMPOBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96A03C0", Offset = "0x969F1C0", VA = "0x1896A03C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x96A0440", Offset = "0x969F240", VA = "0x1896A0440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96A0530", Offset = "0x969F330", VA = "0x1896A0530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x96A03A0", Offset = "0x969F1A0", VA = "0x1896A03A0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420", Slot = "6")]
		public Guid HBGHJTZTMKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96A0540", Offset = "0x969F340", VA = "0x1896A0540", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96A05B0", Offset = "0x969F3B0", VA = "0x1896A05B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BSJUDEBJOSW : YABFQORLQDO<AnchorParamsRestrictions>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AnchorParamsRestrictions JVFFLBVCSQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public JsonSerializerOptions ZIGMYXOYFWR;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x969C260", Offset = "0x969B060", VA = "0x18969C260")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x969C510", Offset = "0x969B310", VA = "0x18969C510")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x969C5F0", Offset = "0x969B3F0", VA = "0x18969C5F0")]
			internal void JMGRAYAAFCO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x969C8C0", Offset = "0x969B6C0", VA = "0x18969C8C0")]
			internal void JMLXYETXONX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x969CAD0", Offset = "0x969B8D0", VA = "0x18969CAD0")]
			internal void JMREVLNUXZG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x969CD60", Offset = "0x969BB60", VA = "0x18969CD60")]
			internal void JMWLSSHSHKP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x969CEB0", Offset = "0x969BCB0", VA = "0x18969CEB0")]
			internal void JNBSPZBPQVY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x969D000", Offset = "0x969BE00", VA = "0x18969D000")]
			internal void JNGZNFVNAHH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x969D0B0", Offset = "0x969BEB0", VA = "0x18969D0B0")]
			internal void JNMGKMPKJSQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x969D150", Offset = "0x969BF50", VA = "0x18969D150")]
			internal void JNRNHTJHTDZ(Utf8JsonReader a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <>c__DisplayClass1_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Utf8JsonWriter writer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JsonSerializerOptions options;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x969B2B0", Offset = "0x969A0B0", VA = "0x18969B2B0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, AnchorParamsRestrictions d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x969B760", Offset = "0x969A560", VA = "0x18969B760", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, AnchorParamsRestrictions b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x969BC00", Offset = "0x969AA00", VA = "0x18969BC00")]
		public BSJUDEBJOSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3719C40", Offset = "0x3718A40", VA = "0x183719C40")]
		[CompilerGenerated]
		internal static void JUIMJLZPIPO<a>(string a, a b, a c, <>c__DisplayClass1_0 d) where a : IEquatable<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class INFWIMTVDZQ : JsonConverter<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializedAvatarItemData JVFFLBVCSQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public JsonSerializerOptions ZIGMYXOYFWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public bool SSIVFGALAKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public INFWIMTVDZQ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ReaderAction EQAHRUTEVEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ReaderAction EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ReaderAction EQQCJPAWXMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ReaderAction EPFGCTRPJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ReaderAction EPKNAALMSWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public ReaderAction EPPTXHFKCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ReaderAction ERVRTDQHCCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public ReaderAction FQNLYFEHVMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ReaderAction FQIFAYKKMBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public ReaderAction FQCYDRQNCPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public ReaderAction FPXRGKWPTEI;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x969AFA0", Offset = "0x9699DA0", VA = "0x18969AFA0")]
			internal void WPPWNKGTLSP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x969B090", Offset = "0x9699E90", VA = "0x18969B090")]
			internal void WQAKHXUOEPH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x969AFE0", Offset = "0x9699DE0", VA = "0x18969AFE0")]
			internal void WPVDKRAQVDY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x969AEC0", Offset = "0x9699CC0", VA = "0x18969AEC0")]
			internal void WOUUYJFDZZF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x969AE10", Offset = "0x9699C10", VA = "0x18969AE10")]
			internal void WOPOBCLGQNW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x969AF70", Offset = "0x9699D70", VA = "0x18969AF70")]
			internal void WPFISWSYSVX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x969AD90", Offset = "0x9699B90", VA = "0x18969AD90")]
			internal void WNUMMBJREUM(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x969AB80", Offset = "0x9699980", VA = "0x18969AB80")]
			internal void FAWYONJYSCA(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x969AC60", Offset = "0x9699A60", VA = "0x18969AC60")]
			internal void FBCFLUDWBNJ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x969ACA0", Offset = "0x9699AA0", VA = "0x18969ACA0")]
			internal void FBHMJAXTKYS(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x969AD40", Offset = "0x9699B40", VA = "0x18969AD40")]
			internal void FBMTGHRQUKB(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BBBPZVCGPLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public string KFNSLTRAGFF;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BBBPZVCGPLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x969B140", Offset = "0x9699F40", VA = "0x18969B140")]
			internal void FABWZMIJGIQ(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x969D830", Offset = "0x969C630", VA = "0x18969D830", Slot = "33")]
		public override SerializedAvatarItemData Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x969E3A0", Offset = "0x969D1A0", VA = "0x18969E3A0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, SerializedAvatarItemData value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x969D420", Offset = "0x969C220", VA = "0x18969D420")]
		private AdditionalOutfitTypeData GJBGVQEWEKD(Utf8JsonReader a, OutfitType b, JsonSerializerOptions c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x969E7E0", Offset = "0x969D5E0", VA = "0x18969E7E0")]
		public INFWIMTVDZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class JBYEZVLJAFN : JsonConverter<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x969E820", Offset = "0x969D620", VA = "0x18969E820", Slot = "33")]
		public override AvatarItemDownloadableConfig Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x969ECA0", Offset = "0x969DAA0", VA = "0x18969ECA0", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, AvatarItemDownloadableConfig value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x969EE60", Offset = "0x969DC60", VA = "0x18969EE60")]
		public JBYEZVLJAFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LGVQYLDGFJV : YABFQORLQDO<BeardData>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x969EEA0", Offset = "0x969DCA0", VA = "0x18969EEA0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, BeardData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x969F030", Offset = "0x969DE30", VA = "0x18969F030", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, BeardData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x969F0F0", Offset = "0x969DEF0", VA = "0x18969F0F0")]
		public LGVQYLDGFJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class NFUJTVXTCYI : JsonConverter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x969F550", Offset = "0x969E350", VA = "0x18969F550", Slot = "33")]
		public override Color Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x969F590", Offset = "0x969E390", VA = "0x18969F590", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x969F630", Offset = "0x969E430", VA = "0x18969F630")]
		public NFUJTVXTCYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class HVVSWHEPQBF : JsonConverter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x969D2E0", Offset = "0x969C0E0", VA = "0x18969D2E0", Slot = "33")]
		public override Color32 Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x969D310", Offset = "0x969C110", VA = "0x18969D310", Slot = "34")]
		public override void Write(Utf8JsonWriter writer, Color32 value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x969D3E0", Offset = "0x969C1E0", VA = "0x18969D3E0")]
		public HVVSWHEPQBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class BZYRANSZDCQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x969BCB0", Offset = "0x969AAB0", VA = "0x18969BCB0")]
		public static Color YHIVLMQLZBD(Utf8JsonReader a, Type b, JsonSerializerOptions c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x969BC40", Offset = "0x969AA40", VA = "0x18969BC40")]
		public static void JMVJVIOJCPK(Utf8JsonWriter a, Color b, JsonSerializerOptions c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRSKKXFMOON : ULNWSTFFBLY<HelmetHairMode>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x969F9C0", Offset = "0x969E7C0", VA = "0x18969F9C0")]
		public RRSKKXFMOON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AJQBPUYHQGT : ULNWSTFFBLY<HelmetHairStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9699960", Offset = "0x9698760", VA = "0x189699960")]
		public AJQBPUYHQGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class QKXPXKQRDQW : ULNWSTFFBLY<HairPatternStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x969F980", Offset = "0x969E780", VA = "0x18969F980")]
		public QKXPXKQRDQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class EOZVFMTURJL : QMJHWTGQSEB<OutfitType>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x969BFA0", Offset = "0x969ADA0", VA = "0x18969BFA0")]
		public EOZVFMTURJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PKQWAICYPRV : YABFQORLQDO<AdditionalFeetData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AdditionalFeetData JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x969C230", Offset = "0x969B030", VA = "0x18969C230")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x969C5C0", Offset = "0x969B3C0", VA = "0x18969C5C0")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x969F6F0", Offset = "0x969E4F0", VA = "0x18969F6F0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalFeetData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x969F870", Offset = "0x969E670", VA = "0x18969F870", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, AdditionalFeetData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x969F940", Offset = "0x969E740", VA = "0x18969F940")]
		public PKQWAICYPRV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class VTTYRPAQADJ : YABFQORLQDO<HairData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public HairData JVFFLBVCSQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public JsonSerializerOptions ZIGMYXOYFWR;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x969C340", Offset = "0x969B140", VA = "0x18969C340")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x969C430", Offset = "0x969B230", VA = "0x18969C430")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x969C6A0", Offset = "0x969B4A0", VA = "0x18969C6A0")]
			internal void JMGRAYAAFCO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x969C820", Offset = "0x969B620", VA = "0x18969C820")]
			internal void JMLXYETXONX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x969CB80", Offset = "0x969B980", VA = "0x18969CB80")]
			internal void JMREVLNUXZG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x969CCC0", Offset = "0x969BAC0", VA = "0x18969CCC0")]
			internal void JMWLSSHSHKP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x969C230", Offset = "0x969B030", VA = "0x18969C230")]
			internal void JNBSPZBPQVY(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x96A0F70", Offset = "0x969FD70", VA = "0x1896A0F70", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, HairData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x96A1310", Offset = "0x96A0110", VA = "0x1896A1310", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, HairData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x96A15F0", Offset = "0x96A03F0", VA = "0x1896A15F0")]
		public VTTYRPAQADJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class UYSLFKDRFYK : YABFQORLQDO<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AdditionalHatData JVFFLBVCSQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public JsonSerializerOptions ZIGMYXOYFWR;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x969C310", Offset = "0x969B110", VA = "0x18969C310")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x969C460", Offset = "0x969B260", VA = "0x18969C460")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x969C770", Offset = "0x969B570", VA = "0x18969C770")]
			internal void JMGRAYAAFCO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x969C970", Offset = "0x969B770", VA = "0x18969C970")]
			internal void JMLXYETXONX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x969CA20", Offset = "0x969B820", VA = "0x18969CA20")]
			internal void JMREVLNUXZG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x969CC20", Offset = "0x969BA20", VA = "0x18969CC20")]
			internal void JMWLSSHSHKP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x969CE10", Offset = "0x969BC10", VA = "0x18969CE10")]
			internal void JNBSPZBPQVY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x969CF60", Offset = "0x969BD60", VA = "0x18969CF60")]
			internal void JNGZNFVNAHH(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x96A07E0", Offset = "0x969F5E0", VA = "0x1896A07E0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x96A0BE0", Offset = "0x969F9E0", VA = "0x1896A0BE0", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, AdditionalHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x96A0F30", Offset = "0x969FD30", VA = "0x1896A0F30")]
		public UYSLFKDRFYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RoomieEquipmentDataConverter : YABFQORLQDO<RoomieEquipmentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public RoomieEquipmentData JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x969C310", Offset = "0x969B110", VA = "0x18969C310")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x969FB40", Offset = "0x969E940", VA = "0x18969FB40", Slot = "41")]
		protected override void LBPEWCRHPMJ(RoomieEquipmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x969FA00", Offset = "0x969E800", VA = "0x18969FA00", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieEquipmentData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x969FBF0", Offset = "0x969E9F0", VA = "0x18969FBF0", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, RoomieEquipmentData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x969FD10", Offset = "0x969EB10", VA = "0x18969FD10")]
		public RoomieEquipmentDataConverter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MMYDZGIGPGP : YABFQORLQDO<RoomieEyeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RoomieEyeData JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x969C260", Offset = "0x969B060", VA = "0x18969C260")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x969C3F0", Offset = "0x969B1F0", VA = "0x18969C3F0")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x969F300", Offset = "0x969E100", VA = "0x18969F300", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieEyeData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x969F480", Offset = "0x969E280", VA = "0x18969F480", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, RoomieEyeData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x969F510", Offset = "0x969E310", VA = "0x18969F510")]
		public MMYDZGIGPGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AVBBSPTEVFJ : YABFQORLQDO<RoomieHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public RoomieHatData JVFFLBVCSQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public JsonSerializerOptions ZIGMYXOYFWR;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x969C260", Offset = "0x969B060", VA = "0x18969C260")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x969C3F0", Offset = "0x969B1F0", VA = "0x18969C3F0")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x969C6D0", Offset = "0x969B4D0", VA = "0x18969C6D0")]
			internal void JMGRAYAAFCO(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x96999A0", Offset = "0x96987A0", VA = "0x1896999A0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9699B70", Offset = "0x9698970", VA = "0x189699B70", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, RoomieHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9699C70", Offset = "0x9698A70", VA = "0x189699C70")]
		public AVBBSPTEVFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class XOMSDOEGCDD : YABFQORLQDO<RoomieMouthData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public RoomieMouthData JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x969C260", Offset = "0x969B060", VA = "0x18969C260")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x969C3F0", Offset = "0x969B1F0", VA = "0x18969C3F0")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x96A1630", Offset = "0x96A0430", VA = "0x1896A1630", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieMouthData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x96A17B0", Offset = "0x96A05B0", VA = "0x1896A17B0", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, RoomieMouthData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x96A1840", Offset = "0x96A0640", VA = "0x1896A1840")]
		public XOMSDOEGCDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class FBKNNICCAYU : YABFQORLQDO<RoomieWaistData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public RoomieWaistData JVFFLBVCSQK;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x969C260", Offset = "0x969B060", VA = "0x18969C260")]
			internal void JLWDGKMFMFW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x969C3F0", Offset = "0x969B1F0", VA = "0x18969C3F0")]
			internal void JMBKDRGCVRF(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x969BFE0", Offset = "0x969ADE0", VA = "0x18969BFE0", Slot = "43")]
		public override void IJODZAALFUA(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieWaistData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x969C160", Offset = "0x969AF60", VA = "0x18969C160", Slot = "44")]
		public override void MGEPNQZARQR(Utf8JsonWriter a, RoomieWaistData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x969C1F0", Offset = "0x969AFF0", VA = "0x18969C1F0")]
		public FBKNNICCAYU()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string DEPRECATED_Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCED350", Offset = "0xCEC150", VA = "0x180CED350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD793B0", Offset = "0xD781B0", VA = "0x180D793B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD793C0", Offset = "0xD781C0", VA = "0x180D793C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xF3B8D0", Offset = "0xF3A6D0", VA = "0x180F3B8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xF3B8E0", Offset = "0xF3A6E0", VA = "0x180F3B8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x10B5380", Offset = "0x10B4180", VA = "0x1810B5380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x10B5390", Offset = "0x10B4190", VA = "0x1810B5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x96A0380", Offset = "0x969F180", VA = "0x1896A0380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x96A0390", Offset = "0x969F190", VA = "0x1896A0390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FD70", Offset = "0x2A9EB70", VA = "0x182A9FD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FD90", Offset = "0x2A9EB90", VA = "0x182A9FD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD34990", Offset = "0xD33790", VA = "0x180D34990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD349A0", Offset = "0xD337A0", VA = "0x180D349A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OZJLBZNDMGD.SkinCullingMask ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return default(OZJLBZNDMGD.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x13F50C0", Offset = "0x13F3EC0", VA = "0x1813F50C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x969FD80", Offset = "0x969EB80", VA = "0x18969FD80", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x96A01E0", Offset = "0x969EFE0", VA = "0x1896A01E0")]
		public static bool ITVTPRNZGNV(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x969FD50", Offset = "0x969EB50", VA = "0x18969FD50")]
		public static bool CYAUITUETAA(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x969FE00", Offset = "0x969EC00", VA = "0x18969FE00", Slot = "4")]
		public bool Equals(SerializedAvatarItemData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x96A0110", Offset = "0x969EF10", VA = "0x1896A0110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x96A0200", Offset = "0x969F000", VA = "0x1896A0200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
