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
	public interface JEDQQXFDVFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object LCCOTEPWARS(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject SUXKQMWMFKZ(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject EXTYENTFENO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject DSQZHXILZZM(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XBCGFBFUCGL(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IAXZSYLLCBA(GameObject a);
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
		public XGOJTPBZDNO creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x867EB10", Offset = "0x867D910", VA = "0x18867EB10")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, XGOJTPBZDNO creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x867EC50", Offset = "0x867DA50", VA = "0x18867EC50")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, XGOJTPBZDNO creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x867E940", Offset = "0x867D740", VA = "0x18867E940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x867E340", Offset = "0x867D140", VA = "0x18867E340")]
		public string QWPJDMZCIBH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QNODZBPZCZA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] ZFWTYLEFRAI(IList<NDZRBGPKBQL> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PHMTFEENHVZ(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TIZYDJPHAOC(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XBHZXIKNZNL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class PHIXWHQRDZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly JEDQQXFDVFB instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
			internal Access(JEDQQXFDVFB instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x867E240", Offset = "0x867D040", VA = "0x18867E240")]
			public void WXZWHHDQEAF(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x867E2C0", Offset = "0x867D0C0", VA = "0x18867E2C0")]
			public void XKZOODUUWIB(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			private void EFFNDLTBEOZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static OZAYXQWBYWY<PlayerId> EBNRKANCPMB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static OZAYXQWBYWY<PlayerId> MIEDIUQMEHT;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static BAYKEAXSOXC WGQYKZXWXEO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static OZLMSEJWRTQ<XGOJTPBZDNO, double, object> GOIRAJTXCFO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static OZAYXQWBYWY<IReadOnlyList<InstantiateParameters>> WYRJKEOOTBD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static OZQTPLDUBEZ<GameObject, bool> EIINGDJJEVC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static OZAYXQWBYWY<GameObject> SHYUMCFZQGW;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static OZAYXQWBYWY<GameObject> XGIPOCZBNTV;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static OZQTPLDUBEZ<int, int> FEMANXRUEWP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static DQHMEXLDKHB YBHTRLVHLGU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static OZAYXQWBYWY<string> PWNBBNVHXUC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static JEDQQXFDVFB QTFCSRZVXOE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access XNVERRSKESR;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static QNODZBPZCZA WIDWFMCETTV;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static KEQHONITTPT IXZQLGODIYA;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static OPHUDFYFNLW ABGGNHCKVWB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static KEQHONITTPT MPMQSMDQHXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8680C70", Offset = "0x867FA70", VA = "0x188680C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8680450", Offset = "0x867F250", VA = "0x188680450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static AKIAFFFHFEZ OFEHWZUFJYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8680090", Offset = "0x867EE90", VA = "0x188680090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8680020", Offset = "0x867EE20", VA = "0x188680020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string ICPOJMBRVOY
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x867F7F0", Offset = "0x867E5F0", VA = "0x18867F7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> LLQZNYGPMXF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x86810A0", Offset = "0x867FEA0", VA = "0x1886810A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool DRGQMQQAUXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8681870", Offset = "0x8680670", VA = "0x188681870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool KFZBVYMRAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x867FD50", Offset = "0x867EB50", VA = "0x18867FD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool YTNBPNOSJHS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x867FC50", Offset = "0x867EA50", VA = "0x18867FC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double DIHMSZUWUBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x867F0D0", Offset = "0x867DED0", VA = "0x18867F0D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int XGARBZOEMRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x86800E0", Offset = "0x867EEE0", VA = "0x1886800E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float CGQMQWECGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x86809D0", Offset = "0x867F7D0", VA = "0x1886809D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x867F870", Offset = "0x867E670", VA = "0x18867F870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool QPWLCIFHQJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x86801E0", Offset = "0x867EFE0", VA = "0x1886801E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static XGOJTPBZDNO BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x867EE00", Offset = "0x867DC00", VA = "0x18867EE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static YBMGACIJTUK MLXSNUPGFQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x867F4B0", Offset = "0x867E2B0", VA = "0x18867F4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static XGOJTPBZDNO EFVVCJCQKSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86804C0", Offset = "0x867F2C0", VA = "0x1886804C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IPMVOLERGYH JWWLKRPNCFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x867F8F0", Offset = "0x867E6F0", VA = "0x18867F8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int SFEDHOALWHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8680160", Offset = "0x867EF60", VA = "0x188680160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int ZAVFUVNWISQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x867F770", Offset = "0x867E570", VA = "0x18867F770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int HQNNTHXHLZC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x867FAE0", Offset = "0x867E8E0", VA = "0x18867FAE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string UUDQRAUXDKU
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8681190", Offset = "0x867FF90", VA = "0x188681190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long MVTDTYDMUAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86803D0", Offset = "0x867F1D0", VA = "0x1886803D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long XVNGITVOAIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8680540", Offset = "0x867F340", VA = "0x188680540")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool WQRDYAPGRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8680350", Offset = "0x867F150", VA = "0x188680350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x867FB60", Offset = "0x867E960", VA = "0x18867FB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string WTYASJAPURN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x86806B0", Offset = "0x867F4B0", VA = "0x1886806B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x867FCD0", Offset = "0x867EAD0", VA = "0x18867FCD0")]
		public static Access JBRIDSHTJDY(JEDQQXFDVFB a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x867EE80", Offset = "0x867DC80", VA = "0x18867EE80")]
		public static void BDJMLCPAFKS(QNODZBPZCZA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x867FF30", Offset = "0x867ED30", VA = "0x18867FF30")]
		public static object LCCOTEPWARS(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86814D0", Offset = "0x86802D0", VA = "0x1886814D0")]
		public static GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8681380", Offset = "0x8680180", VA = "0x188681380")]
		public static GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8681280", Offset = "0x8680080", VA = "0x188681280")]
		public static GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8681650", Offset = "0x8680450", VA = "0x188681650")]
		public static GameObject UTYWAWODPGN(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8680E40", Offset = "0x867FC40", VA = "0x188680E40")]
		public static GameObject SUXKQMWMFKZ(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8680CC0", Offset = "0x867FAC0", VA = "0x188680CC0")]
		public static GameObject SUXKQMWMFKZ(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x867F550", Offset = "0x867E350", VA = "0x18867F550")]
		public static GameObject EXTYENTFENO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x867F1C0", Offset = "0x867DFC0", VA = "0x18867F1C0")]
		public static GameObject DSQZHXILZZM(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86819F0", Offset = "0x86807F0", VA = "0x1886819F0")]
		public static void XBCGFBFUCGL(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x867FA60", Offset = "0x867E860", VA = "0x18867FA60")]
		public static void IAXZSYLLCBA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8681B90", Offset = "0x8680990", VA = "0x188681B90")]
		public static GameObject XGXZKBDNIQN(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8681AF0", Offset = "0x86808F0", VA = "0x188681AF0")]
		public static GameObject XGXZKBDNIQN(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8681C30", Offset = "0x8680A30", VA = "0x188681C30")]
		public static GameObject XGXZKBDNIQN(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8681FF0", Offset = "0x8680DF0", VA = "0x188681FF0")]
		public static GameObject[] ZFWTYLEFRAI(IList<NDZRBGPKBQL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8681790", Offset = "0x8680590", VA = "0x188681790")]
		public static void VMFMKLKOFEL(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8680F90", Offset = "0x867FD90", VA = "0x188680F90")]
		public static void TIZYDJPHAOC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8681A70", Offset = "0x8680870", VA = "0x188681A70")]
		public static void XBHZXIKNZNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x867ED00", Offset = "0x867DB00", VA = "0x18867ED00")]
		public static float ASUXFXOABOZ(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8681010", Offset = "0x867FE10", VA = "0x188681010")]
		public static XGOJTPBZDNO TMCMSHIYMKY(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8681E70", Offset = "0x8680C70", VA = "0x188681E70")]
		public static XGOJTPBZDNO YBLHDXQBZQW(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x867F970", Offset = "0x867E770", VA = "0x18867F970")]
		public static XGOJTPBZDNO HZDVDXSQUJG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x867F6F0", Offset = "0x867E4F0", VA = "0x18867F6F0")]
		public static IReadOnlyList<XGOJTPBZDNO> FTKOFGOJVAY(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8681F70", Offset = "0x8680D70", VA = "0x188681F70")]
		public static IReadOnlyList<XGOJTPBZDNO> YQTFVEVPURN(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x867EEF0", Offset = "0x867DCF0", VA = "0x18867EEF0")]
		public static void CKTVASTCHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8680BF0", Offset = "0x867F9F0", VA = "0x188680BF0")]
		public static bool SDATCZPUNUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86805C0", Offset = "0x867F3C0", VA = "0x1886805C0")]
		public static bool QNKIKGYQPDC(XGOJTPBZDNO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8680AC0", Offset = "0x867F8C0", VA = "0x188680AC0")]
		public static bool RaiseEvent(byte eventCode, object eventContent, QBWHSXSYUOT raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x867FDD0", Offset = "0x867EBD0", VA = "0x18867FDD0")]
		public static void KJVYWOSJVXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86818F0", Offset = "0x86806F0", VA = "0x1886818F0")]
		public static void VVUFAYMMXPR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x867F2B0", Offset = "0x867E0B0", VA = "0x18867F2B0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8680260", Offset = "0x867F060", VA = "0x188680260")]
		public static int NNQKMAKZPGT(EREVFMKOODS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x867F3B0", Offset = "0x867E1B0", VA = "0x18867F3B0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8680950", Offset = "0x867F750", VA = "0x188680950")]
		public static void RLXZEVYDQEG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x867F430", Offset = "0x867E230", VA = "0x18867F430")]
		public static int EEYLIGMBJQJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x867F060", Offset = "0x867DE60", VA = "0x18867F060")]
		public static void CZIKIIOCIZZ(VJRNQPLOUBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8681F00", Offset = "0x8680D00", VA = "0x188681F00")]
		public static void YMOZVHOUXNR(OPHUDFYFNLW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x867EF70", Offset = "0x867DD70", VA = "0x18867EF70")]
		public static string CQBHGNGZOFP(EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8680700", Offset = "0x867F500", VA = "0x188680700")]
		public static void RJSZVFLGOGG(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8680830", Offset = "0x867F630", VA = "0x188680830")]
		public static void RJSZVFLGOGG(ViewId a, string b, XGOJTPBZDNO c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x867FE50", Offset = "0x867EC50", VA = "0x18867FE50")]
		public static void KUNNFJFQVXE(ViewId a)
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
