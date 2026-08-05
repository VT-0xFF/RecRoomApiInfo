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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, AGFHDCKDPDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class MNMBJHEIMCK : IDisposable, IHCABMBIODG
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int FIGLHDADEAB
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int BKJAAOOBEHH
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
			public abstract void GHCHHJOHAOL(bool IJCGFCKNHIA);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			protected MNMBJHEIMCK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NBOOEPNMFOH<T> : MNMBJHEIMCK, global::HELCMNOJFHO<T>, IHCABMBIODG where T : ICNNPDEKMPC
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum AOFLFOGDIPA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class CANBKKGOKPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T KIPFNEPNLEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public GMJDLCIMBKO BHNJIKBIEDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action LILHNIKIDII;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool FIEOCHFJAJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int LDLBNOKJCLF;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
				public CANBKKGOKPC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class EDHJKGNBKLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public NBOOEPNMFOH<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public CANBKKGOKPC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
				public EDHJKGNBKLI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int EMEDHFLIBPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int FDDEIKFEDNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OCMMJPKGCJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CKJDBNBCJDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup LGLNELBPPGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] LDNMCOEMONG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] EBEMBFDPLLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EDGDMPHGEDM NIFJNHPKINL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> MHNDOHPFKIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, CANBKKGOKPC> KBPHAEHPKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly AOFLFOGDIPA HPKLGAHFFPM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int FIGLHDADEAB
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x58DED0", Offset = "0x58CED0", VA = "0x18058DED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int BKJAAOOBEHH
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5B1710", Offset = "0x5B0710", VA = "0x1805B1710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E1D000", Offset = "0x1E1C000", VA = "0x181E1D000")]
			internal NBOOEPNMFOH(int FDDEIKFEDNH, float[] FMCABKCJDCE, AOFLFOGDIPA HPKLGAHFFPM = AOFLFOGDIPA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BF80", Offset = "0x1E1AF80", VA = "0x181E1BF80", Slot = "10")]
			public override void GHCHHJOHAOL(bool IJCGFCKNHIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B3A0", Offset = "0x1E1A3A0", VA = "0x181E1B3A0", Slot = "11")]
			public KMFELBKHOKO BHCNMBHIMFE(float HLPBMMEOGPJ)
			{
				return default(KMFELBKHOKO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B880", Offset = "0x1E1A880", VA = "0x181E1B880", Slot = "12")]
			public void CGEJAMCGIKA(T NHBCHHMAJOK, float LKNCALHCOKD, GMJDLCIMBKO INDLMLPIACB = GMJDLCIMBKO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B400", Offset = "0x1E1A400", VA = "0x181E1B400", Slot = "13")]
			public void CGEJAMCGIKA(T NHBCHHMAJOK, Transform PLPKGBCCJCK, float LKNCALHCOKD, GMJDLCIMBKO INDLMLPIACB = GMJDLCIMBKO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C020", Offset = "0x1E1B020", VA = "0x181E1C020", Slot = "14")]
			public void HNHCFEEEENF(T NHBCHHMAJOK, [Optional] float? LKNCALHCOKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BCE0", Offset = "0x1E1ACE0", VA = "0x181E1BCE0")]
			private void FLMMKNKPDAC(int GPNCGBOOKKF, [Optional] float? LKNCALHCOKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C450", Offset = "0x1E1B450", VA = "0x181E1C450", Slot = "15")]
			public void IDBFDJDECBI(T JHKJIJCDNMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B250", Offset = "0x1E1A250", VA = "0x181E1B250", Slot = "16")]
			public KMFELBKHOKO ABCLAFHFIGM(T NHBCHHMAJOK)
			{
				return default(KMFELBKHOKO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E1CF00", Offset = "0x1E1BF00", VA = "0x181E1CF00", Slot = "17")]
			public bool PNMPOIHHGCD(T NHBCHHMAJOK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BE70", Offset = "0x1E1AE70", VA = "0x181E1BE70", Slot = "18")]
			public void GGDNKBBBBCP(T NHBCHHMAJOK, GMJDLCIMBKO IAHPBNMCCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B920", Offset = "0x1E1A920", VA = "0x181E1B920", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C0A0", Offset = "0x1E1B0A0", VA = "0x181E1C0A0")]
			private void IAPECFPGDHI(CANBKKGOKPC JJFGCAHEEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1E1CC80", Offset = "0x1E1BC80", VA = "0x181E1CC80")]
			private void PMFPPMJOPOF(CANBKKGOKPC JJFGCAHEEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C7F0", Offset = "0x1E1B7F0", VA = "0x181E1C7F0")]
			private void KBGHAELGBNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BFB0", Offset = "0x1E1AFB0", VA = "0x181E1BFB0")]
			private void GMIFJCKIMBG(float CCNPELEKJHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BCA0", Offset = "0x1E1ACA0", VA = "0x181E1BCA0")]
			private void EMOCLPIMIHL(CANBKKGOKPC JJFGCAHEEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BE50", Offset = "0x1E1AE50", VA = "0x181E1BE50")]
			private void FOKIIEACKEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1E1B370", Offset = "0x1E1A370", VA = "0x181E1B370")]
			private void AJEBOHLBICO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C860", Offset = "0x1E1B860", VA = "0x181E1C860")]
			private void NNHOHBJMCDD(CullingGroupEvent IFHJINNOGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1E1CB10", Offset = "0x1E1BB10", VA = "0x181E1CB10")]
			private void OKEOCDFOCED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JJMAGGJDFAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort BDJGGFKCMBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type NGHMDMGCFNJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CHIKBOBNAFK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float FGAEGCIEJHN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LJDOGABHIFO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GDEPCFKNPMM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LENCIDLJECN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FGPFICBNNKC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float LNPDEHCMNOI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JJMAGGJDFAM, MNMBJHEIMCK> ODKDCDLGHKI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PEFPONOEPNJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HFKFCKLICCC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static KADOKFFMEKA HCCDFMGIHNO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KADOKFFMEKA CMPCCNHFJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KADOKFFMEKA CMJPIABADFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KADOKFFMEKA NDMNGNJDLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KADOKFFMEKA DOOLEEFNALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ELHLMKINOCP LGHKKKLCLKI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool IJCGFCKNHIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KADOKFFMEKA CGPCMNBCHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KADOKFFMEKA POONPJDINEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KADOKFFMEKA GPGDENDMCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ANDDNOCFENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x125F220", Offset = "0x125E220", VA = "0x18125F220", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BFEBFOCICLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77EB70", Offset = "0x77DB70", VA = "0x18077EB70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x77EBF0", Offset = "0x77DBF0", VA = "0x18077EBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51F1270", Offset = "0x51F0270", VA = "0x1851F1270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE2BD90", Offset = "0xE2AD90", VA = "0x180E2BD90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51F19D0", Offset = "0x51F09D0", VA = "0x1851F19D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51F1800", Offset = "0x51F0800", VA = "0x1851F1800")]
		private void KHLKMNOEMGO(Scene INPJNKKBKLA, LoadSceneMode PAMKEOLBJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51F1920", Offset = "0x51F0920", VA = "0x1851F1920", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51F1470", Offset = "0x51F0470", VA = "0x1851F1470")]
		private void DNOGKBGHGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51F19F0", Offset = "0x51F09F0", VA = "0x1851F19F0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51F1310", Offset = "0x51F0310", VA = "0x1851F1310")]
		private void DAMFCBDEHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2103E30", Offset = "0x2102E30", VA = "0x182103E30")]
		public global::HELCMNOJFHO<T> GetOrCreateCullingGroup<T>(int OMLKOBLGGGG, ushort JHMPKGOPKCE = 0) where T : ICNNPDEKMPC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2103C20", Offset = "0x2102C20", VA = "0x182103C20")]
		private global::HELCMNOJFHO<T> FMMLAPFAFHA<T>(int OMLKOBLGGGG, float[] FMCABKCJDCE, ushort JHMPKGOPKCE = 0) where T : ICNNPDEKMPC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51F1610", Offset = "0x51F0610", VA = "0x1851F1610")]
		public static KMFELBKHOKO FindClosestDefaultUpdateLod(float LCJBGOKACJA)
		{
			return default(KMFELBKHOKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51F18C0", Offset = "0x51F08C0", VA = "0x1851F18C0")]
		public static KMFELBKHOKO MinUpdateLod(KMFELBKHOKO PIPFCLEJELN, KMFELBKHOKO NJHGJHEIHEL)
		{
			return default(KMFELBKHOKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51F1860", Offset = "0x51F0860", VA = "0x1851F1860")]
		public static KMFELBKHOKO MaxUpdateLod(KMFELBKHOKO PIPFCLEJELN, KMFELBKHOKO NJHGJHEIHEL)
		{
			return default(KMFELBKHOKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51F1D80", Offset = "0x51F0D80", VA = "0x1851F1D80")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EDGDMPHGEDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CPDPJPFGMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera LECLFNPKLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KADOKFFMEKA PNAMALECHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GHLIENNNLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KADOKFFMEKA MHAAOGCNKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KFLJBDLHJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IHCABMBIODG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int FIGLHDADEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BKJAAOOBEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HELCMNOJFHO<T> : IHCABMBIODG where T : ICNNPDEKMPC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KMFELBKHOKO BHCNMBHIMFE(float HLPBMMEOGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGEJAMCGIKA(T NHBCHHMAJOK, float LKNCALHCOKD, GMJDLCIMBKO INDLMLPIACB = GMJDLCIMBKO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGEJAMCGIKA(T NHBCHHMAJOK, Transform PLPKGBCCJCK, float LKNCALHCOKD, GMJDLCIMBKO INDLMLPIACB = GMJDLCIMBKO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNHCFEEEENF(T NHBCHHMAJOK, [Optional] float? LKNCALHCOKD);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDBFDJDECBI(T JHKJIJCDNMO);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KMFELBKHOKO ABCLAFHFIGM(T NHBCHHMAJOK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PNMPOIHHGCD(T NHBCHHMAJOK);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGDNKBBBBCP(T NHBCHHMAJOK, GMJDLCIMBKO FDKEPAPOPIC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ICNNPDEKMPC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform OAPBHALKCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(KMFELBKHOKO NOEHAJEIPEB, KMFELBKHOKO GMDOAEHAGJK);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OKBGCFNIHPO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GMJDLCIMBKO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KMFELBKHOKO
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
public class INOCFGHNDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KMFELBKHOKO HKAKKDBNNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private KMFELBKHOKO OBPPMPNHIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, KMFELBKHOKO> OKMAEIAKJLB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BICIAPMBONF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51F1ED0", Offset = "0x51F0ED0", VA = "0x1851F1ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KMFELBKHOKO MCHHEMCIGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x58DED0", Offset = "0x58CED0", VA = "0x18058DED0")]
		get
		{
			return default(KMFELBKHOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KMFELBKHOKO AGALIOGJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1710", Offset = "0x5B0710", VA = "0x1805B1710")]
		get
		{
			return default(KMFELBKHOKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51F2090", Offset = "0x51F1090", VA = "0x1851F2090")]
	public bool PNPEIPPMCOG(object CNJNFLKBLCC, KMFELBKHOKO GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51F1E70", Offset = "0x51F0E70", VA = "0x1851F1E70")]
	public bool ABDICKAKOAL(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x51F1F20", Offset = "0x51F0F20", VA = "0x1851F1F20")]
	private bool BEJKGCAGOBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51F2100", Offset = "0x51F1100", VA = "0x1851F2100")]
	public INOCFGHNDKP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51F2180", Offset = "0x51F1180", VA = "0x1851F2180")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x51F2280", Offset = "0x51F1280", VA = "0x1851F2280")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
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
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
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
