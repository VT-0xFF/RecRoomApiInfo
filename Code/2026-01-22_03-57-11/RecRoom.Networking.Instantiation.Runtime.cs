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
	public interface YORFQSKXVLR
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object PJLCOCCCTGI(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject SFLYKBDRTVD(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject RFDUBZYIPLD(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject VLGJGPWDLSE(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject TXJLZCJVAAG(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BJCPGVTEGAD(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NPOMXXCXQBE(GameObject a);
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
		public MNBQIABPYXS creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83EC690", Offset = "0x83EAE90", VA = "0x1883EC690")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, MNBQIABPYXS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83EC7D0", Offset = "0x83EAFD0", VA = "0x1883EC7D0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, MNBQIABPYXS creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83EBEC0", Offset = "0x83EA6C0", VA = "0x1883EBEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83EC090", Offset = "0x83EA890", VA = "0x1883EC090")]
		public string UQXEAIDMMOR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface XQMOCBHUFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] FOSYHUACDSY(IList<MLHMCHAWAZR> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KPYHUMNPXFF(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IIBPKOTLKYC(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WQMAWOPJNMJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class CXNOQFCOTVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly YORFQSKXVLR instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
			internal Access(YORFQSKXVLR instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83E8480", Offset = "0x83E6C80", VA = "0x1883E8480")]
			public void TCLFYTPKTSZ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83E8400", Offset = "0x83E6C00", VA = "0x1883E8400")]
			public void QCKRQCXLDYZ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
			private void LVVCDOAZLBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static WXSKNELZHVC<PlayerId> DSWOOVNAHJT;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static WXSKNELZHVC<PlayerId> JTKFAYLMDPL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static IUZJXZPQTPC PFHHYDRQATA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static WYCYHRZUARU<MNBQIABPYXS, double, object> RKNWZIJIQCI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static WXSKNELZHVC<IReadOnlyList<InstantiateParameters>> BRWOVJCXASZ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static WYIFEYTRKDD<GameObject, bool> SGVCKCWAPRK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static WXSKNELZHVC<GameObject> QEWEBLRNSPQ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static WXSKNELZHVC<GameObject> ZBODSBSQQOX;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static WYIFEYTRKDD<int, int> DHYOBMZAKNF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static XOOCNKBZGKP CWQECXLAHWQ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static WYSSZMHMCZV<string, ViewId, DSEMOZDMDYR, DSEMOZDMDYR> UEQLZRWXEDM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static YORFQSKXVLR ZOVGZVPNEWU;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access WBOPWYJHFWJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static XQMOCBHUFBA MBMRAXBXKZZ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static JOLQARSFLPH UEFHLZDLWOI;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GIDVIXDVHZW JWGJSJVTGSR;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static UCYYFCDLNGM CTBEEMDFUFD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JOLQARSFLPH WDJZLMZYXGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83E8880", Offset = "0x83E7080", VA = "0x1883E8880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x83E8500", Offset = "0x83E6D00", VA = "0x1883E8500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ZXJJGQYGFFT DQCUJHJKOTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83EB4F0", Offset = "0x83E9CF0", VA = "0x1883EB4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x83EB400", Offset = "0x83E9C00", VA = "0x1883EB400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string OSWOJTCUOUU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83EBA30", Offset = "0x83EA230", VA = "0x1883EBA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> QBYZQKLGRAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x83E8790", Offset = "0x83E6F90", VA = "0x1883E8790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool RXOATIRNKMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83EA720", Offset = "0x83E8F20", VA = "0x1883EA720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool WUQNCLUJMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83EA030", Offset = "0x83E8830", VA = "0x1883EA030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool LDTVAYEWKZO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x83E9080", Offset = "0x83E7880", VA = "0x1883E9080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double SNQZVXRVFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83EB8C0", Offset = "0x83EA0C0", VA = "0x1883EB8C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int ZZPJWOKLUZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83E9100", Offset = "0x83E7900", VA = "0x1883E9100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float HQNDGMRLYBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83E8B60", Offset = "0x83E7360", VA = "0x1883E8B60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83EA530", Offset = "0x83E8D30", VA = "0x1883EA530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool JJAXACDEXPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83EB380", Offset = "0x83E9B80", VA = "0x1883EB380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static MNBQIABPYXS QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x83E9FB0", Offset = "0x83E87B0", VA = "0x1883E9FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static TMTPKRTSWNA GNOWVBVSYDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83E8670", Offset = "0x83E6E70", VA = "0x1883E8670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static MNBQIABPYXS JQWQXHCSCMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83E93F0", Offset = "0x83E7BF0", VA = "0x1883E93F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static MAWHZFSGVAP ILYBKPKQJHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x83E92F0", Offset = "0x83E7AF0", VA = "0x1883E92F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int KDNLELRDVAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83E98F0", Offset = "0x83E80F0", VA = "0x1883E98F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int DGYPTPOPNJS
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x83EB9B0", Offset = "0x83EA1B0", VA = "0x1883EB9B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int GRGZCYSJZAI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83E9870", Offset = "0x83E8070", VA = "0x1883E9870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string MDGDSCIYQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83EA630", Offset = "0x83E8E30", VA = "0x1883EA630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long QBLQIFDXPRH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83E9180", Offset = "0x83E7980", VA = "0x1883E9180")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long XSWTUHKYISM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x83EA1E0", Offset = "0x83E89E0", VA = "0x1883EA1E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BAFEEAIWCEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83E9A70", Offset = "0x83E8270", VA = "0x1883E9A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x83E9780", Offset = "0x83E7F80", VA = "0x1883E9780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string KJXUAJCESWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83EA190", Offset = "0x83E8990", VA = "0x1883EA190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83E9970", Offset = "0x83E8170", VA = "0x1883E9970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83E8710", Offset = "0x83E6F10", VA = "0x1883E8710")]
		public static Access BZYEUKFPZNA(YORFQSKXVLR a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83E9280", Offset = "0x83E7A80", VA = "0x1883E9280")]
		public static void IIGXVQGHLJY(XQMOCBHUFBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83EA0B0", Offset = "0x83E88B0", VA = "0x1883EA0B0")]
		public static object PJLCOCCCTGI(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83EA9E0", Offset = "0x83E91E0", VA = "0x1883EA9E0")]
		public static GameObject SFLYKBDRTVD(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83EAB60", Offset = "0x83E9360", VA = "0x1883EAB60")]
		public static GameObject SFLYKBDRTVD(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83EA8E0", Offset = "0x83E90E0", VA = "0x1883EA8E0")]
		public static GameObject SFLYKBDRTVD(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83EA7A0", Offset = "0x83E8FA0", VA = "0x1883EA7A0")]
		public static GameObject SFLYKBDRTVD(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83EA3E0", Offset = "0x83E8BE0", VA = "0x1883EA3E0")]
		public static GameObject RFDUBZYIPLD(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83EA260", Offset = "0x83E8A60", VA = "0x1883EA260")]
		public static GameObject RFDUBZYIPLD(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83EB0E0", Offset = "0x83E98E0", VA = "0x1883EB0E0")]
		public static GameObject VLGJGPWDLSE(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83EAFF0", Offset = "0x83E97F0", VA = "0x1883EAFF0")]
		public static GameObject TXJLZCJVAAG(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83E85F0", Offset = "0x83E6DF0", VA = "0x1883E85F0")]
		public static void BJCPGVTEGAD(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83E9C60", Offset = "0x83E8460", VA = "0x1883E9C60")]
		public static void NPOMXXCXQBE(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83EB540", Offset = "0x83E9D40", VA = "0x1883EB540")]
		public static GameObject XSIBFJVAUOV(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83EB5E0", Offset = "0x83E9DE0", VA = "0x1883EB5E0")]
		public static GameObject XSIBFJVAUOV(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83EB680", Offset = "0x83E9E80", VA = "0x1883EB680")]
		public static GameObject XSIBFJVAUOV(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83E8F80", Offset = "0x83E7780", VA = "0x1883E8F80")]
		public static GameObject[] FOSYHUACDSY(IList<MLHMCHAWAZR> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83E8C50", Offset = "0x83E7450", VA = "0x1883E8C50")]
		public static void EGMMITWNRQH(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83E9200", Offset = "0x83E7A00", VA = "0x1883E9200")]
		public static void IIBPKOTLKYC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83EB470", Offset = "0x83E9C70", VA = "0x1883EB470")]
		public static void WQMAWOPJNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83E9AF0", Offset = "0x83E82F0", VA = "0x1883E9AF0")]
		public static float MRUBOQBUEBD(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83E88D0", Offset = "0x83E70D0", VA = "0x1883E88D0")]
		public static MNBQIABPYXS DNCBCMCMERG(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83E99E0", Offset = "0x83E81E0", VA = "0x1883E99E0")]
		public static MNBQIABPYXS LTKKPDBWUAO(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83EACB0", Offset = "0x83E94B0", VA = "0x1883EACB0")]
		public static MNBQIABPYXS SSWMEFDYLAQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83E9470", Offset = "0x83E7C70", VA = "0x1883E9470")]
		public static IReadOnlyList<MNBQIABPYXS> JCCBSMAEIHS(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83E8570", Offset = "0x83E6D70", VA = "0x1883E8570")]
		public static IReadOnlyList<MNBQIABPYXS> AYONRPZRHYX(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83E8DA0", Offset = "0x83E75A0", VA = "0x1883E8DA0")]
		public static void EPLNHXZGDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83E9370", Offset = "0x83E7B70", VA = "0x1883E9370")]
		public static bool IRLQPMXILIE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83E9CE0", Offset = "0x83E84E0", VA = "0x1883E9CE0")]
		public static bool OAPWSGQJWXK(MNBQIABPYXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83E9620", Offset = "0x83E7E20", VA = "0x1883E9620")]
		public static bool JUFIERDKBIL(NetworkEventCode a, object b, JFVSBLTWLJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83E94F0", Offset = "0x83E7CF0", VA = "0x1883E94F0")]
		public static bool JUFIERDKBIL(byte a, object b, JFVSBLTWLJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83E8AE0", Offset = "0x83E72E0", VA = "0x1883E8AE0")]
		public static void EBBIGFIXXBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83EB280", Offset = "0x83E9A80", VA = "0x1883EB280")]
		public static void VOPQGDPBGDJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83E8960", Offset = "0x83E7160", VA = "0x1883E8960")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83E9EC0", Offset = "0x83E86C0", VA = "0x1883E9EC0")]
		public static int PEAKUQXNCHZ(TZRHNFDOAHO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83E8A60", Offset = "0x83E7260", VA = "0x1883E8A60")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83E8E20", Offset = "0x83E7620", VA = "0x1883E8E20")]
		public static void EQEFYTZJIGG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83EA5B0", Offset = "0x83E8DB0", VA = "0x1883EA5B0")]
		public static int RPNUICCKAJP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83E9BF0", Offset = "0x83E83F0", VA = "0x1883E9BF0")]
		public static void MXXWOVAUHKH(GIDVIXDVHZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83E8D30", Offset = "0x83E7530", VA = "0x1883E8D30")]
		public static void ENBCZPYSGFZ(UCYYFCDLNGM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83E9DD0", Offset = "0x83E85D0", VA = "0x1883E9DD0")]
		public static string ORMDBFTVLSF(TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83EAEC0", Offset = "0x83E96C0", VA = "0x1883EAEC0")]
		public static void TFSTPNIONKO(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83EADA0", Offset = "0x83E95A0", VA = "0x1883EADA0")]
		public static void TFSTPNIONKO(ViewId a, string b, MNBQIABPYXS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83E8EA0", Offset = "0x83E76A0", VA = "0x1883E8EA0")]
		public static void EWNPTOIPIXE(ViewId a)
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
