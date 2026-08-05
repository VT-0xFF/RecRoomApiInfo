using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GCLGKPAJPCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KPBAMEHOHOC<T> : FECCOICHHJP, global::AJDJDHGLIEC<T>, PEMDLLFJFDM where T : class, DFBGLPCFOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B000", Offset = "0x2D9A200", VA = "0x182D9B000")]
			internal KPBAMEHOHOC(int IHNFPDPBACE, float[] IDAOOOBLJBG, CFAIMOIFJJF KFEHNMELNCO = CFAIMOIFJJF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AF30", Offset = "0x2D9A130", VA = "0x182D9AF30", Slot = "15")]
			public void CPCILMEHKPA(T ICHBECDKHOJ, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AF00", Offset = "0x2D9A100", VA = "0x182D9AF00", Slot = "16")]
			public void CPCILMEHKPA(T ICHBECDKHOJ, Transform LKHNIDJAMCA, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AFE0", Offset = "0x2D9A1E0", VA = "0x182D9AFE0", Slot = "17")]
			public void PPNODFFOFGD(T ICHBECDKHOJ, [Optional] float? NNLEGJGIGHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AF80", Offset = "0x2D9A180", VA = "0x182D9AF80", Slot = "18")]
			public void MILDLLFOGOM(T GOINOPMKPDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AFA0", Offset = "0x2D9A1A0", VA = "0x182D9AFA0", Slot = "19")]
			public AMBBOEBJPNH NOBCIHFNGCH(T ICHBECDKHOJ)
			{
				return default(AMBBOEBJPNH);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AFC0", Offset = "0x2D9A1C0", VA = "0x182D9AFC0", Slot = "20")]
			public bool OMBHCPANOCL(T ICHBECDKHOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AF60", Offset = "0x2D9A160", VA = "0x182D9AF60", Slot = "21")]
			public void IPFKHECOFDN(T ICHBECDKHOJ, HOHEMHOGNPJ CPOGMHGKBPB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class FECCOICHHJP : IDisposable, PEMDLLFJFDM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CFAIMOIFJJF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JNCBAGEIOEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public DFBGLPCFOHL EBCMHCLDAJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public HOHEMHOGNPJ HOENFBPFACD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action JPJGNINFEPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HJLGKGPBFHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int BCGMDEIHEMI;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public JNCBAGEIOEP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DLJKPLFKCJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public FECCOICHHJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JNCBAGEIOEP trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public DLJKPLFKCJI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OFAGKOBMGFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int IHNFPDPBACE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MMLIEOIKGGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CAPGEKKMIBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup OKEJBDKIECP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] HNGDHGAHFOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] KHEGCNCKLGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly BBMMMNJIDIF FPLPHBFOJPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<DFBGLPCFOHL, int> KEDIKKPFIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, JNCBAGEIOEP> CAHHBGLPLAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly CFAIMOIFJJF KFEHNMELNCO;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int HDDGHKJOJDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OBFAIFKBINK
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x678D290", Offset = "0x678C490", VA = "0x18678D290")]
			internal FECCOICHHJP(int IHNFPDPBACE, float[] IDAOOOBLJBG, CFAIMOIFJJF KFEHNMELNCO = CFAIMOIFJJF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x678CF80", Offset = "0x678C180", VA = "0x18678CF80")]
			public void OCJNGDPIACL(bool AEINBIKHGME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x678CDA0", Offset = "0x678BFA0", VA = "0x18678CDA0", Slot = "7")]
			public AMBBOEBJPNH OANKBGNEFLM(float DAMOGGANOJL)
			{
				return default(AMBBOEBJPNH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x678B680", Offset = "0x678A880", VA = "0x18678B680", Slot = "8")]
			public void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x678B230", Offset = "0x678A430", VA = "0x18678B230", Slot = "9")]
			public void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, Transform LKHNIDJAMCA, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x678C2D0", Offset = "0x678B4D0", VA = "0x18678C2D0")]
			public void JFIFODLPMGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x678D210", Offset = "0x678C410", VA = "0x18678D210", Slot = "10")]
			public void PPNODFFOFGD(DFBGLPCFOHL ICHBECDKHOJ, [Optional] float? NNLEGJGIGHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x678D0B0", Offset = "0x678C2B0", VA = "0x18678D0B0")]
			private void PNEHBBJNGLK(int GMEHLIHLGEH, [Optional] float? NNLEGJGIGHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x678C860", Offset = "0x678BA60", VA = "0x18678C860", Slot = "11")]
			public void MILDLLFOGOM(DFBGLPCFOHL GOINOPMKPDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x678CC90", Offset = "0x678BE90", VA = "0x18678CC90", Slot = "12")]
			public AMBBOEBJPNH NOBCIHFNGCH(DFBGLPCFOHL ICHBECDKHOJ)
			{
				return default(AMBBOEBJPNH);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x678CFB0", Offset = "0x678C1B0", VA = "0x18678CFB0", Slot = "13")]
			public bool OMBHCPANOCL(DFBGLPCFOHL ICHBECDKHOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x678C170", Offset = "0x678B370", VA = "0x18678C170", Slot = "14")]
			public void IPFKHECOFDN(DFBGLPCFOHL ICHBECDKHOJ, HOHEMHOGNPJ GOIMCDFCDAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x678B710", Offset = "0x678A910", VA = "0x18678B710", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x678B9F0", Offset = "0x678ABF0", VA = "0x18678B9F0")]
			private void GLGDIBGDKNP(JNCBAGEIOEP NLINJLKCAPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x678C450", Offset = "0x678B650", VA = "0x18678C450")]
			private void KAGOGDCBNML(JNCBAGEIOEP NLINJLKCAPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x678C260", Offset = "0x678B460", VA = "0x18678C260")]
			private void JBLAKJCHDAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x678C100", Offset = "0x678B300", VA = "0x18678C100")]
			private void HPKIPJGAJDO(float OKBAJEAPIHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x678B9B0", Offset = "0x678ABB0", VA = "0x18678B9B0")]
			private void FFAHGGIGNEC(JNCBAGEIOEP NLINJLKCAPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x678BDB0", Offset = "0x678AFB0", VA = "0x18678BDB0")]
			private void HADBNNANGFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x678B9E0", Offset = "0x678ABE0", VA = "0x18678B9E0")]
			private void GBNCOLMJCCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x678BDC0", Offset = "0x678AFC0", VA = "0x18678BDC0")]
			private void HDICEMOIINM(CullingGroupEvent EELBHNDMHFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x678C6E0", Offset = "0x678B8E0", VA = "0x18678C6E0")]
			private void KIEOJNNJPKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct PDNDANNGDAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort CGMJJFHNPKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type KFBLNHAJOKP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float FOGAAEEOJNC = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GAGHLBNMCCL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JACLKBDACMK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CFGNMGDJIJD = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float AEOHPBKFDAI = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FIJMNOKFGID = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KEAKGGNLENG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<PDNDANNGDAO, FECCOICHHJP> CNMHLFPNHDB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IPCNKHCGLOL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LBFNBKBMLNC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EEANDDJEMJC ANODCCMPOLP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EEANDDJEMJC KGJABDFJJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EEANDDJEMJC NIBKHEKMJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EEANDDJEMJC KECKFEPNCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EEANDDJEMJC AHBPMNLNHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LKGILLBEJEK NMAANJENEKB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool AEINBIKHGME;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EEANDDJEMJC FLJMPPMFMAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EEANDDJEMJC OGDFKPPJLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EEANDDJEMJC EJHBIMNDPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LLGODCJBPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCF11C0", Offset = "0xCF03C0", VA = "0x180CF11C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FFEOJACGMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6789FE0", Offset = "0x67891E0", VA = "0x186789FE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB8F30", Offset = "0xAB8130", VA = "0x180AB8F30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x678A8C0", Offset = "0x6789AC0", VA = "0x18678A8C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x678A780", Offset = "0x6789980", VA = "0x18678A780")]
		private void NNAKELHEGML(Scene FEGPGPHCDJD, LoadSceneMode DNLPIHIBJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x678A7E0", Offset = "0x67899E0", VA = "0x18678A7E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x678ACB0", Offset = "0x6789EB0", VA = "0x18678ACB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x678A0B0", Offset = "0x67892B0", VA = "0x18678A0B0")]
		private void CKAOGCKMNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x678AA80", Offset = "0x6789C80", VA = "0x18678AA80")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x678A5E0", Offset = "0x67897E0", VA = "0x18678A5E0")]
		private void JCNPOOAAPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x678A3F0", Offset = "0x67895F0", VA = "0x18678A3F0")]
		public PEMDLLFJFDM GetOrCreateCullingGroup(Type FIKJAPMHNHC, int IFCKEKJGHOM, ushort ALOFPFCGKHP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1169900", Offset = "0x1168B00", VA = "0x181169900")]
		public global::AJDJDHGLIEC<T> GetOrCreateCullingGroup<T>(int IFCKEKJGHOM, ushort ALOFPFCGKHP = 0) where T : class, DFBGLPCFOHL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x678A8E0", Offset = "0x6789AE0", VA = "0x18678A8E0")]
		private PEMDLLFJFDM PELEBHNNNPD(Type FIKJAPMHNHC, int IFCKEKJGHOM, float[] IDAOOOBLJBG, ushort ALOFPFCGKHP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x11699B0", Offset = "0x1168BB0", VA = "0x1811699B0")]
		private global::AJDJDHGLIEC<T> PELEBHNNNPD<T>(int IFCKEKJGHOM, float[] IDAOOOBLJBG, ushort ALOFPFCGKHP = 0) where T : class, DFBGLPCFOHL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x678A250", Offset = "0x6789450", VA = "0x18678A250")]
		public static AMBBOEBJPNH FindClosestDefaultUpdateLod(float LLJADPADOGD)
		{
			return default(AMBBOEBJPNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x678A770", Offset = "0x6789970", VA = "0x18678A770")]
		public static AMBBOEBJPNH MinUpdateLod(AMBBOEBJPNH COKIIHKAFIL, AMBBOEBJPNH NBEDBLMFEMD)
		{
			return default(AMBBOEBJPNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x678A760", Offset = "0x6789960", VA = "0x18678A760")]
		public static AMBBOEBJPNH MaxUpdateLod(AMBBOEBJPNH COKIIHKAFIL, AMBBOEBJPNH NBEDBLMFEMD)
		{
			return default(AMBBOEBJPNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x678B0E0", Offset = "0x678A2E0", VA = "0x18678B0E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BBMMMNJIDIF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KAEMHJMFCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera OAAMDFAHDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EEANDDJEMJC NIHJFCNDLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BJCNHNPOKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EEANDDJEMJC BCNHEAMFPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform PKOBBMPIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PEMDLLFJFDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int HDDGHKJOJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int OBFAIFKBINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMBBOEBJPNH OANKBGNEFLM(float DAMOGGANOJL);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPCILMEHKPA(DFBGLPCFOHL ICHBECDKHOJ, Transform LKHNIDJAMCA, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPNODFFOFGD(DFBGLPCFOHL ICHBECDKHOJ, [Optional] float? NNLEGJGIGHA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MILDLLFOGOM(DFBGLPCFOHL GOINOPMKPDD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AMBBOEBJPNH NOBCIHFNGCH(DFBGLPCFOHL ICHBECDKHOJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OMBHCPANOCL(DFBGLPCFOHL ICHBECDKHOJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPFKHECOFDN(DFBGLPCFOHL ICHBECDKHOJ, HOHEMHOGNPJ CPOGMHGKBPB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AJDJDHGLIEC<T> : PEMDLLFJFDM where T : class, DFBGLPCFOHL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCILMEHKPA(T ICHBECDKHOJ, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPCILMEHKPA(T ICHBECDKHOJ, Transform LKHNIDJAMCA, float NNLEGJGIGHA, HOHEMHOGNPJ OOPMGGPMMEJ = HOHEMHOGNPJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPNODFFOFGD(T ICHBECDKHOJ, [Optional] float? NNLEGJGIGHA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MILDLLFOGOM(T GOINOPMKPDD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AMBBOEBJPNH NOBCIHFNGCH(T ICHBECDKHOJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OMBHCPANOCL(T ICHBECDKHOJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPFKHECOFDN(T ICHBECDKHOJ, HOHEMHOGNPJ CPOGMHGKBPB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DFBGLPCFOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform FGNGGLFNLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AMBBOEBJPNH MOCEBLJHGPF, AMBBOEBJPNH ELOPMNNDIJD);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GMEKKCPLMOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HOHEMHOGNPJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum AMBBOEBJPNH
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OPMMJFMKGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private AMBBOEBJPNH IFPPBNLHCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private AMBBOEBJPNH LIODLDNGDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, AMBBOEBJPNH> ENBAHPHMLGG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OGFHDNBGHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x678DE40", Offset = "0x678D040", VA = "0x18678DE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AMBBOEBJPNH INAHKPODGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		get
		{
			return default(AMBBOEBJPNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AMBBOEBJPNH ANHBFKMKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4830", Offset = "0x7E3A30", VA = "0x1807E4830")]
		get
		{
			return default(AMBBOEBJPNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x678DE90", Offset = "0x678D090", VA = "0x18678DE90")]
	public bool NBGMFEOMHDO(object IALNODEHBNN, AMBBOEBJPNH IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x678DC80", Offset = "0x678CE80", VA = "0x18678DC80")]
	public bool GDINGAPJGOI(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x678DCE0", Offset = "0x678CEE0", VA = "0x18678DCE0")]
	private bool KGNGIFPAMBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x678DF00", Offset = "0x678D100", VA = "0x18678DF00")]
	public OPMMJFMKGMJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x678D650", Offset = "0x678C850", VA = "0x18678D650")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x678D760", Offset = "0x678C960", VA = "0x18678D760")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
