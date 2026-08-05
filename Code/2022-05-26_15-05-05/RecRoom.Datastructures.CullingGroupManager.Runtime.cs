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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OILEMCJJFLI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class PPOILEEKMJH : IDisposable, MPINGIGFPAK
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int OCGGAKJFKJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int BJOMKMGKLHA
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
			public abstract void LPBIKDHGIJE(bool OBEGOLCILLI);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			protected PPOILEEKMJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GBNOBEIKIDM<T> : PPOILEEKMJH, global::MCGJMOJJLCM<T>, MPINGIGFPAK where T : LFLPBCCFHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ABOKDPPHJJC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FMJKOILNLLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T HPONHIJEDLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public LLPLNOLCMOF OEPLBPDPDPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action MAFGGBOFLEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool COODJBAOKKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int OOODCJOIDPB;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
				public FMJKOILNLLL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class ILOLGLGHICI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public GBNOBEIKIDM<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public FMJKOILNLLL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
				public ILOLGLGHICI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LGMBKONKKMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int BHCANDMNPGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GDOOAMMGBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool PGGNJMMOIKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup JLFIAKCBMNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] LDFKBDKAJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] BKLFLKHNMCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly NENEGLLGPKB PJEAKFPHIGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> KPONONAOGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, FMJKOILNLLL> NDEDEJPOMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly ABOKDPPHJJC IGAHBKEJGLD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int OCGGAKJFKJA
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int BJOMKMGKLHA
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x584710", Offset = "0x582D10", VA = "0x180584710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E31AA0", Offset = "0x1E300A0", VA = "0x181E31AA0")]
			internal GBNOBEIKIDM(int BHCANDMNPGA, float[] NGNJCDNJBNE, ABOKDPPHJJC IGAHBKEJGLD = ABOKDPPHJJC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E30C30", Offset = "0x1E2F230", VA = "0x181E30C30", Slot = "10")]
			public override void LPBIKDHGIJE(bool OBEGOLCILLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E30400", Offset = "0x1E2EA00", VA = "0x181E30400", Slot = "11")]
			public BPMBKPKAHEP ECLMKFLNBCC(float GBFDJDBPAGK)
			{
				return default(BPMBKPKAHEP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E31000", Offset = "0x1E2F600", VA = "0x181E31000", Slot = "12")]
			public void NENJMCKJAJO(T FIEDOLNFNLH, float FFNJBOPKDOO, LLPLNOLCMOF OGPLJIFAFON = LLPLNOLCMOF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1E310A0", Offset = "0x1E2F6A0", VA = "0x181E310A0", Slot = "13")]
			public void NENJMCKJAJO(T FIEDOLNFNLH, Transform JBAEOCKFOGN, float FFNJBOPKDOO, LLPLNOLCMOF OGPLJIFAFON = LLPLNOLCMOF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E309F0", Offset = "0x1E2EFF0", VA = "0x181E309F0", Slot = "14")]
			public void IBBHHJNLOOP(T FIEDOLNFNLH, [Optional] float? FFNJBOPKDOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1E30AA0", Offset = "0x1E2F0A0", VA = "0x181E30AA0")]
			private void KBHIFOBBNMM(int HOOANEAGKNH, [Optional] float? FFNJBOPKDOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E30C60", Offset = "0x1E2F260", VA = "0x181E30C60", Slot = "15")]
			public void MNHCGCIEOKP(T JKAKODDGKKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E31730", Offset = "0x1E2FD30", VA = "0x181E31730", Slot = "16")]
			public BPMBKPKAHEP OACAOANMBGG(T FIEDOLNFNLH)
			{
				return default(BPMBKPKAHEP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E31630", Offset = "0x1E2FC30", VA = "0x181E31630", Slot = "17")]
			public bool NOJCPABHHFE(T FIEDOLNFNLH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E31520", Offset = "0x1E2FB20", VA = "0x181E31520", Slot = "18")]
			public void NHOKCOOOJDA(T FIEDOLNFNLH, LLPLNOLCMOF FGJOHBBBLMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E30080", Offset = "0x1E2E680", VA = "0x181E30080", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1E2FCD0", Offset = "0x1E2E2D0", VA = "0x181E2FCD0")]
			private void CHBMDDFKFLJ(FMJKOILNLLL CCMFEOCLGIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1E30770", Offset = "0x1E2ED70", VA = "0x181E30770")]
			private void EJDLLIFOJFG(FMJKOILNLLL CCMFEOCLGIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1E31A30", Offset = "0x1E30030", VA = "0x181E31A30")]
			private void PIOEDLHDFEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E31850", Offset = "0x1E2FE50", VA = "0x181E31850")]
			private void PALJBEKJING(float INLHJCFKACP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1E2FC90", Offset = "0x1E2E290", VA = "0x181E2FC90")]
			private void BPLPKHPPIDL(FMJKOILNLLL CCMFEOCLGIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E30C10", Offset = "0x1E2F210", VA = "0x181E30C10")]
			private void KKBJPGCIAMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1E30A70", Offset = "0x1E2F070", VA = "0x181E30A70")]
			private void IOAIELHDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1E30460", Offset = "0x1E2EA60", VA = "0x181E30460")]
			private void EFNOOFMOHPD(CullingGroupEvent KDJGANKJMOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1E318C0", Offset = "0x1E2FEC0", VA = "0x181E318C0")]
			private void PCKFPKFNMME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GHFDLEKKHBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort JOCKMBBMOBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type FMLPOJNAINE;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MMANIHLJCFO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KOJEMAEMIAP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MLNJGMJOKDB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DEMPJKIFPKP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LGIKMEFKBBF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DFJDMPCKEKC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float EJKNKIPGGPG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GHFDLEKKHBI, PPOILEEKMJH> HMPAMANIOLM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HBPPJMFKIBD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LGAJHCOMGKL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DMENMFODFLB IAOIMNMFGBK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DMENMFODFLB MMOLMAGJCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DMENMFODFLB EJCKOLIBKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DMENMFODFLB BDLPPGLHBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DMENMFODFLB OKFHMLMPMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JPGLPKCHKEM FJHOHPAFIKC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OBEGOLCILLI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DMENMFODFLB DEDCMMCNLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DMENMFODFLB FLDLIPFAHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DMENMFODFLB NLNOEIIBHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AHDPOHKLKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xEDD0C0", Offset = "0xEDB6C0", VA = "0x180EDD0C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KOOJCLMJNAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x795C20", Offset = "0x794220", VA = "0x180795C20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x795CA0", Offset = "0x7942A0", VA = "0x180795CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E681C0", Offset = "0x4E667C0", VA = "0x184E681C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD9BCB0", Offset = "0xD9A2B0", VA = "0x180D9BCB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4914820", Offset = "0x4912E20", VA = "0x184914820")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E68260", Offset = "0x4E66860", VA = "0x184E68260")]
		private void EPHNEJLIEPH(Scene ANPOPIHJJPD, LoadSceneMode EAPLEPGNBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E68870", Offset = "0x4E66E70", VA = "0x184E68870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E684B0", Offset = "0x4E66AB0", VA = "0x184E684B0")]
		private void GHKGHPDENGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E68920", Offset = "0x4E66F20", VA = "0x184E68920")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E68650", Offset = "0x4E66C50", VA = "0x184E68650")]
		private void LLNIFJECLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D90350", Offset = "0x1D8E950", VA = "0x181D90350")]
		public global::MCGJMOJJLCM<T> GetOrCreateCullingGroup<T>(int DGOKJCFBLMG, ushort GFOMKHMHDAL = 0) where T : LFLPBCCFHNJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1D90400", Offset = "0x1D8EA00", VA = "0x181D90400")]
		private global::MCGJMOJJLCM<T> LPIJOGPMBGM<T>(int DGOKJCFBLMG, float[] NGNJCDNJBNE, ushort GFOMKHMHDAL = 0) where T : LFLPBCCFHNJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4E682C0", Offset = "0x4E668C0", VA = "0x184E682C0")]
		public static BPMBKPKAHEP FindClosestDefaultUpdateLod(float IKHLJGBIPCI)
		{
			return default(BPMBKPKAHEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4E68810", Offset = "0x4E66E10", VA = "0x184E68810")]
		public static BPMBKPKAHEP MinUpdateLod(BPMBKPKAHEP JPPEOOFEBND, BPMBKPKAHEP HAHKPFGDIKE)
		{
			return default(BPMBKPKAHEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E687B0", Offset = "0x4E66DB0", VA = "0x184E687B0")]
		public static BPMBKPKAHEP MaxUpdateLod(BPMBKPKAHEP JPPEOOFEBND, BPMBKPKAHEP HAHKPFGDIKE)
		{
			return default(BPMBKPKAHEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E68CB0", Offset = "0x4E672B0", VA = "0x184E68CB0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NENEGLLGPKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IPCPKNNDGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera BNECNNMEALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DMENMFODFLB OCOLLDHDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BNKGADLEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DMENMFODFLB MNIKBMKEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KEHIJDPJFII
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MPINGIGFPAK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int OCGGAKJFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BJOMKMGKLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MCGJMOJJLCM<T> : MPINGIGFPAK where T : LFLPBCCFHNJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPMBKPKAHEP ECLMKFLNBCC(float GBFDJDBPAGK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NENJMCKJAJO(T FIEDOLNFNLH, float FFNJBOPKDOO, LLPLNOLCMOF OGPLJIFAFON = LLPLNOLCMOF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NENJMCKJAJO(T FIEDOLNFNLH, Transform JBAEOCKFOGN, float FFNJBOPKDOO, LLPLNOLCMOF OGPLJIFAFON = LLPLNOLCMOF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBBHHJNLOOP(T FIEDOLNFNLH, [Optional] float? FFNJBOPKDOO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNHCGCIEOKP(T JKAKODDGKKN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BPMBKPKAHEP OACAOANMBGG(T FIEDOLNFNLH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NOJCPABHHFE(T FIEDOLNFNLH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHOKCOOOJDA(T FIEDOLNFNLH, LLPLNOLCMOF KEKIEDGMOBF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LFLPBCCFHNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform JGOBGGHPFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(BPMBKPKAHEP DAMCPPPOBFG, BPMBKPKAHEP NIFLHKLJENA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool HFAAMFMLEIA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LLPLNOLCMOF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BPMBKPKAHEP
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
public class HADJCBCGFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BPMBKPKAHEP EEIGLGPCDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private BPMBKPKAHEP GPKLECHELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, BPMBKPKAHEP> FFECNJBKFBO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NJODEIMNIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E68F80", Offset = "0x4E67580", VA = "0x184E68F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BPMBKPKAHEP NOIOBGLECGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0")]
		get
		{
			return default(BPMBKPKAHEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BPMBKPKAHEP IJCLBCKONFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x584710", Offset = "0x582D10", VA = "0x180584710")]
		get
		{
			return default(BPMBKPKAHEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E68DA0", Offset = "0x4E673A0", VA = "0x184E68DA0")]
	public bool EMKENJFOCJF(object GJGFJFLAGKH, BPMBKPKAHEP MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E68FD0", Offset = "0x4E675D0", VA = "0x184E68FD0")]
	public bool OKFFAJCGNAA(object GJGFJFLAGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4E68E10", Offset = "0x4E67410", VA = "0x184E68E10")]
	private bool FKCMCOODOGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4E69030", Offset = "0x4E67630", VA = "0x184E69030")]
	public HADJCBCGFDI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4E690B0", Offset = "0x4E676B0", VA = "0x184E690B0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4E691B0", Offset = "0x4E677B0", VA = "0x184E691B0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
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
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
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
