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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class GXTAVKEXMIE : NSFJNIFNXZI<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8858CB0", Offset = "0x88578B0", VA = "0x188858CB0", Slot = "36")]
		protected override Vector3 IPHBPOWSIJE(float[] a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8858C30", Offset = "0x8857830", VA = "0x188858C30", Slot = "37")]
		protected override float[] GNBJCPWCELL(Vector3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8858D00", Offset = "0x8857900", VA = "0x188858D00")]
		public GXTAVKEXMIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class VVTVVZAZEEX : NSFJNIFNXZI<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x885DC30", Offset = "0x885C830", VA = "0x18885DC30", Slot = "36")]
		protected override Vector2 IPHBPOWSIJE(float[] a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x885DBC0", Offset = "0x885C7C0", VA = "0x18885DBC0", Slot = "37")]
		protected override float[] GNBJCPWCELL(Vector2 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x885DC70", Offset = "0x885C870", VA = "0x18885DC70")]
		public VVTVVZAZEEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class KTRFQWZIOCC : NSFJNIFNXZI<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC21E00", Offset = "0xC20A00", VA = "0x180C21E00", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8858DD0", Offset = "0x88579D0", VA = "0x188858DD0", Slot = "36")]
		protected override Quaternion IPHBPOWSIJE(float[] a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8858D40", Offset = "0x8857940", VA = "0x188858D40", Slot = "37")]
		protected override float[] GNBJCPWCELL(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8858E30", Offset = "0x8857A30", VA = "0x188858E30")]
		public KTRFQWZIOCC()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
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
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(VersionCode);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88572E0", Offset = "0x8855EE0", VA = "0x1888572E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8857200", Offset = "0x8855E00", VA = "0x188857200")]
		public static bool EOXNKNKFOQL(AvatarItemDownloadableConfig a, AvatarItemDownloadableConfig b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8857420", Offset = "0x8856020", VA = "0x188857420", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88574D0", Offset = "0x88560D0", VA = "0x1888574D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x117BC30", Offset = "0x117A830", VA = "0x18117BC30")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, YGKPYJREKUM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x885B270", Offset = "0x8859E70", VA = "0x18885B270")]
		private void YLRMZEKNQXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x885B0F0", Offset = "0x8859CF0", VA = "0x18885B0F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x885B170", Offset = "0x8859D70", VA = "0x18885B170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x885B270", Offset = "0x8859E70", VA = "0x18885B270", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x885B2E0", Offset = "0x8859EE0", VA = "0x18885B2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class VAAZMOJPYUG : WBFWXZCFLAE<AnchorParamsRestrictions>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AnchorParamsRestrictions FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JsonSerializerOptions ZDFBEGIBXWV;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x885CA70", Offset = "0x885B670", VA = "0x18885CA70")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x885CD20", Offset = "0x885B920", VA = "0x18885CD20")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x885CE30", Offset = "0x885BA30", VA = "0x18885CE30")]
			internal void ZWKJPMPQEFI(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x885D180", Offset = "0x885BD80", VA = "0x18885D180")]
			internal void ZWPQMTJNNQR(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x885C3B0", Offset = "0x885AFB0", VA = "0x18885C3B0")]
			internal void ZVEUFYAFZPG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x885C5B0", Offset = "0x885B1B0", VA = "0x18885C5B0")]
			internal void ZVKBDEUDJAP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x885C7D0", Offset = "0x885B3D0", VA = "0x18885C7D0")]
			internal void ZVPIALOASLY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x885C9C0", Offset = "0x885B5C0", VA = "0x18885C9C0")]
			internal void ZVUOXSHYBXH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x885C270", Offset = "0x885AE70", VA = "0x18885C270")]
			internal void ZUJSQWYQNVW(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x885C310", Offset = "0x885AF10", VA = "0x18885C310")]
			internal void ZUOZODSNXHF(Utf8JsonReader a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
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

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x885D230", Offset = "0x885BE30", VA = "0x18885D230", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, AnchorParamsRestrictions d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x885D6E0", Offset = "0x885C2E0", VA = "0x18885D6E0", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, AnchorParamsRestrictions b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x885DB80", Offset = "0x885C780", VA = "0x18885DB80")]
		public VAAZMOJPYUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4192910", Offset = "0x4191510", VA = "0x184192910")]
		[CompilerGenerated]
		internal static void SKMOJQKKHSI<a>(string a, a b, a c, <>c__DisplayClass1_0 d) where a : IEquatable<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QCDTZLUDSMK : JsonConverter<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private delegate void ReaderAction(Utf8JsonReader r);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public SerializedAvatarItemData FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public JsonSerializerOptions ZDFBEGIBXWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public bool JAJBUAKCBXW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public QCDTZLUDSMK VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public ReaderAction VNPNSVZAKTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ReaderAction VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ReaderAction VOFIKQGSNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ReaderAction VOKPHXAPWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ReaderAction VOPWFDUNFXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public ReaderAction VOVDCKOKPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ReaderAction VMERMAPSWRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public ReaderAction BUNEJPNTJYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ReaderAction BUHXMITWANM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ReaderAction BUCQPBZYRCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ReaderAction BTXJRVGBHQU;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x88587E0", Offset = "0x88573E0", VA = "0x1888587E0")]
			internal void YPTPRBRBYHF(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88588D0", Offset = "0x88574D0", VA = "0x1888588D0")]
			internal void YQEDLPEWRDX(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8858820", Offset = "0x8857420", VA = "0x188858820")]
			internal void YPYWOIKZHSO(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8858A30", Offset = "0x8857630", VA = "0x188858A30")]
			internal void YQORGCSRKAP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8858980", Offset = "0x8857580", VA = "0x188858980")]
			internal void YQJKIVYUAPG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8858AE0", Offset = "0x88576E0", VA = "0x188858AE0")]
			internal void YQZFAQGMCXH(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8858B10", Offset = "0x8857710", VA = "0x188858B10")]
			internal void YRELXXAJMIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88585D0", Offset = "0x88571D0", VA = "0x1888585D0")]
			internal void THGSUQQSBZS(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x88586B0", Offset = "0x88572B0", VA = "0x1888586B0")]
			internal void THLZRXKPLLB(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88586F0", Offset = "0x88572F0", VA = "0x1888586F0")]
			internal void THRGPEEMUWK(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8858790", Offset = "0x8857390", VA = "0x188858790")]
			internal void THWNMKYKEHT(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GWLPQCWEVLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public string TPBBSEQZFIP;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWLPQCWEVLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8858B90", Offset = "0x8857790", VA = "0x188858B90")]
			internal void TIBUJRSHNTC(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8859720", Offset = "0x8858320", VA = "0x188859720", Slot = "27")]
		public override SerializedAvatarItemData Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x885A4E0", Offset = "0x88590E0", VA = "0x18885A4E0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, SerializedAvatarItemData value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x885A290", Offset = "0x8858E90", VA = "0x18885A290")]
		private AdditionalOutfitTypeData UJTUGNWOZAH(Utf8JsonReader a, OutfitType b, JsonSerializerOptions c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x885A920", Offset = "0x8859520", VA = "0x18885A920")]
		public QCDTZLUDSMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class TEFCJENDHTZ : JsonConverter<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x885B350", Offset = "0x8859F50", VA = "0x18885B350", Slot = "27")]
		public override AvatarItemDownloadableConfig Read(Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x885B6B0", Offset = "0x885A2B0", VA = "0x18885B6B0", Slot = "28")]
		public override void Write(Utf8JsonWriter writer, AvatarItemDownloadableConfig value, JsonSerializerOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x885B870", Offset = "0x885A470", VA = "0x18885B870")]
		public TEFCJENDHTZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class KZZVSDERMXB : WBFWXZCFLAE<BeardData>
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8858E70", Offset = "0x8857A70", VA = "0x188858E70", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, BeardData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8859000", Offset = "0x8857C00", VA = "0x188859000", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, BeardData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x88590C0", Offset = "0x8857CC0", VA = "0x1888590C0")]
		public KZZVSDERMXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SZPCSKADFYR : LNFPVZZPJIC<HelmetHairMode>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x885ABB0", Offset = "0x88597B0", VA = "0x18885ABB0")]
		public SZPCSKADFYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PHKRLPLCYNB : LNFPVZZPJIC<HelmetHairStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88596E0", Offset = "0x88582E0", VA = "0x1888596E0")]
		public PHKRLPLCYNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class TJMCCRBQATY : LNFPVZZPJIC<HairPatternStyle>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x885B8B0", Offset = "0x885A4B0", VA = "0x18885B8B0")]
		public TJMCCRBQATY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MWUESOMJHDL : JIBNSQGHNHT<OutfitType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8859100", Offset = "0x8857D00", VA = "0x188859100")]
		public MWUESOMJHDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OYFTHWCAZXV : WBFWXZCFLAE<AdditionalFeetData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AdditionalFeetData FAQPDUUDTIC;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x885C7A0", Offset = "0x885B3A0", VA = "0x18885C7A0")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x885CCB0", Offset = "0x885B8B0", VA = "0x18885CCB0")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8859450", Offset = "0x8858050", VA = "0x188859450", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalFeetData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88595D0", Offset = "0x88581D0", VA = "0x1888595D0", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, AdditionalFeetData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88596A0", Offset = "0x88582A0", VA = "0x1888596A0")]
		public OYFTHWCAZXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class UMDFPYRIOTV : WBFWXZCFLAE<HairData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HairData FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public JsonSerializerOptions ZDFBEGIBXWV;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x885CB20", Offset = "0x885B720", VA = "0x18885CB20")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x885CDD0", Offset = "0x885B9D0", VA = "0x18885CDD0")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x885CE00", Offset = "0x885BA00", VA = "0x18885CE00")]
			internal void ZWKJPMPQEFI(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x885D030", Offset = "0x885BC30", VA = "0x18885D030")]
			internal void ZWPQMTJNNQR(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x885C510", Offset = "0x885B110", VA = "0x18885C510")]
			internal void ZVEUFYAFZPG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x885C700", Offset = "0x885B300", VA = "0x18885C700")]
			internal void ZVKBDEUDJAP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x885C7A0", Offset = "0x885B3A0", VA = "0x18885C7A0")]
			internal void ZVPIALOASLY(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x885BBB0", Offset = "0x885A7B0", VA = "0x18885BBB0", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, HairData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x885BF50", Offset = "0x885AB50", VA = "0x18885BF50", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, HairData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x885C230", Offset = "0x885AE30", VA = "0x18885C230")]
		public UMDFPYRIOTV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class EJTVRTQVOBQ : WBFWXZCFLAE<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AdditionalHatData FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public JsonSerializerOptions ZDFBEGIBXWV;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x885CBD0", Offset = "0x885B7D0", VA = "0x18885CBD0")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x885CC00", Offset = "0x885B800", VA = "0x18885CC00")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x885CEE0", Offset = "0x885BAE0", VA = "0x18885CEE0")]
			internal void ZWKJPMPQEFI(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x885D0D0", Offset = "0x885BCD0", VA = "0x18885D0D0")]
			internal void ZWPQMTJNNQR(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x885C460", Offset = "0x885B060", VA = "0x18885C460")]
			internal void ZVEUFYAFZPG(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x885C660", Offset = "0x885B260", VA = "0x18885C660")]
			internal void ZVKBDEUDJAP(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x885C880", Offset = "0x885B480", VA = "0x18885C880")]
			internal void ZVPIALOASLY(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x885C920", Offset = "0x885B520", VA = "0x18885C920")]
			internal void ZVUOXSHYBXH(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8857E40", Offset = "0x8856A40", VA = "0x188857E40", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, AdditionalHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8858240", Offset = "0x8856E40", VA = "0x188858240", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, AdditionalHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8858590", Offset = "0x8857190", VA = "0x188858590")]
		public EJTVRTQVOBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class QZQLPLWWRZF : WBFWXZCFLAE<RoomieEyeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public RoomieEyeData FAQPDUUDTIC;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x885CA70", Offset = "0x885B670", VA = "0x18885CA70")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x885CCE0", Offset = "0x885B8E0", VA = "0x18885CCE0")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x885A960", Offset = "0x8859560", VA = "0x18885A960", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieEyeData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x885AAE0", Offset = "0x88596E0", VA = "0x18885AAE0", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, RoomieEyeData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x885AB70", Offset = "0x8859770", VA = "0x18885AB70")]
		public QZQLPLWWRZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class OGEJQKNGEQD : WBFWXZCFLAE<RoomieHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public RoomieHatData FAQPDUUDTIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JsonSerializerOptions ZDFBEGIBXWV;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x885CA70", Offset = "0x885B670", VA = "0x18885CA70")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x885CCE0", Offset = "0x885B8E0", VA = "0x18885CCE0")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x885CF90", Offset = "0x885BB90", VA = "0x18885CF90")]
			internal void ZWKJPMPQEFI(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8859140", Offset = "0x8857D40", VA = "0x188859140", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieHatData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8859310", Offset = "0x8857F10", VA = "0x188859310", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, RoomieHatData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8859410", Offset = "0x8858010", VA = "0x188859410")]
		public OGEJQKNGEQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class TVERKMQBLKI : WBFWXZCFLAE<RoomieWaistData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RoomieWaistData FAQPDUUDTIC;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x885CA70", Offset = "0x885B670", VA = "0x18885CA70")]
			internal void ZVZVUZBVLIQ(Utf8JsonReader a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x885CCE0", Offset = "0x885B8E0", VA = "0x18885CCE0")]
			internal void ZWFCSFVSUTZ(Utf8JsonReader a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x885B8F0", Offset = "0x885A4F0", VA = "0x18885B8F0", Slot = "35")]
		public override void UGNRYKMGVUM(Utf8JsonReader a, JsonSerializerOptions b, string c, RoomieWaistData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x885BA70", Offset = "0x885A670", VA = "0x18885BA70", Slot = "36")]
		public override void ZHOEXDSRTMF(Utf8JsonWriter a, RoomieWaistData b, JsonSerializerOptions c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x885BB00", Offset = "0x885A700", VA = "0x18885BB00")]
		public TVERKMQBLKI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xDD0FC0", Offset = "0xDCFBC0", VA = "0x180DD0FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xC901B0", Offset = "0xC8EDB0", VA = "0x180C901B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xFD0FB0", Offset = "0xFCFBB0", VA = "0x180FD0FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xFD0FC0", Offset = "0xFCFBC0", VA = "0x180FD0FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x119CEA0", Offset = "0x119BAA0", VA = "0x18119CEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x119CEB0", Offset = "0x119BAB0", VA = "0x18119CEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x885B0B0", Offset = "0x8859CB0", VA = "0x18885B0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x885B0C0", Offset = "0x8859CC0", VA = "0x18885B0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3225C30", Offset = "0x3224830", VA = "0x183225C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3225D10", Offset = "0x3224910", VA = "0x183225D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB61A10", Offset = "0xB60610", VA = "0x180B61A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB61A20", Offset = "0xB60620", VA = "0x180B61A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RRSNZGUWRZN.SkinCullingMask ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return default(RRSNZGUWRZN.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x14CABB0", Offset = "0x14C97B0", VA = "0x1814CABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x885AC10", Offset = "0x8859810", VA = "0x18885AC10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x885ABF0", Offset = "0x88597F0", VA = "0x18885ABF0")]
		public static bool EOXNKNKFOQL(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x885B080", Offset = "0x8859C80", VA = "0x18885B080")]
		public static bool SZMIMWEVICM(SerializedAvatarItemData a, SerializedAvatarItemData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x885ACA0", Offset = "0x88598A0", VA = "0x18885ACA0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x885AFB0", Offset = "0x8859BB0", VA = "0x18885AFB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
