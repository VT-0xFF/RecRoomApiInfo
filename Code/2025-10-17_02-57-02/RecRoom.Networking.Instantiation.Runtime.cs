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
	public interface ONDEQGSGMTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object BWQNSOCHFCJ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject NMIKNQWZPBE(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject VEYWMXSFKJZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject HTKZTHKLRNP(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JUVZSQEWEQQ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HPIKIOVKHKF(GameObject a);
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
		public LRIABUPBGVB creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85F9B10", Offset = "0x85F8110", VA = "0x1885F9B10")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, LRIABUPBGVB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85F9A60", Offset = "0x85F8060", VA = "0x1885F9A60")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, LRIABUPBGVB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85F9290", Offset = "0x85F7890", VA = "0x1885F9290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85F9460", Offset = "0x85F7A60", VA = "0x1885F9460")]
		public string ZANIBSBQACQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface XFWBBFNUYHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] KUKZNVASMGJ(IList<OSIQXZBIXOM> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CSYKHTXGHJO(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RBILCSNAOSN(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZMPEKYQCMOQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class BMYVGIWDWRA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly ONDEQGSGMTS instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			internal Access(ONDEQGSGMTS instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85F59C0", Offset = "0x85F3FC0", VA = "0x1885F59C0")]
			public void VTUIJTCOVQE(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85F5A40", Offset = "0x85F4040", VA = "0x1885F5A40")]
			public void YJPXGVIOOCG(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
			private void LLLIJSUNASA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static YQBTYEHUFCJ<PlayerId> DUESGTCXPVS;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static YQBTYEHUFCJ<PlayerId> UDOBDGDIRZE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static LBZZZSNEOUH SGABYGXHOTL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static YPRGDQTZMFR<LRIABUPBGVB, double, object> QQKHOOERELZ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static YQBTYEHUFCJ<IReadOnlyList<InstantiateParameters>> EBQAKUTXPMC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static YPLZGKACCUI<GameObject, bool> AMPJRCHGWQP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static YQBTYEHUFCJ<GameObject> NOZIORTGRUN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static YQBTYEHUFCJ<GameObject> VSZSFILIZAQ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static YPLZGKACCUI<int, int> ZWWVQCFOKIE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static ENIVEIKFIDY SQCFKPTTADL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static YQBTYEHUFCJ<string> OHOPLNMFSBZ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static ONDEQGSGMTS EHYJNPTNWND;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access OWEJWSDVUEK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static XFWBBFNUYHH WBQEOSDUHAG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static FUPHZSXQDCM ANGMIEKZQSL;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GSJHGGBTZJP KKTJTIKYZVY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FUPHZSXQDCM BOQAQLGFZOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x85F5AC0", Offset = "0x85F40C0", VA = "0x1885F5AC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85F7590", Offset = "0x85F5B90", VA = "0x1885F7590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static QKPLUTIPQBC LODSSXVYMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85F6180", Offset = "0x85F4780", VA = "0x1885F6180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85F5FA0", Offset = "0x85F45A0", VA = "0x1885F5FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string VFFMJFAUHPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85F6340", Offset = "0x85F4940", VA = "0x1885F6340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> TWHAMMEMUFY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x85F61D0", Offset = "0x85F47D0", VA = "0x1885F61D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85F7FE0", Offset = "0x85F65E0", VA = "0x1885F7FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85F8990", Offset = "0x85F6F90", VA = "0x1885F8990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool RWMSFILBLUR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85F8440", Offset = "0x85F6A40", VA = "0x1885F8440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double QMXCMFRZYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85F8720", Offset = "0x85F6D20", VA = "0x1885F8720")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int XAFLDETVPRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x85F6F50", Offset = "0x85F5550", VA = "0x1885F6F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float LNQEKLSZPSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x85F85B0", Offset = "0x85F6BB0", VA = "0x1885F85B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85F66B0", Offset = "0x85F4CB0", VA = "0x1885F66B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85F6540", Offset = "0x85F4B40", VA = "0x1885F6540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85F7490", Offset = "0x85F5A90", VA = "0x1885F7490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static VMUJRLNJPHP AVUADSSKXTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85F7F40", Offset = "0x85F6540", VA = "0x1885F7F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LRIABUPBGVB OJYVFBFKHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x85F7C80", Offset = "0x85F6280", VA = "0x1885F7C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static LULDBTLWMMU NAABVCHULKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x85F6970", Offset = "0x85F4F70", VA = "0x1885F6970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int WKQPIRWOUFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85F6730", Offset = "0x85F4D30", VA = "0x1885F6730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int NSVJDHNRQKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x85F8060", Offset = "0x85F6660", VA = "0x1885F8060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int IZCIEUZNMTT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x85F5BF0", Offset = "0x85F41F0", VA = "0x1885F5BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string DPCDTBVKSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85F7600", Offset = "0x85F5C00", VA = "0x1885F7600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long JUEMVLWLMBS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85F6010", Offset = "0x85F4610", VA = "0x1885F6010")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long GYAGCJOQOFV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85F6C60", Offset = "0x85F5260", VA = "0x1885F6C60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool VAZDZMRSDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85F8910", Offset = "0x85F6F10", VA = "0x1885F8910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85F84C0", Offset = "0x85F6AC0", VA = "0x1885F84C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string WDSPKGPJSXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x85F67B0", Offset = "0x85F4DB0", VA = "0x1885F67B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85F86A0", Offset = "0x85F6CA0", VA = "0x1885F86A0")]
		public static Access WYVNYXFXAHH(ONDEQGSGMTS a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85F8A10", Offset = "0x85F7010", VA = "0x1885F8A10")]
		public static void ZDPFGYSGIMZ(XFWBBFNUYHH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85F5C70", Offset = "0x85F4270", VA = "0x1885F5C70")]
		public static object BWQNSOCHFCJ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85F7980", Offset = "0x85F5F80", VA = "0x1885F7980")]
		public static GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85F7830", Offset = "0x85F5E30", VA = "0x1885F7830")]
		public static GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85F7B00", Offset = "0x85F6100", VA = "0x1885F7B00")]
		public static GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85F76F0", Offset = "0x85F5CF0", VA = "0x1885F76F0")]
		public static GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85F72C0", Offset = "0x85F58C0", VA = "0x1885F72C0")]
		public static GameObject NMIKNQWZPBE(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85F7140", Offset = "0x85F5740", VA = "0x1885F7140")]
		public static GameObject NMIKNQWZPBE(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85F81D0", Offset = "0x85F67D0", VA = "0x1885F81D0")]
		public static GameObject VEYWMXSFKJZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85F6880", Offset = "0x85F4E80", VA = "0x1885F6880")]
		public static GameObject HTKZTHKLRNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B60", Offset = "0x85F5160", VA = "0x1885F6B60")]
		public static void JUVZSQEWEQQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85F6800", Offset = "0x85F4E00", VA = "0x1885F6800")]
		public static void HPIKIOVKHKF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F8B00", Offset = "0x85F7100", VA = "0x1885F8B00")]
		public static GameObject ZVHPKUPTOTY(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85F8BA0", Offset = "0x85F71A0", VA = "0x1885F8BA0")]
		public static GameObject ZVHPKUPTOTY(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85F8C40", Offset = "0x85F7240", VA = "0x1885F8C40")]
		public static GameObject ZVHPKUPTOTY(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F6CE0", Offset = "0x85F52E0", VA = "0x1885F6CE0")]
		public static GameObject[] KUKZNVASMGJ(IList<OSIQXZBIXOM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85F8360", Offset = "0x85F6960", VA = "0x1885F8360")]
		public static void VXGDANXWZKO(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C00", Offset = "0x85F6200", VA = "0x1885F7C00")]
		public static void RBILCSNAOSN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85F8A80", Offset = "0x85F7080", VA = "0x1885F8A80")]
		public static void ZMPEKYQCMOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85F8810", Offset = "0x85F6E10", VA = "0x1885F8810")]
		public static float YMZRYPUBVMK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85F62B0", Offset = "0x85F48B0", VA = "0x1885F62B0")]
		public static LRIABUPBGVB DNCAMOEVDPX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F7EB0", Offset = "0x85F64B0", VA = "0x1885F7EB0")]
		public static LRIABUPBGVB SFXJGGUGRGT(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85F7050", Offset = "0x85F5650", VA = "0x1885F7050")]
		public static LRIABUPBGVB NFVPIIQPSWR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F6AE0", Offset = "0x85F50E0", VA = "0x1885F6AE0")]
		public static IReadOnlyList<LRIABUPBGVB> JHFUMHTVXIR(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85F7E30", Offset = "0x85F6430", VA = "0x1885F7E30")]
		public static IReadOnlyList<LRIABUPBGVB> SCHANGSOPCC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85F6A60", Offset = "0x85F5060", VA = "0x1885F6A60")]
		public static void JBQIZXOFPVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85F6BE0", Offset = "0x85F51E0", VA = "0x1885F6BE0")]
		public static bool KFKCHGZLITT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85F65C0", Offset = "0x85F4BC0", VA = "0x1885F65C0")]
		public static bool EYHVMJXQPTD(LRIABUPBGVB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85F7D00", Offset = "0x85F6300", VA = "0x1885F7D00")]
		public static bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85F7510", Offset = "0x85F5B10", VA = "0x1885F7510")]
		public static void QDCEVCMUVNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85F6DE0", Offset = "0x85F53E0", VA = "0x1885F6DE0")]
		public static void KYZOGDONURM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85F63C0", Offset = "0x85F49C0", VA = "0x1885F63C0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85F6090", Offset = "0x85F4690", VA = "0x1885F6090")]
		public static int CZGRFBDRIQI(KMNYUBYLMOF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85F64C0", Offset = "0x85F4AC0", VA = "0x1885F64C0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85F7410", Offset = "0x85F5A10", VA = "0x1885F7410")]
		public static void OIWJOOSVADD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85F6FD0", Offset = "0x85F55D0", VA = "0x1885F6FD0")]
		public static int MLWORJOZBWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85F6EE0", Offset = "0x85F54E0", VA = "0x1885F6EE0")]
		public static void LEFGCXCCWYK(LRJLKNGLINT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85F69F0", Offset = "0x85F4FF0", VA = "0x1885F69F0")]
		public static void JBBWISWBNJY(GSJHGGBTZJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85F80E0", Offset = "0x85F66E0", VA = "0x1885F80E0")]
		public static string UQDEJWFDIJA(KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85F5E70", Offset = "0x85F4470", VA = "0x1885F5E70")]
		public static void BYWISIGZRAP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85F5D50", Offset = "0x85F4350", VA = "0x1885F5D50")]
		public static void BYWISIGZRAP(ViewId a, string b, LRIABUPBGVB c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85F5B10", Offset = "0x85F4110", VA = "0x1885F5B10")]
		public static void BESVZIHDHDL(ViewId a)
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
