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
	public interface GWWSLAWLITR
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object IRBAMTSNTRG(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GameObject IOOWYHLTAIR(string a, Vector3 b, Quaternion c, float d, object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject LMUCMCSXYVG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GameObject IGDGHRIOVOK(InstantiateParameters a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IWPYUJCCEQH(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UOCWQHRVDDA(GameObject a);
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
		public LZEYQUPSRUQ creator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int timestamp;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8571C70", Offset = "0x8570A70", VA = "0x188571C70")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, float scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, LZEYQUPSRUQ creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8571DB0", Offset = "0x8570BB0", VA = "0x188571DB0")]
		public InstantiateParameters(string prefabName, Vector3 position, Quaternion rotation, Vector3 scale, byte group, object[] data, byte objLevelPrefix, int[] viewIDs, LZEYQUPSRUQ creator, int timestamp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8571AA0", Offset = "0x85708A0", VA = "0x188571AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85714B0", Offset = "0x85702B0", VA = "0x1885714B0")]
		public string KOTDGVIICMZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IXHWWEEMCTM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject[] OMTWEHZEBKE(IList<HWBSQPITHTV> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JRSUDGLWOQP(List<GameObject> a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NRVHMNAFHTM(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HRNZTBZXOCN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class RAOWNDZDGGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct Access
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly GWWSLAWLITR instantiation;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
			internal Access(GWWSLAWLITR instantiation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85713B0", Offset = "0x85701B0", VA = "0x1885713B0")]
			public void OBZASIWNHON(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8571430", Offset = "0x8570230", VA = "0x188571430")]
			public void QELCJZPSULT(PlayerId a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
			private void YLNCMJEJLDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static YVFAYFMDPIA<PlayerId> RBWPBMHPCBD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static YVFAYFMDPIA<PlayerId> YKIIZZULOXL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static ZPMZXUEDLIU HGXHCIEEHMG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static YVPOSSZYIES<LZEYQUPSRUQ, double, object> GCAQIILGEAY;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static YVFAYFMDPIA<IReadOnlyList<InstantiateParameters>> SJKHYWZUPGJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static YVUVPZTVRQB<GameObject, bool> SWAVUJLKRAQ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static YVFAYFMDPIA<GameObject> MOYOPAGUITE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static YVFAYFMDPIA<GameObject> SUFLJHWIATJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static YVUVPZTVRQB<int, int> YHRCROERYYL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static VYROOIAXTCX AMOAEZEGEJC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static YVFAYFMDPIA<string> TUVZTETDMRU;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static GWWSLAWLITR SXTLVJFWFXS;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Access VNLNHQUGYHX;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static IXHWWEEMCTM AQVXCAGBWDZ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static LUQYOCSEHCF ESOEOANIYPK;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static RZNZAUAZENO STXRZHKCANP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static QXSZZHJGVNS JHHJKDJHBXH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static LUQYOCSEHCF RSWUEUMYREU
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8571E60", Offset = "0x8570C60", VA = "0x188571E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8574220", Offset = "0x8573020", VA = "0x188574220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static NFAJSMPTQUV VSWEEQCJWPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8574E90", Offset = "0x8573C90", VA = "0x188574E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8573A30", Offset = "0x8572830", VA = "0x188573A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static string XNOSUSNTGNW
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8574A80", Offset = "0x8573880", VA = "0x188574A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static Func<string, string> KPIVEISJAML
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8573EF0", Offset = "0x8572CF0", VA = "0x188573EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static bool EBZAJFLGPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8571F30", Offset = "0x8570D30", VA = "0x188571F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool BSHEGRJNMKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8574D00", Offset = "0x8573B00", VA = "0x188574D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool NRNTSANFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8575330", Offset = "0x8574130", VA = "0x188575330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static double ZZXWEPDGXLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8574610", Offset = "0x8573410", VA = "0x188574610")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static int JESLADALABS
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8571FB0", Offset = "0x8570DB0", VA = "0x188571FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static float ARWVOPQWQEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8574B10", Offset = "0x8573910", VA = "0x188574B10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8574700", Offset = "0x8573500", VA = "0x188574700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85733A0", Offset = "0x85721A0", VA = "0x1885733A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static LZEYQUPSRUQ GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8572390", Offset = "0x8571190", VA = "0x188572390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static ABWHXVJVLPE AOUAOBTSYDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8572410", Offset = "0x8571210", VA = "0x188572410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LZEYQUPSRUQ FFTPZTDYYMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8574470", Offset = "0x8573270", VA = "0x188574470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static RBETLIDWDVR TRVLDQDOWHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x85731A0", Offset = "0x8571FA0", VA = "0x1885731A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static int DAKOSDDBMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8574900", Offset = "0x8573700", VA = "0x188574900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static int JBVUXQRHUMM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8573FF0", Offset = "0x8572DF0", VA = "0x188573FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static int FRGAMLCORDW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8573D00", Offset = "0x8572B00", VA = "0x188573D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static string FSRDKZBWKGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8573B90", Offset = "0x8572990", VA = "0x188573B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static long JOEXIQXLLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8574880", Offset = "0x8573680", VA = "0x188574880")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static long FEFDZBSAJUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8573630", Offset = "0x8572430", VA = "0x188573630")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool VMCSTYVXSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8571EB0", Offset = "0x8570CB0", VA = "0x188571EB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8574EE0", Offset = "0x8573CE0", VA = "0x188574EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static string WZZMESFVGKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8573D80", Offset = "0x8572B80", VA = "0x188573D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8574E00", Offset = "0x8573C00", VA = "0x188574E00")]
		public static Access XYQWLGKBCJA(GWWSLAWLITR a)
		{
			return default(Access);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8573420", Offset = "0x8572220", VA = "0x188573420")]
		public static void LGEYGQSSLTY(IXHWWEEMCTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8573030", Offset = "0x8571E30", VA = "0x188573030")]
		public static object IRBAMTSNTRG(PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8572890", Offset = "0x8571690", VA = "0x188572890")]
		public static GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8572740", Offset = "0x8571540", VA = "0x188572740")]
		public static GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8572A20", Offset = "0x8571820", VA = "0x188572A20")]
		public static GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, ViewId d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8572B20", Offset = "0x8571920", VA = "0x188572B20")]
		public static GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, float d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8572D60", Offset = "0x8571B60", VA = "0x188572D60")]
		public static GameObject IOOWYHLTAIR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8572EB0", Offset = "0x8571CB0", VA = "0x188572EB0")]
		public static GameObject IOOWYHLTAIR(string a, Vector3 b, Quaternion c, [Optional] object[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8573490", Offset = "0x8572290", VA = "0x188573490")]
		public static GameObject LMUCMCSXYVG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8572C70", Offset = "0x8571A70", VA = "0x188572C70")]
		public static GameObject IGDGHRIOVOK(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8573120", Offset = "0x8571F20", VA = "0x188573120")]
		public static void IWPYUJCCEQH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8574A00", Offset = "0x8573800", VA = "0x188574A00")]
		public static void UOCWQHRVDDA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85738F0", Offset = "0x85726F0", VA = "0x1885738F0")]
		public static GameObject MHEPKCBHMWZ(string a, Vector3 b, Quaternion c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8573990", Offset = "0x8572790", VA = "0x188573990")]
		public static GameObject MHEPKCBHMWZ(string a, Vector3 b, Quaternion c, float d = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85736B0", Offset = "0x85724B0", VA = "0x1885736B0")]
		public static GameObject MHEPKCBHMWZ(string a, Vector3 b, Quaternion c, float d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8573DE0", Offset = "0x8572BE0", VA = "0x188573DE0")]
		public static GameObject[] OMTWEHZEBKE(IList<HWBSQPITHTV> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8572130", Offset = "0x8570F30", VA = "0x188572130")]
		public static void CXUENFZHRBZ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8573C80", Offset = "0x8572A80", VA = "0x188573C80")]
		public static void NRVHMNAFHTM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85726C0", Offset = "0x85714C0", VA = "0x1885726C0")]
		public static void HRNZTBZXOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8572030", Offset = "0x8570E30", VA = "0x188572030")]
		public static float COWRICCYMWV(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8574290", Offset = "0x8573090", VA = "0x188574290")]
		public static LZEYQUPSRUQ RMOHZMDEGFK(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8574100", Offset = "0x8572F00", VA = "0x188574100")]
		public static LZEYQUPSRUQ QZOOCSSOTEG(int a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8575230", Offset = "0x8574030", VA = "0x188575230")]
		public static LZEYQUPSRUQ ZVRIZSNDDOY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85744F0", Offset = "0x85732F0", VA = "0x1885744F0")]
		public static IReadOnlyList<LZEYQUPSRUQ> SLZEQDKDLFW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8574070", Offset = "0x8572E70", VA = "0x188574070")]
		public static IReadOnlyList<LZEYQUPSRUQ> QIDBEPWWMTZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85741A0", Offset = "0x8572FA0", VA = "0x1885741A0")]
		public static void RDPPNQPWMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8573220", Offset = "0x8572020", VA = "0x188573220")]
		public static bool KFGVJADWQCY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8574C00", Offset = "0x8573A00", VA = "0x188574C00")]
		public static bool XEXQTEGNXOE(LZEYQUPSRUQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8574330", Offset = "0x8573130", VA = "0x188574330")]
		public static bool RaiseEvent(byte eventCode, object eventContent, ZPXXLQJTGDJ raiseEventOptions, RRNetworkDelivery sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8574D80", Offset = "0x8573B80", VA = "0x188574D80")]
		public static void XTENLXJOVMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85724C0", Offset = "0x85712C0", VA = "0x1885724C0")]
		public static void HPFTFJWMZQX(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8572210", Offset = "0x8571010", VA = "0x188572210")]
		public static object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85725C0", Offset = "0x85713C0", VA = "0x1885725C0")]
		public static int HPXBGWAUHLR(PQDMMRYYGHS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8572310", Offset = "0x8571110", VA = "0x188572310")]
		public static void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8574580", Offset = "0x8573380", VA = "0x188574580")]
		public static void TCGAFZPNYYG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8573320", Offset = "0x8572120", VA = "0x188573320")]
		public static int KZONMQEIIDP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8574980", Offset = "0x8573780", VA = "0x188574980")]
		public static void UHQVXUXJQUL(RZNZAUAZENO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85732A0", Offset = "0x85720A0", VA = "0x1885732A0")]
		public static void KINGHORNEEH(QXSZZHJGVNS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8574780", Offset = "0x8573580", VA = "0x188574780")]
		public static string TVTZGRBPFPX(PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8574FE0", Offset = "0x8573DE0", VA = "0x188574FE0")]
		public static void YMGTTEPZWOG(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8575110", Offset = "0x8573F10", VA = "0x188575110")]
		public static void YMGTTEPZWOG(ViewId a, string b, LZEYQUPSRUQ c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8573AA0", Offset = "0x85728A0", VA = "0x188573AA0")]
		public static void NGVUUBCWLUC(ViewId a)
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
