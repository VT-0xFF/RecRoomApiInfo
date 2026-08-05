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
	public interface JKQIMQDMJRB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object OTTIQOEXUWY(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject AWCYPCMMQCN(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject XNYMMMLFBDO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject IRHTLBPAULE(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MBEKEJHWFBB(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SXSZMIUTLVU(GameObject a);
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
		public HNNNRVHBOIU creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82B83D0", Offset = "0x82B6FD0", VA = "0x1882B83D0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, HNNNRVHBOIU creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82B8510", Offset = "0x82B7110", VA = "0x1882B8510")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, HNNNRVHBOIU creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82B8200", Offset = "0x82B6E00", VA = "0x1882B8200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B7BF0", Offset = "0x82B67F0", VA = "0x1882B7BF0")]
		public string NCXSXYBVMYZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface JAINKIUYJFU
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] VBKXOSQVQME(IList<SMQGRYCPFUL> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HNDWAQPIKAX(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ISTEPQHCPJA(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EUDTLUWVWNH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class MJGVIUZJCRF
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly JKQIMQDMJRB instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			internal Access(JKQIMQDMJRB instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82B7B70", Offset = "0x82B6770", VA = "0x1882B7B70")]
			public void WZVCPEPWAOJ(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82B7AF0", Offset = "0x82B66F0", VA = "0x1882B7AF0")]
			public void NZYRDMLKQZP(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
			private void SNVMMFUWTUZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static NWSEZICLNSM<PlayerId> GAHTVRPDDDD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static NWSEZICLNSM<PlayerId> IGPVNCPZKUB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static GCMCWUIFCBW CIFRYZLXCPM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static NXCSTVQGGPE<HNNNRVHBOIU, double, object> OZISZYVIBDO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static NWSEZICLNSM<IReadOnlyList<InstantiateParameters>> CRUOSQZDRRD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static NXHZRCKDQAN<GameObject, bool> YAIFKQGOASY;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static NWSEZICLNSM<GameObject> HEQZSYUQESW;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static NWSEZICLNSM<GameObject> YCBQEDRIDGH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static NXHZRCKDQAN<int, int> NGQJCXXVRGD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static ANFWHCNXABV WUGPWOUGVLS;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static NWSEZICLNSM<string> XMAHFXNSJMC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static JKQIMQDMJRB MFIMFHVQVKM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access ACMDPJSBXRX;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static JAINKIUYJFU QLABBGZOFZB;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static ONGDOVIOISJ ZXJYEOVZBDO;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static TZUPOYZJAQI PYQXBYNJZSB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ONGDOVIOISJ ECJHYDKVHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC60", Offset = "0x82BA860", VA = "0x1882BBC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x82BAE10", Offset = "0x82B9A10", VA = "0x1882BAE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static RVAAVKKTQYF HNGYYUNTXIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82BA000", Offset = "0x82B8C00", VA = "0x1882BA000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82BACA0", Offset = "0x82B98A0", VA = "0x1882BACA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string UWJBRDGJUEA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82B9B60", Offset = "0x82B8760", VA = "0x1882B9B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> JHZQITBBQVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82B9900", Offset = "0x82B8500", VA = "0x1882B9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool KQCYZHSQQPA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82BA990", Offset = "0x82B9590", VA = "0x1882BA990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool YFQYCPKHFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82BAD10", Offset = "0x82B9910", VA = "0x1882BAD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool YDQAPUMAQBS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82B9BF0", Offset = "0x82B87F0", VA = "0x1882B9BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double EAOUHZIGMIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82B8B60", Offset = "0x82B7760", VA = "0x1882B8B60")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int RIBGQPPKWXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB40", Offset = "0x82BA740", VA = "0x1882BBB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float GGBCGHKJBVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82BA6B0", Offset = "0x82B92B0", VA = "0x1882BA6B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82B9350", Offset = "0x82B7F50", VA = "0x1882B9350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool UQYTEXVZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x82B8C50", Offset = "0x82B7850", VA = "0x1882B8C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static HNNNRVHBOIU XLUZORLMXGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82B92D0", Offset = "0x82B7ED0", VA = "0x1882B92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static VJDBCIHMDFY EKFKGQMMLYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82B94D0", Offset = "0x82B80D0", VA = "0x1882B94D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static HNNNRVHBOIU ELTNHEYPHNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x82BA4B0", Offset = "0x82B90B0", VA = "0x1882BA4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static XRAQZTPNOOL MNJLQVIZHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82BB5B0", Offset = "0x82BA1B0", VA = "0x1882BB5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int GQVGPMRCACH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82BAE80", Offset = "0x82B9A80", VA = "0x1882BAE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int QOHFJVZPLLC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82B99F0", Offset = "0x82B85F0", VA = "0x1882B99F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int KHSSCMEYBWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82B85C0", Offset = "0x82B71C0", VA = "0x1882B85C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string UWXMIAENKNK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82B9C70", Offset = "0x82B8870", VA = "0x1882B9C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long GENXJCNQIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82BB930", Offset = "0x82BA530", VA = "0x1882BB930")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long AQRBVUUNMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82BAC20", Offset = "0x82B9820", VA = "0x1882BAC20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool ZLETGCJCKAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82BA2C0", Offset = "0x82B8EC0", VA = "0x1882BA2C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x82B9A70", Offset = "0x82B8670", VA = "0x1882B9A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string ZXBJHCPRMTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82BA450", Offset = "0x82B9050", VA = "0x1882BA450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82BA630", Offset = "0x82B9230", VA = "0x1882BA630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82BA340", Offset = "0x82B8F40", VA = "0x1882BA340")]
		public static Access KMCLEZTAUGG(JKQIMQDMJRB a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82BB630", Offset = "0x82BA230", VA = "0x1882BB630")]
		public static void XJIJNGZWYBQ(JAINKIUYJFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82BAB30", Offset = "0x82B9730", VA = "0x1882BAB30")]
		public static object OTTIQOEXUWY(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82BB150", Offset = "0x82B9D50", VA = "0x1882BB150")]
		public static GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82BB000", Offset = "0x82B9C00", VA = "0x1882BB000")]
		public static GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82BB430", Offset = "0x82BA030", VA = "0x1882BB430")]
		public static GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82BB2E0", Offset = "0x82B9EE0", VA = "0x1882BB2E0")]
		public static GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82B8890", Offset = "0x82B7490", VA = "0x1882B8890")]
		public static GameObject AWCYPCMMQCN(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82B89E0", Offset = "0x82B75E0", VA = "0x1882B89E0")]
		public static GameObject AWCYPCMMQCN(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82BB6A0", Offset = "0x82BA2A0", VA = "0x1882BB6A0")]
		public static GameObject XNYMMMLFBDO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82BA050", Offset = "0x82B8C50", VA = "0x1882BA050")]
		public static GameObject IRHTLBPAULE(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82BA7A0", Offset = "0x82B93A0", VA = "0x1882BA7A0")]
		public static void MBEKEJHWFBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82BAD90", Offset = "0x82B9990", VA = "0x1882BAD90")]
		public static void SXSZMIUTLVU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82B8D50", Offset = "0x82B7950", VA = "0x1882B8D50")]
		public static GameObject BRLULYZEZHL(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82B8DF0", Offset = "0x82B79F0", VA = "0x1882B8DF0")]
		public static GameObject BRLULYZEZHL(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82B8E90", Offset = "0x82B7A90", VA = "0x1882B8E90")]
		public static GameObject BRLULYZEZHL(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82BAF00", Offset = "0x82B9B00", VA = "0x1882BAF00")]
		public static GameObject[] VBKXOSQVQME(IList<SMQGRYCPFUL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82BA820", Offset = "0x82B9420", VA = "0x1882BA820")]
		public static void MMQECSOZAHJ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82BA140", Offset = "0x82B8D40", VA = "0x1882BA140")]
		public static void ISTEPQHCPJA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82B97F0", Offset = "0x82B83F0", VA = "0x1882B97F0")]
		public static void EUDTLUWVWNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82BA1C0", Offset = "0x82B8DC0", VA = "0x1882BA1C0")]
		public static float IXHPQIHRHSR(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82BBBC0", Offset = "0x82BA7C0", VA = "0x1882BBBC0")]
		public static HNNNRVHBOIU ZQLFHJMEOAE(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82BAA10", Offset = "0x82B9610", VA = "0x1882BAA10")]
		public static HNNNRVHBOIU ONFTWYJKCJA(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82B90D0", Offset = "0x82B7CD0", VA = "0x1882B90D0")]
		public static HNNNRVHBOIU CBBCUIHOWJO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82B9870", Offset = "0x82B8470", VA = "0x1882B9870")]
		public static IReadOnlyList<HNNNRVHBOIU> FCMCPPHOVVO(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82BBAB0", Offset = "0x82BA6B0", VA = "0x1882BBAB0")]
		public static IReadOnlyList<HNNNRVHBOIU> YUKCINGTHVZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82BB530", Offset = "0x82BA130", VA = "0x1882BB530")]
		public static void WFHDBZSFRTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82BA3D0", Offset = "0x82B8FD0", VA = "0x1882BA3D0")]
		public static bool KQAZARADCEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82BB9B0", Offset = "0x82BA5B0", VA = "0x1882BB9B0")]
		public static bool YSOBWZHXTVG(HNNNRVHBOIU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82B9EA0", Offset = "0x82B8AA0", VA = "0x1882B9EA0")]
		public static bool IGMPHTEKPZF(NetworkEventCode a, object b, QINZOSCQMJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82B9D60", Offset = "0x82B8960", VA = "0x1882B9D60")]
		public static bool IGMPHTEKPZF(byte a, object b, QINZOSCQMJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82BA5B0", Offset = "0x82B91B0", VA = "0x1882BA5B0")]
		public static void LGEACRKAJZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82B93D0", Offset = "0x82B7FD0", VA = "0x1882B93D0")]
		public static void DKWNNTIDYNZ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82B9570", Offset = "0x82B8170", VA = "0x1882B9570")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82B91D0", Offset = "0x82B7DD0", VA = "0x1882B91D0")]
		public static int CGUZUMQJKTF(PKPJICLPGZO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82B9670", Offset = "0x82B8270", VA = "0x1882B9670")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82BA900", Offset = "0x82B9500", VA = "0x1882BA900")]
		public static void MPACOKPJKNE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82BAAB0", Offset = "0x82B96B0", VA = "0x1882BAAB0")]
		public static int ONTQCKUPGLX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82B8CD0", Offset = "0x82B78D0", VA = "0x1882B8CD0")]
		public static void BPBYQJXTGFB(TSOFJGCPTYM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82BA530", Offset = "0x82B9130", VA = "0x1882BA530")]
		public static void LAHNHVLLKJV(TZUPOYZJAQI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82B96F0", Offset = "0x82B82F0", VA = "0x1882B96F0")]
		public static string EOZWOLDEDLH(PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82B8640", Offset = "0x82B7240", VA = "0x1882B8640")]
		public static void AQBEZSEJJEW(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82B8770", Offset = "0x82B7370", VA = "0x1882B8770")]
		public static void AQBEZSEJJEW(ViewId a, string b, HNNNRVHBOIU c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82BB840", Offset = "0x82BA440", VA = "0x1882BB840")]
		public static void YKKMAAEYPDE(ViewId a)
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
