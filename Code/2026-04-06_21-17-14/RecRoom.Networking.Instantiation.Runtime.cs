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
	public interface TDCHMMXAEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object JWZQGMGSIRJ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject HKMQHACNOYB(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject IZEHYHGEZOL(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AGJMMPUFJGG(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JHKWOLEPZJJ(GameObject a);
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
		public QCTMRFTYWMB creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AA85A0", Offset = "0x9AA75A0", VA = "0x189AA85A0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, QCTMRFTYWMB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AA86E0", Offset = "0x9AA76E0", VA = "0x189AA86E0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, QCTMRFTYWMB creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7DC0", Offset = "0x9AA6DC0", VA = "0x189AA7DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7F90", Offset = "0x9AA6F90", VA = "0x189AA7F90")]
		public string UKZJDPNUYFM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QXIAHLXVXIX
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] ZBUHWNQSTZF(IList<FBYVQEPOTAK> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QCDSJPGHJXI(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AYSDNCUEYFJ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FTTRMULHQJA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GDNDOJFCHLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly TDCHMMXAEAK instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			internal Access(TDCHMMXAEAK instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA41F0", Offset = "0x9AA31F0", VA = "0x189AA41F0")]
			public void SVACPBRBKIC(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4270", Offset = "0x9AA3270", VA = "0x189AA4270")]
			public void VPXTUXTONCM(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
			private void FIWATNDFQFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static BQFVKUSIMFN<PlayerId> TFIYDLNCLYG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static BQFVKUSIMFN<PlayerId> RXTTRCNNEBC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static SOEJOTFBVHT SNFDUGULNWD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static BQQJFIGDFCF<QCTMRFTYWMB, double, object> EAMTASZYAMN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static BQFVKUSIMFN<IReadOnlyList<InstantiateParameters>> MZNKAELOKEE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static BQLCIBMFVQW<GameObject, bool> JSBDHXVKRNX;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BQFVKUSIMFN<GameObject> FUXSGRDPRDV;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static BQFVKUSIMFN<GameObject> RJVHDBDBNOG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static BQLCIBMFVQW<int, int> ZIVNJNRDLTQ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static FYRDCSIKYKI POLDTEVZHMH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static BPFMYMWVRAU<string, ViewId, SMBOLORBDSA, SMBOLORBDSA> ZMASXSDYAYB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static TDCHMMXAEAK POEUUXEHQLN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access QVUNMLVWOVO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static QXIAHLXVXIX ONIBBVHRPDK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static HTJYADKPZIO GIXBVPZEMBP;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static VTBHZBONJTB UOLRISREJII;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static BPUMKMZRCBN VBWCYGAOEOQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static HTJYADKPZIO VNRZBPXJSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9AA51D0", Offset = "0x9AA41D0", VA = "0x189AA51D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6990", Offset = "0x9AA5990", VA = "0x189AA6990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ECJSWXZFQRA MPKHANPYTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5220", Offset = "0x9AA4220", VA = "0x189AA5220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5BD0", Offset = "0x9AA4BD0", VA = "0x189AA5BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string OCQUBLJNPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6E40", Offset = "0x9AA5E40", VA = "0x189AA6E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> PDEDWOOYZWY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4B10", Offset = "0x9AA3B10", VA = "0x189AA4B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool WUGYAMPLMXD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6880", Offset = "0x9AA5880", VA = "0x189AA6880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool CASXLHDKDYC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6ED0", Offset = "0x9AA5ED0", VA = "0x189AA6ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool QSHEVNXINNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4370", Offset = "0x9AA3370", VA = "0x189AA4370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double XUGUCERVHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5970", Offset = "0x9AA4970", VA = "0x189AA5970")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int OFLKXJLVGZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6260", Offset = "0x9AA5260", VA = "0x189AA6260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float NMQNGGQOBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4EE0", Offset = "0x9AA3EE0", VA = "0x189AA4EE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6DC0", Offset = "0x9AA5DC0", VA = "0x189AA6DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4FD0", Offset = "0x9AA3FD0", VA = "0x189AA4FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6800", Offset = "0x9AA5800", VA = "0x189AA6800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JNIFYRYESKL OSLOXOYULWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5590", Offset = "0x9AA4590", VA = "0x189AA5590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static QCTMRFTYWMB LERYWHOBAMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4660", Offset = "0x9AA3660", VA = "0x189AA4660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static RBRIQVJRNNA OPNMTYWCXMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AA66F0", Offset = "0x9AA56F0", VA = "0x189AA66F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int MPZTSRIXLCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5050", Offset = "0x9AA4050", VA = "0x189AA5050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int IEWCABQVDNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9AA73E0", Offset = "0x9AA63E0", VA = "0x189AA73E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int ZHNVWTSOVZB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5410", Offset = "0x9AA4410", VA = "0x189AA5410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string VYJSHSWXBJR
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AA62E0", Offset = "0x9AA52E0", VA = "0x189AA62E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long BKDJBWQALJI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4970", Offset = "0x9AA3970", VA = "0x189AA4970")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long FKWROGGQLPD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4C00", Offset = "0x9AA3C00", VA = "0x189AA4C00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool YIMSHLABBZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AA49F0", Offset = "0x9AA39F0", VA = "0x189AA49F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9AA47E0", Offset = "0x9AA37E0", VA = "0x189AA47E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string CHYHKZNZCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AA6690", Offset = "0x9AA5690", VA = "0x189AA6690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5150", Offset = "0x9AA4150", VA = "0x189AA5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7350", Offset = "0x9AA6350", VA = "0x189AA7350")]
		public static Access WUBIJWZVQAT(TDCHMMXAEAK a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AA63D0", Offset = "0x9AA53D0", VA = "0x189AA63D0")]
		public static void NHCWQDNXNUL(QXIAHLXVXIX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AA57A0", Offset = "0x9AA47A0", VA = "0x189AA57A0")]
		public static object JWZQGMGSIRJ(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5CC0", Offset = "0x9AA4CC0", VA = "0x189AA5CC0")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6090", Offset = "0x9AA5090", VA = "0x189AA6090")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5E40", Offset = "0x9AA4E40", VA = "0x189AA5E40")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5F40", Offset = "0x9AA4F40", VA = "0x189AA5F40")]
		public static GameObject MRWPUQWMDLM(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6A00", Offset = "0x9AA5A00", VA = "0x189AA6A00")]
		public static GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6B50", Offset = "0x9AA5B50", VA = "0x189AA6B50")]
		public static GameObject SBWQJTLMQQM(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5270", Offset = "0x9AA4270", VA = "0x189AA5270")]
		public static GameObject HKMQHACNOYB(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5630", Offset = "0x9AA4630", VA = "0x189AA5630")]
		public static GameObject IZEHYHGEZOL(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA42F0", Offset = "0x9AA32F0", VA = "0x189AA42F0")]
		public static void AGJMMPUFJGG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5720", Offset = "0x9AA4720", VA = "0x189AA5720")]
		public static void JHKWOLEPZJJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7230", Offset = "0x9AA6230", VA = "0x189AA7230")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7190", Offset = "0x9AA6190", VA = "0x189AA7190")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6F50", Offset = "0x9AA5F50", VA = "0x189AA6F50")]
		public static GameObject VDGMRESEZSM(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AA75D0", Offset = "0x9AA65D0", VA = "0x189AA75D0")]
		public static GameObject[] ZBUHWNQSTZF(IList<FBYVQEPOTAK> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4E00", Offset = "0x9AA3E00", VA = "0x189AA4E00")]
		public static void EGMENCGEESI(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4480", Offset = "0x9AA3480", VA = "0x189AA4480")]
		public static void AYSDNCUEYFJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AA50D0", Offset = "0x9AA40D0", VA = "0x189AA50D0")]
		public static void FTTRMULHQJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5490", Offset = "0x9AA4490", VA = "0x189AA5490")]
		public static float IPGVAAGBOEQ(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4A70", Offset = "0x9AA3A70", VA = "0x189AA4A70")]
		public static QCTMRFTYWMB DOSIYYYTFMX(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA48D0", Offset = "0x9AA38D0", VA = "0x189AA48D0")]
		public static QCTMRFTYWMB DEVHBWDOJSF(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7460", Offset = "0x9AA6460", VA = "0x189AA7460")]
		public static QCTMRFTYWMB XCFOZJMINOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AA43F0", Offset = "0x9AA33F0", VA = "0x189AA43F0")]
		public static IReadOnlyList<QCTMRFTYWMB> ALTKBHTYVUP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6770", Offset = "0x9AA5770", VA = "0x189AA6770")]
		public static IReadOnlyList<QCTMRFTYWMB> QKTYMEZZGOA(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AA72D0", Offset = "0x9AA62D0", VA = "0x189AA72D0")]
		public static void WKCPVNOITUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5A60", Offset = "0x9AA4A60", VA = "0x189AA5A60")]
		public static bool KQCVZKRFVIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5880", Offset = "0x9AA4880", VA = "0x189AA5880")]
		public static bool KFOAQEJMPPJ(QCTMRFTYWMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AA76D0", Offset = "0x9AA66D0", VA = "0x189AA76D0")]
		public static bool ZKAFYNRYOQW(NetworkEventCode a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7830", Offset = "0x9AA6830", VA = "0x189AA7830")]
		public static bool ZKAFYNRYOQW(byte a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4500", Offset = "0x9AA3500", VA = "0x189AA4500")]
		public static void AZDULUIDTAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AA46E0", Offset = "0x9AA36E0", VA = "0x189AA46E0")]
		public static void BIDIANLANQI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4C80", Offset = "0x9AA3C80", VA = "0x189AA4C80")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6CD0", Offset = "0x9AA5CD0", VA = "0x189AA6CD0")]
		public static int SDBOPHCHTSK(PKEJZTAIXED a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D80", Offset = "0x9AA3D80", VA = "0x189AA4D80")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6900", Offset = "0x9AA5900", VA = "0x189AA6900")]
		public static void RTKJDKUWSXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5C40", Offset = "0x9AA4C40", VA = "0x189AA5C40")]
		public static int MMCQUIJKMDU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AA61E0", Offset = "0x9AA51E0", VA = "0x189AA61E0")]
		public static void MSWHIKDLCZK(VTBHZBONJTB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AA7550", Offset = "0x9AA6550", VA = "0x189AA7550")]
		public static void YEULCBBEOOA(BPUMKMZRCBN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AA5AE0", Offset = "0x9AA4AE0", VA = "0x189AA5AE0")]
		public static string KUGKHQMMPOQ(PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6560", Offset = "0x9AA5560", VA = "0x189AA6560")]
		public static void OGVTRJXPDIZ(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AA6440", Offset = "0x9AA5440", VA = "0x189AA6440")]
		public static void OGVTRJXPDIZ(ViewId a, string b, QCTMRFTYWMB c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4580", Offset = "0x9AA3580", VA = "0x189AA4580")]
		public static void BAMBNRYZJAH(ViewId a)
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
