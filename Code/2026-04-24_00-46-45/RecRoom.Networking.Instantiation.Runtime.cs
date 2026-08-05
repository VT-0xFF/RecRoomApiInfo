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
	public interface VUJTRFMQMFY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object YVEXNILOQUL(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject NJFPSSBRCRC(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject DEHLGPTNCFP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject BFUWNKQCRHR(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IKOUOAERFUK(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NCHKHPVVGJV(GameObject a);
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
		public KDSOOWCXYNX creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AB83D0", Offset = "0x9AB6DD0", VA = "0x189AB83D0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, KDSOOWCXYNX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8510", Offset = "0x9AB6F10", VA = "0x189AB8510")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, KDSOOWCXYNX creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8200", Offset = "0x9AB6C00", VA = "0x189AB8200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7BF0", Offset = "0x9AB65F0", VA = "0x189AB7BF0")]
		public string RXRTKPDDXKW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface YVPMBYMROHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] PTJPDMCELRF(IList<DYUPRJOGCEW> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GHXBTNFPIQS(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RZQPTSGPRFN(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NDZCIWOJAFI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class SMMXSDJLWIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly VUJTRFMQMFY instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			internal Access(VUJTRFMQMFY instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB7B70", Offset = "0x9AB6570", VA = "0x189AB7B70")]
			public void NXOYNQBSRTA(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB7AF0", Offset = "0x9AB64F0", VA = "0x189AB7AF0")]
			public void DMDOXXPLWUM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			private void AZZKXKJJDGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static VEFRPOSZNGH<PlayerId> ZIWQGJPKUVQ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static VEFRPOSZNGH<PlayerId> TJBGSXTTJZO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static ALKDGZAAFQB USEWHVWKZZN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static VEQFKCGUGCZ<KDSOOWCXYNX, double, object> OFCVWJJXCIV;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static VEFRPOSZNGH<IReadOnlyList<InstantiateParameters>> ZSUZGRFRMRS;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static VEKYMVMWWRQ<GameObject, bool> LLWVCXLVHAZ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static VEFRPOSZNGH<GameObject> MSQOQCUXSXZ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static VEFRPOSZNGH<GameObject> MTIHSMOCVVY;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static VEKYMVMWWRQ<int, int> TRWNSSCZAKG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static JOLHGBMRDLK JROMTJVNADN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static VDFJDGXMSBO<string, ViewId, DOIVUUSAOOU, DOIVUUSAOOU> DTUSHNVXVAF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static VUJTRFMQMFY WPWZGNITKAD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access ILDHHOXPVJC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static YVPMBYMROHF TJZMNXMEYBS;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static TLNYEWXUWJI ETXJETQGPXH;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GXLSEMXVYCP OGUPRCWALTS;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static YRGGLPTVQOD WIAKWAFUCSQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static TLNYEWXUWJI EHBFWJLKLYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9AB8640", Offset = "0x9AB7040", VA = "0x189AB8640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9AB8780", Offset = "0x9AB7180", VA = "0x189AB8780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GGZHMBVCVIO OOYSVBICORP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA9B0", Offset = "0x9AB93B0", VA = "0x189ABA9B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA3C0", Offset = "0x9AB8DC0", VA = "0x189ABA3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string ZPTLXARQHRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9770", Offset = "0x9AB8170", VA = "0x189AB9770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> HLHSFRELYDS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA430", Offset = "0x9AB8E30", VA = "0x189ABA430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool QQRCZTPFXJT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9EE0", Offset = "0x9AB88E0", VA = "0x189AB9EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool LIKRKGEZCXY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9580", Offset = "0x9AB7F80", VA = "0x189AB9580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool MHRLKDKFJFV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA680", Offset = "0x9AB9080", VA = "0x189ABA680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double QKEZKBPMOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA150", Offset = "0x9AB8B50", VA = "0x189ABA150")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int VBVCSSKGYYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AB87F0", Offset = "0x9AB71F0", VA = "0x189AB87F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float ATVZYPZCQHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9AB8F30", Offset = "0x9AB7930", VA = "0x189AB8F30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9020", Offset = "0x9AB7A20", VA = "0x189AB9020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9190", Offset = "0x9AB7B90", VA = "0x189AB9190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA800", Offset = "0x9AB9200", VA = "0x189ABA800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static IPBRLYOLLKP IQUODMNVGQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA880", Offset = "0x9AB9280", VA = "0x189ABA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static KDSOOWCXYNX DUOYZNQYDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9210", Offset = "0x9AB7C10", VA = "0x189AB9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static MBQGRUSTSMG HVFSCIYSEVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9290", Offset = "0x9AB7C90", VA = "0x189AB9290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int HCAAXHXVIGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9ABBC30", Offset = "0x9ABA630", VA = "0x189ABBC30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int ETQSHMXPUGT
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AB8A90", Offset = "0x9AB7490", VA = "0x189AB8A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int SXPHRTFQALB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9600", Offset = "0x9AB8000", VA = "0x189AB9600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string URTSTMCGUSD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9680", Offset = "0x9AB8080", VA = "0x189AB9680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long SOVOAOQMNNY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9A00", Offset = "0x9AB8400", VA = "0x189AB9A00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long LQZYSRGQDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB8910", Offset = "0x9AB7310", VA = "0x189AB8910")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool NQNCGBDWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA780", Offset = "0x9AB9180", VA = "0x189ABA780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA060", Offset = "0x9AB8A60", VA = "0x189ABA060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string UWSOQMSAHKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA620", Offset = "0x9AB9020", VA = "0x189ABA620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AB85C0", Offset = "0x9AB6FC0", VA = "0x189AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9310", Offset = "0x9AB7D10", VA = "0x189AB9310")]
		public static Access IGZAVMHNMGH(VUJTRFMQMFY a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAEF0", Offset = "0x9AB98F0", VA = "0x189ABAEF0")]
		public static void UYVYVCPSAKL(YVPMBYMROHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBB40", Offset = "0x9ABA540", VA = "0x189ABBB40")]
		public static object YVEXNILOQUL(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB300", Offset = "0x9AB9D00", VA = "0x189ABB300")]
		public static GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB060", Offset = "0x9AB9A60", VA = "0x189ABB060")]
		public static GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAF60", Offset = "0x9AB9960", VA = "0x189ABAF60")]
		public static GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB1B0", Offset = "0x9AB9BB0", VA = "0x189ABB1B0")]
		public static GameObject VCEYFMZSNYS(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9D90", Offset = "0x9AB8790", VA = "0x189AB9D90")]
		public static GameObject NJFPSSBRCRC(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9C10", Offset = "0x9AB8610", VA = "0x189AB9C10")]
		public static GameObject NJFPSSBRCRC(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8B10", Offset = "0x9AB7510", VA = "0x189AB8B10")]
		public static GameObject DEHLGPTNCFP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8690", Offset = "0x9AB7090", VA = "0x189AB8690")]
		public static GameObject BFUWNKQCRHR(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB93A0", Offset = "0x9AB7DA0", VA = "0x189AB93A0")]
		public static void IKOUOAERFUK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9B10", Offset = "0x9AB8510", VA = "0x189AB9B10")]
		public static void NCHKHPVVGJV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB6D0", Offset = "0x9ABA0D0", VA = "0x189ABB6D0")]
		public static GameObject WAOAIVEEGXW(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB770", Offset = "0x9ABA170", VA = "0x189ABB770")]
		public static GameObject WAOAIVEEGXW(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB490", Offset = "0x9AB9E90", VA = "0x189ABB490")]
		public static GameObject WAOAIVEEGXW(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA2C0", Offset = "0x9AB8CC0", VA = "0x189ABA2C0")]
		public static GameObject[] PTJPDMCELRF(IList<DYUPRJOGCEW> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AB94A0", Offset = "0x9AB7EA0", VA = "0x189AB94A0")]
		public static void KGCYODOQYGQ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA700", Offset = "0x9AB9100", VA = "0x189ABA700")]
		public static void RZQPTSGPRFN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9B90", Offset = "0x9AB8590", VA = "0x189AB9B90")]
		public static void NDZCIWOJAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9800", Offset = "0x9AB8200", VA = "0x189AB9800")]
		public static float MIIAHZRXNCI(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB910", Offset = "0x9ABA310", VA = "0x189ABB910")]
		public static KDSOOWCXYNX XAAYHUMVZMX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8870", Offset = "0x9AB7270", VA = "0x189AB8870")]
		public static KDSOOWCXYNX BRTYMRMESFT(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB810", Offset = "0x9ABA210", VA = "0x189ABB810")]
		public static KDSOOWCXYNX WGNWTBDNSVF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9A80", Offset = "0x9AB8480", VA = "0x189AB9A80")]
		public static IReadOnlyList<KDSOOWCXYNX> MZFIPIOGGNB(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA920", Offset = "0x9AB9320", VA = "0x189ABA920")]
		public static IReadOnlyList<KDSOOWCXYNX> TUMWMCJPUGI(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8D30", Offset = "0x9AB7730", VA = "0x189AB8D30")]
		public static void DYIVQXTDRGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8990", Offset = "0x9AB7390", VA = "0x189AB8990")]
		public static bool CCOQBHMCJAT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA520", Offset = "0x9AB8F20", VA = "0x189ABA520")]
		public static bool RDQCPBLTDHR(KDSOOWCXYNX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAD90", Offset = "0x9AB9790", VA = "0x189ABAD90")]
		public static bool UNRAXFIHVPM(NetworkEventCode a, object b, CBEOKZVPQNC c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAC50", Offset = "0x9AB9650", VA = "0x189ABAC50")]
		public static bool UNRAXFIHVPM(byte a, object b, CBEOKZVPQNC c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9420", Offset = "0x9AB7E20", VA = "0x189AB9420")]
		public static void KCVBXOSSSDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9F60", Offset = "0x9AB8960", VA = "0x189AB9F60")]
		public static void NZJDRENIZKU(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8DB0", Offset = "0x9AB77B0", VA = "0x189AB8DB0")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9900", Offset = "0x9AB8300", VA = "0x189AB9900")]
		public static int MNTKOONLCOG(EPOORIVUAQX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8EB0", Offset = "0x9AB78B0", VA = "0x189AB8EB0")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB9B0", Offset = "0x9ABA3B0", VA = "0x189ABB9B0")]
		public static void XEHMGHSTIXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA240", Offset = "0x9AB8C40", VA = "0x189ABA240")]
		public static int PCGTYUOJXFM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8A10", Offset = "0x9AB7410", VA = "0x189AB8A10")]
		public static void CSYSCFZYLIY(GXLSEMXVYCP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8CB0", Offset = "0x9AB76B0", VA = "0x189AB8CB0")]
		public static void DQDESCFKJEI(YRGGLPTVQOD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBA40", Offset = "0x9ABA440", VA = "0x189ABBA40")]
		public static string XNXIPPYNOHC(EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAB20", Offset = "0x9AB9520", VA = "0x189ABAB20")]
		public static void UJWWJMJCTRX(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAA00", Offset = "0x9AB9400", VA = "0x189ABAA00")]
		public static void UJWWJMJCTRX(ViewId a, string b, KDSOOWCXYNX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB90A0", Offset = "0x9AB7AA0", VA = "0x189AB90A0")]
		public static void GUAARKLHPPJ(ViewId a)
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
