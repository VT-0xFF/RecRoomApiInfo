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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PCJIKCJIJJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class KOKCELOBDJC : IDisposable, JDLHCPOKAHF
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int EFBOAFOEPGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int HGONHBOLPHN
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void IFBGKKJHEHM(bool CDHLBLFFAHC);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			protected KOKCELOBDJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MBOCCJCAIBE<T> : KOKCELOBDJC, global::GGEPEGACIKI<T>, JDLHCPOKAHF where T : PNDJAENMEIN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum JDMPILGLECI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MEBHNHFBLLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T BGFJACPCLAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BNHIOCOBBHO EJNDFGNDEEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action JEHHILMJEED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool ICLIFLBGCIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int EEKKOADMDBE;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
				public MEBHNHFBLLI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class ECMLKNADAIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public MBOCCJCAIBE<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public MEBHNHFBLLI trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
				public ECMLKNADAIA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int PEKFDAIEGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NABDOIMCJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FGLBCIFPDGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LKPHLDJGJIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup CKPFFHPIKGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] LBNOFECLJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] JGMPKDIJCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly FHLGAHPNHOO BILBKIHPPNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> FIHICHKKCBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, MEBHNHFBLLI> LKBOCBFDILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly JDMPILGLECI JCNNOONEHHC;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int EFBOAFOEPGK
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x552ED0", Offset = "0x5522D0", VA = "0x180552ED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int HGONHBOLPHN
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575B10", VA = "0x180576710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1C24560", Offset = "0x1C23960", VA = "0x181C24560")]
			internal MBOCCJCAIBE(int NABDOIMCJNE, float[] JAPKHDLNGHP, JDMPILGLECI JCNNOONEHHC = JDMPILGLECI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1C23380", Offset = "0x1C22780", VA = "0x181C23380", Slot = "10")]
			public override void IFBGKKJHEHM(bool CDHLBLFFAHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C23A10", Offset = "0x1C22E10", VA = "0x181C23A10", Slot = "11")]
			public KIFDNECAOFC KCAOBLNNGLK(float IODDPDAIDMG)
			{
				return default(KIFDNECAOFC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1C23EF0", Offset = "0x1C232F0", VA = "0x181C23EF0", Slot = "12")]
			public void KCLLGEJMGAB(T CMGFKLKICHP, float OGILOGLJGHE, BNHIOCOBBHO BLODNCLOMHL = BNHIOCOBBHO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1C23A70", Offset = "0x1C22E70", VA = "0x181C23A70", Slot = "13")]
			public void KCLLGEJMGAB(T CMGFKLKICHP, Transform IGBFBGBBKJB, float OGILOGLJGHE, BNHIOCOBBHO BLODNCLOMHL = BNHIOCOBBHO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1C23990", Offset = "0x1C22D90", VA = "0x181C23990", Slot = "14")]
			public void JJDPBKHPMGG(T CMGFKLKICHP, [Optional] float? OGILOGLJGHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1C24210", Offset = "0x1C23610", VA = "0x181C24210")]
			private void LDLHPDNEBDI(int DBFCFFLFJDL, [Optional] float? OGILOGLJGHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1C22BA0", Offset = "0x1C21FA0", VA = "0x181C22BA0", Slot = "15")]
			public void EPGMMIBEDJL(T MLJIHBBOBMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1C23870", Offset = "0x1C22C70", VA = "0x181C23870", Slot = "16")]
			public KIFDNECAOFC JGMNALGHMGG(T CMGFKLKICHP)
			{
				return default(KIFDNECAOFC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1C22FB0", Offset = "0x1C223B0", VA = "0x181C22FB0", Slot = "17")]
			public bool FJJIHHJNJCE(T CMGFKLKICHP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1C233B0", Offset = "0x1C227B0", VA = "0x181C233B0", Slot = "18")]
			public void JBAHPGGMDLJ(T CMGFKLKICHP, BNHIOCOBBHO BCEHCMGLPFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1C22820", Offset = "0x1C21C20", VA = "0x181C22820", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1C234C0", Offset = "0x1C228C0", VA = "0x181C234C0")]
			private void JBLIAEAADDB(MEBHNHFBLLI KBLIFFGGNAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1C23F90", Offset = "0x1C23390", VA = "0x181C23F90")]
			private void KHKIODJALNF(MEBHNHFBLLI KBLIFFGGNAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1C24380", Offset = "0x1C23780", VA = "0x181C24380")]
			private void MNAGDKGGCDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1C22F40", Offset = "0x1C22340", VA = "0x181C22F40")]
			private void FGGHDEDJFBI(float IFJKCELAFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1C227B0", Offset = "0x1C21BB0", VA = "0x181C227B0")]
			private void BKJHPEFNHAH(MEBHNHFBLLI KBLIFFGGNAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1C23360", Offset = "0x1C22760", VA = "0x181C23360")]
			private void IAMMGNDEKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1C227F0", Offset = "0x1C21BF0", VA = "0x181C227F0")]
			private void BPGDLIIIOPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1C230B0", Offset = "0x1C224B0", VA = "0x181C230B0")]
			private void GCMOOMAJLCG(CullingGroupEvent DIJOFIFMLKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1C243F0", Offset = "0x1C237F0", VA = "0x181C243F0")]
			private void PCEHKNIMJGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct KEOMMNJMFPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort CFMMCELCBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type JMHBPNJLJID;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CHMDIEKLPEH = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float APJJDCKMODB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GKLPBOGBBEF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float ENEGGJOMGIL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IJLKANFJOKE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IBPNCNOMAMB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float DGGKFLHOEHP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<KEOMMNJMFPD, KOKCELOBDJC> BLBGIPKJMKP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable GLPOMLILKMB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LPMAECALNMK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CDMOJAPFDMP AAPCHOGCFPP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CDMOJAPFDMP CDKKFFNEBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CDMOJAPFDMP MBHNOFOEMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CDMOJAPFDMP JCANFNODCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CDMOJAPFDMP CJDKFKCMBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BHFIPLDLAEJ BKOHNDBGGAP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CDHLBLFFAHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CDMOJAPFDMP ANDCDIFAJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CDMOJAPFDMP IOCFJEKGPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CDMOJAPFDMP PELPMCACCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CDKPNABJCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x152B420", Offset = "0x152A820", VA = "0x18152B420", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ADOKNHFGLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A9C20", Offset = "0x7A9020", VA = "0x1807A9C20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7A9CA0", Offset = "0x7A90A0", VA = "0x1807A9CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4DA01C0", Offset = "0x4D9F5C0", VA = "0x184DA01C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE4CF10", Offset = "0xE4C310", VA = "0x180E4CF10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0920", Offset = "0x4D9FD20", VA = "0x184DA0920")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA05F0", Offset = "0x4D9F9F0", VA = "0x184DA05F0")]
		private void IGLMMMPIJLK(Scene GEHDPDFFHKF, LoadSceneMode IHAPPEONNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0870", Offset = "0x4D9FC70", VA = "0x184DA0870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0260", Offset = "0x4D9F660", VA = "0x184DA0260")]
		private void BJJLEHIMAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0940", Offset = "0x4D9FD40", VA = "0x184DA0940")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0650", Offset = "0x4D9FA50", VA = "0x184DA0650")]
		private void JHIIABDEIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1800", Offset = "0x1FC0C00", VA = "0x181FC1800")]
		public global::GGEPEGACIKI<T> GetOrCreateCullingGroup<T>(int AHDOGNBIMOB, ushort FFFIIGDJJAH = 0) where T : PNDJAENMEIN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1FC18B0", Offset = "0x1FC0CB0", VA = "0x181FC18B0")]
		private global::GGEPEGACIKI<T> NIMLFHDEDJD<T>(int AHDOGNBIMOB, float[] JAPKHDLNGHP, ushort FFFIIGDJJAH = 0) where T : PNDJAENMEIN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0400", Offset = "0x4D9F800", VA = "0x184DA0400")]
		public static KIFDNECAOFC FindClosestDefaultUpdateLod(float AGGFGANOPGC)
		{
			return default(KIFDNECAOFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0810", Offset = "0x4D9FC10", VA = "0x184DA0810")]
		public static KIFDNECAOFC MinUpdateLod(KIFDNECAOFC PPICJBCAMGL, KIFDNECAOFC DLNLFIIBBHI)
		{
			return default(KIFDNECAOFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4DA07B0", Offset = "0x4D9FBB0", VA = "0x184DA07B0")]
		public static KIFDNECAOFC MaxUpdateLod(KIFDNECAOFC PPICJBCAMGL, KIFDNECAOFC DLNLFIIBBHI)
		{
			return default(KIFDNECAOFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0CD0", Offset = "0x4DA00D0", VA = "0x184DA0CD0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FHLGAHPNHOO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GHAEFAJLLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera GKFJGOJCOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CDMOJAPFDMP FMMCNNIDNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JMHDCJGNFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CDMOJAPFDMP NJFHHDAGJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform EIBLGBLNMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JDLHCPOKAHF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int EFBOAFOEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int HGONHBOLPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GGEPEGACIKI<T> : JDLHCPOKAHF where T : PNDJAENMEIN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIFDNECAOFC KCAOBLNNGLK(float IODDPDAIDMG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCLLGEJMGAB(T CMGFKLKICHP, float OGILOGLJGHE, BNHIOCOBBHO BLODNCLOMHL = BNHIOCOBBHO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCLLGEJMGAB(T CMGFKLKICHP, Transform IGBFBGBBKJB, float OGILOGLJGHE, BNHIOCOBBHO BLODNCLOMHL = BNHIOCOBBHO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJDPBKHPMGG(T CMGFKLKICHP, [Optional] float? OGILOGLJGHE);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPGMMIBEDJL(T MLJIHBBOBMH);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KIFDNECAOFC JGMNALGHMGG(T CMGFKLKICHP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FJJIHHJNJCE(T CMGFKLKICHP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBAHPGGMDLJ(T CMGFKLKICHP, BNHIOCOBBHO IALCPBBIFDI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PNDJAENMEIN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform HKHBBIBGMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KIFDNECAOFC PEFIOGGJILO, KIFDNECAOFC FKHAKCMADDL);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IEJEIBJHHJH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BNHIOCOBBHO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KIFDNECAOFC
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
public class EDFFDLGLMII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KIFDNECAOFC AANMGJFAJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private KIFDNECAOFC KFNCJNENKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, KIFDNECAOFC> CENFGINFJPP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JNFPCEKJIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0E20", Offset = "0x4DA0220", VA = "0x184DA0E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KIFDNECAOFC GFPJBCAFDII
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x552ED0", Offset = "0x5522D0", VA = "0x180552ED0")]
		get
		{
			return default(KIFDNECAOFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KIFDNECAOFC PLAPAONOLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575B10", VA = "0x180576710")]
		get
		{
			return default(KIFDNECAOFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0FE0", Offset = "0x4DA03E0", VA = "0x184DA0FE0")]
	public bool PGADOPELPNL(object ANBIAABLBGM, KIFDNECAOFC MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0DC0", Offset = "0x4DA01C0", VA = "0x184DA0DC0")]
	public bool CAAPKADMLNG(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0E70", Offset = "0x4DA0270", VA = "0x184DA0E70")]
	private bool DMOILMEBEMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1050", Offset = "0x4DA0450", VA = "0x184DA1050")]
	public EDFFDLGLMII()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4DA10D0", Offset = "0x4DA04D0", VA = "0x184DA10D0")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4DA11D0", Offset = "0x4DA05D0", VA = "0x184DA11D0")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
