using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface JXSFMLMZRLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object DQSTCKQBNBQ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject PQIKNJMNIFR(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject BXCMFBIQWIO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject KMRFFWPFOWE(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LRKINRTMXWN(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZEADRMCICCY(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct InstantiateParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int[] viewIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte objLevelPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public object[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public WJBKOLNRRJE creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B06630", Offset = "0x8B05230", VA = "0x188B06630")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, WJBKOLNRRJE creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B06770", Offset = "0x8B05370", VA = "0x188B06770")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, WJBKOLNRRJE creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B06460", Offset = "0x8B05060", VA = "0x188B06460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B05E50", Offset = "0x8B04A50", VA = "0x188B05E50")]
		public string PBGSOUCAAZJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface EYMANZDSEGU
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] ANJUMCSOQYK(IList<UHZKUSZYQRX> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XMRFPZPHOPH(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HMXHRLNLREE(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FYDAQJYTLMD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class AVBPMSNQCXH
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly JXSFMLMZRLH instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			internal Access(JXSFMLMZRLH instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8B05D50", Offset = "0x8B04950", VA = "0x188B05D50")]
			public void LWTAQEAAJNZ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8B05DD0", Offset = "0x8B049D0", VA = "0x188B05DD0")]
			public void MBGLOEOQVZF(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
			private void DITOLBWHTTZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static HWNZTWGRXOC<PlayerId> DLREPEKXLVB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static HWNZTWGRXOC<PlayerId> MWBWOTOMDLR;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static BXPKXKSWHTE IYASBWMBMUU;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static HWDLZISXERK<WJBKOLNRRJE, double, object> YSVEVRSERRQ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static HWISWPMUOCT<GameObject, bool> VCBRFJOUCSG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static HWNZTWGRXOC<GameObject> TVXGQLOCPLO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static HWNZTWGRXOC<GameObject> MGEJISYNVHP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static HWISWPMUOCT<int, int> WFHLWZNGASV;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static AQWXMNIFQIV HDHARZPYLOW;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static HWNZTWGRXOC<string> MIFNFPMKPEI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static JXSFMLMZRLH SYSPUVSPKYK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static Access UXEZEQWCSDV;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static EYMANZDSEGU YHYKXZDBEFP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static MKGORJXBMTV PEQDTDUCOAC;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static EJTGRNPRMBA UPJKJBQXFNZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MKGORJXBMTV ALARROQROSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8B05910", Offset = "0x8B04510", VA = "0x188B05910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8B02B30", Offset = "0x8B01730", VA = "0x188B02B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IFGWPBGBILN ABHNMQWGLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8B02FF0", Offset = "0x8B01BF0", VA = "0x188B02FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8B02A30", Offset = "0x8B01630", VA = "0x188B02A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string MVDTPWRFZDU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B04A40", Offset = "0x8B03640", VA = "0x188B04A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> KHSBOZUXYFX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B04950", Offset = "0x8B03550", VA = "0x188B04950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool FRGHDAZDKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B05230", Offset = "0x8B03E30", VA = "0x188B05230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool QDVEDJHOVLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8B03610", Offset = "0x8B02210", VA = "0x188B03610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool SBNSKLFULUG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B029B0", Offset = "0x8B015B0", VA = "0x188B029B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double AUQDPIVCHZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B02F00", Offset = "0x8B01B00", VA = "0x188B02F00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int DSGWFOJGIFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B05400", Offset = "0x8B04000", VA = "0x188B05400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float VRYQVHOKDOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8B05620", Offset = "0x8B04220", VA = "0x188B05620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8B03230", Offset = "0x8B01E30", VA = "0x188B03230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool OQWVSBVOFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8B03430", Offset = "0x8B02030", VA = "0x188B03430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8B05520", Offset = "0x8B04120", VA = "0x188B05520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static QJXWOHUBXKU YUUSVKZWQVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8B05480", Offset = "0x8B04080", VA = "0x188B05480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static WJBKOLNRRJE EDOAEKBLKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8B04210", Offset = "0x8B02E10", VA = "0x188B04210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static WGQKHJHIHJT NCXELNDCXQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B04290", Offset = "0x8B02E90", VA = "0x188B04290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int BAXMPNLKWHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B04490", Offset = "0x8B03090", VA = "0x188B04490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int BXOMLBXBQEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8B032B0", Offset = "0x8B01EB0", VA = "0x188B032B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int GUPHGNFOYMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B03590", Offset = "0x8B02190", VA = "0x188B03590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string SNHYKSCBNQO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8B03040", Offset = "0x8B01C40", VA = "0x188B03040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long JRKMRJXEUZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8B05140", Offset = "0x8B03D40", VA = "0x188B05140")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long HRGTDMOUQVY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B03130", Offset = "0x8B01D30", VA = "0x188B03130")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool SKMBRSBWOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8B050C0", Offset = "0x8B03CC0", VA = "0x188B050C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string LKGQEHRLQQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8B02730", Offset = "0x8B01330", VA = "0x188B02730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8B03330", Offset = "0x8B01F30", VA = "0x188B03330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B02AA0", Offset = "0x8B016A0", VA = "0x188B02AA0")]
		public static Access CUPHVWMVWCM(JXSFMLMZRLH a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B051C0", Offset = "0x8B03DC0", VA = "0x188B051C0")]
		public static void UZUGFTZEWHC(EYMANZDSEGU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B02BA0", Offset = "0x8B017A0", VA = "0x188B02BA0")]
		public static object DQSTCKQBNBQ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B03EA0", Offset = "0x8B02AA0", VA = "0x188B03EA0")]
		public static GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B03C00", Offset = "0x8B02800", VA = "0x188B03C00")]
		public static GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B03B00", Offset = "0x8B02700", VA = "0x188B03B00")]
		public static GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B03D50", Offset = "0x8B02950", VA = "0x188B03D50")]
		public static GameObject KPISTWDZNHR(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B04800", Offset = "0x8B03400", VA = "0x188B04800")]
		public static GameObject PQIKNJMNIFR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B04680", Offset = "0x8B03280", VA = "0x188B04680")]
		public static GameObject PQIKNJMNIFR(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B02810", Offset = "0x8B01410", VA = "0x188B02810")]
		public static GameObject BXCMFBIQWIO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B03A10", Offset = "0x8B02610", VA = "0x188B03A10")]
		public static GameObject KMRFFWPFOWE(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8B040A0", Offset = "0x8B02CA0", VA = "0x188B040A0")]
		public static void LRKINRTMXWN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B05890", Offset = "0x8B04490", VA = "0x188B05890")]
		public static void ZEADRMCICCY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B03690", Offset = "0x8B02290", VA = "0x188B03690")]
		public static GameObject KGQTTZATBTB(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B03970", Offset = "0x8B02570", VA = "0x188B03970")]
		public static GameObject KGQTTZATBTB(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B03730", Offset = "0x8B02330", VA = "0x188B03730")]
		public static GameObject KGQTTZATBTB(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B02620", Offset = "0x8B01220", VA = "0x188B02620")]
		public static GameObject[] ANJUMCSOQYK(IList<UHZKUSZYQRX> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B05320", Offset = "0x8B03F20", VA = "0x188B05320")]
		public static void WKTSGIJLRRH(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B033B0", Offset = "0x8B01FB0", VA = "0x188B033B0")]
		public static void HMXHRLNLREE(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B031B0", Offset = "0x8B01DB0", VA = "0x188B031B0")]
		public static void FYDAQJYTLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B04390", Offset = "0x8B02F90", VA = "0x188B04390")]
		public static float NULNMPVZHAX(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B05040", Offset = "0x8B03C40", VA = "0x188B05040")]
		public static WJBKOLNRRJE TRBSVSFBQLQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B04600", Offset = "0x8B03200", VA = "0x188B04600")]
		public static WJBKOLNRRJE OUPJDKYGOPG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B04E40", Offset = "0x8B03A40", VA = "0x188B04E40")]
		public static WJBKOLNRRJE SYFRPMTIPBU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B05710", Offset = "0x8B04310", VA = "0x188B05710")]
		public static IReadOnlyList<WJBKOLNRRJE> XXSWMMVJKIC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B05790", Offset = "0x8B04390", VA = "0x188B05790")]
		public static IReadOnlyList<WJBKOLNRRJE> YFINFNYJFCJ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B02790", Offset = "0x8B01390", VA = "0x188B02790")]
		public static void BDGKBLKFTSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B04310", Offset = "0x8B02F10", VA = "0x188B04310")]
		public static bool NSIPUDQETRM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B02C90", Offset = "0x8B01890", VA = "0x188B02C90")]
		public static bool DXTAWHMKVAW(WJBKOLNRRJE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B04AC0", Offset = "0x8B036C0", VA = "0x188B04AC0")]
		public static bool RaiseEvent(byte eventCode, object eventContent, PZIMWREHPGJ raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B05810", Offset = "0x8B04410", VA = "0x188B05810")]
		public static void YQSYZGNNHQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B04EC0", Offset = "0x8B03AC0", VA = "0x188B04EC0")]
		public static void Serialize(object obj, NativeList<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B02D80", Offset = "0x8B01980", VA = "0x188B02D80")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B04510", Offset = "0x8B03110", VA = "0x188B04510")]
		public static int OQZQHXEOPLL(RQAGMLJLYPY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B02E80", Offset = "0x8B01A80", VA = "0x188B02E80")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B04FC0", Offset = "0x8B03BC0", VA = "0x188B04FC0")]
		public static void TEDPDIJZHPG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B055A0", Offset = "0x8B041A0", VA = "0x188B055A0")]
		public static int XOKNWYKQWRZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B052B0", Offset = "0x8B03EB0", VA = "0x188B052B0")]
		public static void VZFOZJTGZPT(ZUUCGYXVQOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B04020", Offset = "0x8B02C20", VA = "0x188B04020")]
		public static void LDFTLZGIWFL(EJTGRNPRMBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B04120", Offset = "0x8B02D20", VA = "0x188B04120")]
		public static string MMALBATTXHF(RQAGMLJLYPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B04D10", Offset = "0x8B03910", VA = "0x188B04D10")]
		public static void SHCTNHUYBUY(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B04BF0", Offset = "0x8B037F0", VA = "0x188B04BF0")]
		public static void SHCTNHUYBUY(ViewId a, string b, WJBKOLNRRJE c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B034B0", Offset = "0x8B020B0", VA = "0x188B034B0")]
		public static void HTIMSIDCFII(ViewId a)
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
