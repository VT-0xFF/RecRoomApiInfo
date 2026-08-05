using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JGBKCLEEHBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class IBOCBECENKL<T> : NKCDPIDEPJF, NHLHFDHFFAI<T>, PHPGHNNPJHJ where T : class, HOEIBBBDECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x388F730", Offset = "0x388E730", VA = "0x18388F730")]
			internal IBOCBECENKL(int GHLGNDMIBLJ, float[] CHBJEJMBGLM, EHPBKPMNDLM MEGKBCGKBLG = EHPBKPMNDLM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x388F6B0", Offset = "0x388E6B0", VA = "0x18388F6B0", Slot = "10")]
			public void EMJMPPLJJNE(T FGOCJODIEMI, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x388F6E0", Offset = "0x388E6E0", VA = "0x18388F6E0", Slot = "11")]
			public void EMJMPPLJJNE(T FGOCJODIEMI, Transform CEMJDCLNCMP, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x388F710", Offset = "0x388E710", VA = "0x18388F710", Slot = "12")]
			public void JOBFLKKFIPF(T NJMJBMFLOAN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NKCDPIDEPJF : IDisposable, PHPGHNNPJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EHPBKPMNDLM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class DIAKPFHCIGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public HOEIBBBDECC EOPLLFAHMKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public FBEANLMFLHI FGADOJGLJIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action IHCCCPDIEMD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool NFJPBFNDCKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int EDPEAEGJAAB;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
				public DIAKPFHCIGP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class KICHLFFGAGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NKCDPIDEPJF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public DIAKPFHCIGP trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
				public KICHLFFGAGE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x615CD80", Offset = "0x615BD80", VA = "0x18615CD80")]
				internal void FMNPMIIBAKM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HFLMGNFLJKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GHLGNDMIBLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int JMKLOAGBDEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool HBKBODDFLFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup CGEGCGEDGFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] EGJILCHPOEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] OPOLGNDGEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly DPNKOPHNMCM HLIOAAOLCGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<HOEIBBBDECC, int> OHNCEMGDNJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, DIAKPFHCIGP> LIJPGKKKMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly EHPBKPMNDLM MEGKBCGKBLG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool EHOHEEPFMHC
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDE6EB0", Offset = "0xDE5EB0", VA = "0x180DE6EB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3F20BC0", Offset = "0x3F1FBC0", VA = "0x183F20BC0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x615EA70", Offset = "0x615DA70", VA = "0x18615EA70")]
			internal NKCDPIDEPJF(int GHLGNDMIBLJ, float[] CHBJEJMBGLM, EHPBKPMNDLM MEGKBCGKBLG = EHPBKPMNDLM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x615CED0", Offset = "0x615BED0", VA = "0x18615CED0")]
			public void AFAFNNBEKJP(bool FGFFDENLGJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x615D540", Offset = "0x615C540", VA = "0x18615D540", Slot = "6")]
			public void EMJMPPLJJNE(HOEIBBBDECC FGOCJODIEMI, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x615D5D0", Offset = "0x615C5D0", VA = "0x18615D5D0", Slot = "9")]
			public void EMJMPPLJJNE(HOEIBBBDECC FGOCJODIEMI, Transform CEMJDCLNCMP, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x615CF00", Offset = "0x615BF00", VA = "0x18615CF00")]
			public void CAHFEOKKGKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x615DA30", Offset = "0x615CA30", VA = "0x18615DA30")]
			private void HAIJFAIFIDL(int GCDIELAOHNA, [Optional] float? ELLOHCJLFKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x615DCD0", Offset = "0x615CCD0", VA = "0x18615DCD0", Slot = "7")]
			public void JOBFLKKFIPF(HOEIBBBDECC NJMJBMFLOAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x615D050", Offset = "0x615C050", VA = "0x18615D050", Slot = "8")]
			public void CHBMHPKCHDO(HOEIBBBDECC FGOCJODIEMI, FBEANLMFLHI JJKCDACAHIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x615D280", Offset = "0x615C280", VA = "0x18615D280", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x615E6E0", Offset = "0x615D6E0", VA = "0x18615E6E0")]
			private void ODILGMMDGFF(DIAKPFHCIGP HMLIJBOAEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x615E430", Offset = "0x615D430", VA = "0x18615E430")]
			private void NGKLFGPKHNC(DIAKPFHCIGP HMLIJBOAEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x615E3D0", Offset = "0x615D3D0", VA = "0x18615E3D0")]
			private void MPHCHLJIDNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x615D9D0", Offset = "0x615C9D0", VA = "0x18615D9D0")]
			private void FBHGMHDMNDJ(float HBFOIDKFIJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x615D140", Offset = "0x615C140", VA = "0x18615D140")]
			private void DFPEBCMJNNL(DIAKPFHCIGP HMLIJBOAEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x615D9C0", Offset = "0x615C9C0", VA = "0x18615D9C0")]
			private void EOGFBHPKKJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x615E6D0", Offset = "0x615D6D0", VA = "0x18615E6D0")]
			private void NPNOJAPABFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x615E0B0", Offset = "0x615D0B0", VA = "0x18615E0B0")]
			private void KFBJECCPCCL(CullingGroupEvent FOBKCPJOOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x615DB60", Offset = "0x615CB60", VA = "0x18615DB60")]
			private void HCBIBGALCFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JKBOPMHLBNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort COMOFOKNJCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NAHGBKFIOKK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LEIFHAAKOPN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ECHFOODPJKJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GOOJBOAFMFD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FMDHHAOBOCH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OLDKHEHCNOO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NFKEGGBPHCN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AKLMHGPLBPB = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JKBOPMHLBNM, NKCDPIDEPJF> AFOJHEJGGAE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable MMGLEFBAIPO;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GKFJJDHBKDO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LHMMLLGDOFK NCIFKHCDGEC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LHMMLLGDOFK IAJIANHADJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LHMMLLGDOFK FDOGFOGILCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LHMMLLGDOFK AEICCEGFLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LHMMLLGDOFK LOAPKKIJALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NEPNIBLDPPD GPFNKOJFPAC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool FGFFDENLGJJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LHMMLLGDOFK EOECOLMMEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LHMMLLGDOFK GAMDNCPCDFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LHMMLLGDOFK LJPPMEBBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OADHFKJAHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC2D6D0", Offset = "0xC2C6D0", VA = "0x180C2D6D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KLONFMGHMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x883B80", Offset = "0x882B80", VA = "0x180883B80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x967470", Offset = "0x966470", VA = "0x180967470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x615BB00", Offset = "0x615AB00", VA = "0x18615BB00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x615C430", Offset = "0x615B430", VA = "0x18615C430")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x615C410", Offset = "0x615B410", VA = "0x18615C410")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x615BBC0", Offset = "0x615ABC0", VA = "0x18615BBC0")]
		private void FOLJGMNFOBM(Scene HGCDECHKIOG, LoadSceneMode AHPNAMMDGCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x615C330", Offset = "0x615B330", VA = "0x18615C330", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x615C810", Offset = "0x615B810", VA = "0x18615C810")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x615C190", Offset = "0x615B190", VA = "0x18615C190")]
		private void NFJPDPPAKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x615C5D0", Offset = "0x615B5D0", VA = "0x18615C5D0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x615C450", Offset = "0x615B450", VA = "0x18615C450")]
		private void PACLLDJCGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x615BD80", Offset = "0x615AD80", VA = "0x18615BD80")]
		public PHPGHNNPJHJ GetOrCreateCullingGroup(Type LJBGIEFOCKF, int JEOCFGLNJGC, ushort EBADBADLAFO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x262D740", Offset = "0x262C740", VA = "0x18262D740")]
		public NHLHFDHFFAI<T> GetOrCreateCullingGroup<T>(int JEOCFGLNJGC, ushort EBADBADLAFO = 0) where T : class, HOEIBBBDECC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x615BFA0", Offset = "0x615AFA0", VA = "0x18615BFA0")]
		private PHPGHNNPJHJ INCMGFKOOMA(Type LJBGIEFOCKF, int JEOCFGLNJGC, float[] CHBJEJMBGLM, ushort EBADBADLAFO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x262D7E0", Offset = "0x262C7E0", VA = "0x18262D7E0")]
		private NHLHFDHFFAI<T> INCMGFKOOMA<T>(int JEOCFGLNJGC, float[] CHBJEJMBGLM, ushort EBADBADLAFO = 0) where T : class, HOEIBBBDECC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x615BC20", Offset = "0x615AC20", VA = "0x18615BC20")]
		public static GMBNNMLOONM FindClosestDefaultUpdateLod(float KEKIELBIHNF)
		{
			return default(GMBNNMLOONM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E8F60", Offset = "0x7E7F60", VA = "0x1807E8F60")]
		public static GMBNNMLOONM MinUpdateLod(GMBNNMLOONM JJNDMMBFJII, GMBNNMLOONM OFJKIPLJIII)
		{
			return default(GMBNNMLOONM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x615C180", Offset = "0x615B180", VA = "0x18615C180")]
		public static GMBNNMLOONM MaxUpdateLod(GMBNNMLOONM JJNDMMBFJII, GMBNNMLOONM OFJKIPLJIII)
		{
			return default(GMBNNMLOONM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x615CC80", Offset = "0x615BC80", VA = "0x18615CC80")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DPNKOPHNMCM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PIPPMHEJPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera NHJKILDEOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LHMMLLGDOFK BIAMJJPBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FDPPBLBHBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LHMMLLGDOFK JPADNKCAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform IHELEHPGABL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PHPGHNNPJHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EHOHEEPFMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMJMPPLJJNE(HOEIBBBDECC FGOCJODIEMI, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOBFLKKFIPF(HOEIBBBDECC NJMJBMFLOAN);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHBMHPKCHDO(HOEIBBBDECC FGOCJODIEMI, FBEANLMFLHI PLPHGGFIFKB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NHLHFDHFFAI<T> : PHPGHNNPJHJ where T : class, HOEIBBBDECC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMJMPPLJJNE(T FGOCJODIEMI, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMJMPPLJJNE(T FGOCJODIEMI, Transform CEMJDCLNCMP, float ELLOHCJLFKF, FBEANLMFLHI IOCPHDBNENO = FBEANLMFLHI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOBFLKKFIPF(T NJMJBMFLOAN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HOEIBBBDECC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NJKBLELAEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GMBNNMLOONM AJFLPFKLJHB, GMBNNMLOONM PHCMKGPCKNP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CELPKGDKFMH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FBEANLMFLHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GMBNNMLOONM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
