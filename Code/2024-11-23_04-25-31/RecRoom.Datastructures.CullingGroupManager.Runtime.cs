using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KIADIIPNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct ICABJOLELCH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> GGEMPJLCHFC;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9E80", Offset = "0x6DB8880", VA = "0x186DB9E80", Slot = "4")]
			public void Execute(int GCBONJOGHCD, TransformAccess FOBEMKFOBOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct KGEHAKIGKKH : IEquatable<KGEHAKIGKKH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort JBKNDPDDIBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type BBAGLHLLBOL;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9FF0", Offset = "0x6DB89F0", VA = "0x186DB9FF0", Slot = "4")]
			public bool Equals(KGEHAKIGKKH GDOGPMPJPOO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9F00", Offset = "0x6DB8900", VA = "0x186DB9F00", Slot = "0")]
			public override bool Equals(object BBNKFKDCOLP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6DBA070", Offset = "0x6DB8A70", VA = "0x186DBA070", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class EFOOAAKFDEN<T> : BHLOGIEJBAE, GAMCKGIAKLK<T>, PALGLEFKFHF where T : class, LFILLLADNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3B76880", Offset = "0x3B75280", VA = "0x183B76880")]
			internal EFOOAAKFDEN(int ILIKBGGFPPK, float[] IJLOLFBBBOL, KLCKFDBLDCM LCFGGEFEEIJ = KLCKFDBLDCM.PlayerHead, bool JDJGFHEKNJP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3B76830", Offset = "0x3B75230", VA = "0x183B76830", Slot = "12")]
			public void NOEGDDICEDP(T BBNKFKDCOLP, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3B76800", Offset = "0x3B75200", VA = "0x183B76800", Slot = "13")]
			public void NOEGDDICEDP(T BBNKFKDCOLP, Transform MCLAMILMMPE, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3B76860", Offset = "0x3B75260", VA = "0x183B76860", Slot = "14")]
			public void PJOABDGMIKH(T MMDNCOPELHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3B767E0", Offset = "0x3B751E0", VA = "0x183B767E0", Slot = "15")]
			public bool IBCHPHJEKDB(T BBNKFKDCOLP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BHLOGIEJBAE : IDisposable, PALGLEFKFHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct BEKJBJABJNO
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum EIOBIGALOKN : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public LFILLLADNAC HGPJBMDALGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform DNOKGDKBFAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float BMOOOPPEKEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public GALLBHMJHEK PLKBKHEMPJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public EIOBIGALOKN DLLABFENMHB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum KLCKFDBLDCM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class MKGGIIPCMAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public LFILLLADNAC HGPJBMDALGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public GALLBHMJHEK EAJAGKMKAJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action MBIGLNJHJKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool MMCHFIGPNKP;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
				public MKGGIIPCMAG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class AGDPJGMKLIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public BHLOGIEJBAE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public MKGGIIPCMAG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
				public AGDPJGMKLIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x6DB5E70", Offset = "0x6DB4870", VA = "0x186DB5E70")]
				internal void KFAPEGLBEGM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int JGMFCNKHDLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool JDJGFHEKNJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool IFCFLPBDAAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup DKLEHOGNPLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] AOOHPFOAENF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly CFBGJFCDEAK LPMHKEAJABJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly KLCKFDBLDCM LCFGGEFEEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<LFILLLADNAC, int> CBAIAHJJNJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, MKGGIIPCMAG> KMLLLEMBJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray FHCOFGHDMDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> OFIPMMGAOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<BEKJBJABJNO> NHLIFGAMBHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool LEDHHNFMHAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle FGPOBPGGBEF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int KHFFAAEDJHE
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int NNCLDJBEBBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xA10880", Offset = "0xA0F280", VA = "0x180A10880", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xA10890", Offset = "0xA0F290", VA = "0x180A10890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8600", Offset = "0x6DB7000", VA = "0x186DB8600")]
			internal BHLOGIEJBAE(int ILIKBGGFPPK, float[] IJLOLFBBBOL, KLCKFDBLDCM LCFGGEFEEIJ = KLCKFDBLDCM.PlayerHead, bool JDJGFHEKNJP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7530", Offset = "0x6DB5F30", VA = "0x186DB7530")]
			public void GIMAJAOFAFI(bool BMFFIAMNJKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8330", Offset = "0x6DB6D30", VA = "0x186DB8330", Slot = "5")]
			public void NOEGDDICEDP(LFILLLADNAC BBNKFKDCOLP, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8290", Offset = "0x6DB6C90", VA = "0x186DB8290", Slot = "10")]
			public void NOEGDDICEDP(LFILLLADNAC BBNKFKDCOLP, Transform MCLAMILMMPE, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6DB5EF0", Offset = "0x6DB48F0", VA = "0x186DB5EF0")]
			private void AGCGJCCHPOO(LFILLLADNAC BBNKFKDCOLP, Transform MCLAMILMMPE, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6DB85A0", Offset = "0x6DB6FA0", VA = "0x186DB85A0", Slot = "6")]
			public void PJOABDGMIKH(LFILLLADNAC MMDNCOPELHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7C20", Offset = "0x6DB6620", VA = "0x186DB7C20")]
			private void LJIAABLOPBL(LFILLLADNAC MMDNCOPELHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7830", Offset = "0x6DB6230", VA = "0x186DB7830")]
			private void JGHMHHKMKKP(LFILLLADNAC BBNKFKDCOLP, [Optional] float? JNPCONGOFCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7560", Offset = "0x6DB5F60", VA = "0x186DB7560", Slot = "11")]
			public bool IBCHPHJEKDB(LFILLLADNAC BBNKFKDCOLP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7A70", Offset = "0x6DB6470", VA = "0x186DB7A70", Slot = "7")]
			public void KCAGOEOBEND(LFILLLADNAC BBNKFKDCOLP, GALLBHMJHEK PALLPMKJNOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7B40", Offset = "0x6DB6540", VA = "0x186DB7B40")]
			private void KFIKPLDHBGP(LFILLLADNAC BBNKFKDCOLP, GALLBHMJHEK PALLPMKJNOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6DB62F0", Offset = "0x6DB4CF0", VA = "0x186DB62F0")]
			public void CICAKKODBAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7620", Offset = "0x6DB6020", VA = "0x186DB7620")]
			public void IKBKDLBEPHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6DB6F00", Offset = "0x6DB5900", VA = "0x186DB6F00")]
			private void EFAILFPJDCO(BEKJBJABJNO CLNPLAGFLPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8140", Offset = "0x6DB6B40", VA = "0x186DB8140")]
			private void NICNAPKKPGC(int ANPFDOEBNOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6DB6BD0", Offset = "0x6DB55D0", VA = "0x186DB6BD0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6DB6510", Offset = "0x6DB4F10", VA = "0x186DB6510")]
			private void CJGDGDCHGNE(MKGGIIPCMAG FFBKGNHMFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6DB72A0", Offset = "0x6DB5CA0", VA = "0x186DB72A0")]
			private static void GBAHODOJCLI(MKGGIIPCMAG FFBKGNHMFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7230", Offset = "0x6DB5C30", VA = "0x186DB7230")]
			private void GAOIKKCBILM(MKGGIIPCMAG FFBKGNHMFDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6DB80D0", Offset = "0x6DB6AD0", VA = "0x186DB80D0")]
			private static void MEOHNFLJEGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8070", Offset = "0x6DB6A70", VA = "0x186DB8070")]
			private static void LNIOBBPEECF(float OFFHKGFMEHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8130", Offset = "0x6DB6B30", VA = "0x186DB8130")]
			private void NDCCHGFDIGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7C10", Offset = "0x6DB6610", VA = "0x186DB7C10")]
			private void LDPIFFJKKPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6DB68A0", Offset = "0x6DB52A0", VA = "0x186DB68A0")]
			private void DBGFINDILBG(CullingGroupEvent LBGLOJMOHFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8430", Offset = "0x6DB6E30", VA = "0x186DB8430")]
			private void PHBAGFPDKBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OEPNJLJDINN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LPLPHEIGKDK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OLNKOLHLKFL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KACIHNLMNJG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LJNHKJGNELF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PMKLPFLIHDA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BINLCNMCJAM = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<KGEHAKIGKKH, BHLOGIEJBAE> IMICCJGLIPD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable ODNEKAPJPGJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BHMFLDMAICG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static APNHDGDPKOI JGOEFMHINMH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static APNHDGDPKOI PIAPHOBKICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly APNHDGDPKOI JINHKAHAHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly APNHDGDPKOI BIBLHNBAKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly APNHDGDPKOI FJHMKDDJICA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FMCFLKBHHHO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker BBMJMODOCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OIMBFIPCENK NKPBJGAPKIG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BMFFIAMNJKE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public APNHDGDPKOI IGFBOCALDGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public APNHDGDPKOI NBJKNGEKDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public APNHDGDPKOI JBNFOEPPOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ECNBLMBBGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x98A800", Offset = "0x989200", VA = "0x18098A800", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ILFJLAMDJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x98A810", Offset = "0x989210", VA = "0x18098A810", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x98A160", Offset = "0x988B60", VA = "0x18098A160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8AE0", Offset = "0x6DB74E0", VA = "0x186DB8AE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DB96F0", Offset = "0x6DB80F0", VA = "0x186DB96F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DB96D0", Offset = "0x6DB80D0", VA = "0x186DB96D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB91D0", Offset = "0x6DB7BD0", VA = "0x186DB91D0")]
		private void LLCMCFFLIBK(Scene AOJOHHCFNCH, LoadSceneMode JNPKLGGOLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB95F0", Offset = "0x6DB7FF0", VA = "0x186DB95F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9930", Offset = "0x6DB8330", VA = "0x186DB9930")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9230", Offset = "0x6DB7C30", VA = "0x186DB9230")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8BA0", Offset = "0x6DB75A0", VA = "0x186DB8BA0")]
		private void EEOAPDFLPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9710", Offset = "0x6DB8110", VA = "0x186DB9710")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9480", Offset = "0x6DB7E80", VA = "0x186DB9480")]
		private void NFIHBBJOAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8FF0", Offset = "0x6DB79F0", VA = "0x186DB8FF0")]
		public PALGLEFKFHF GetOrCreateCullingGroup(Type LLOPLBMEOKH, int CFBPDFEEGJA, ushort GNODJBCLMHK = 0, bool JDJGFHEKNJP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D18FE0", Offset = "0x2D179E0", VA = "0x182D18FE0")]
		public GAMCKGIAKLK<T> GetOrCreateCullingGroup<T>(int CFBPDFEEGJA, ushort GNODJBCLMHK = 0, bool JDJGFHEKNJP = false) where T : class, LFILLLADNAC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E60", Offset = "0x6DB7860", VA = "0x186DB8E60")]
		private PALGLEFKFHF GAJGLGAIHNG(Type LLOPLBMEOKH, int CFBPDFEEGJA, float[] IJLOLFBBBOL, ushort GNODJBCLMHK = 0, bool JDJGFHEKNJP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D18DA0", Offset = "0x2D177A0", VA = "0x182D18DA0")]
		private GAMCKGIAKLK<T> GAJGLGAIHNG<T>(int CFBPDFEEGJA, float[] IJLOLFBBBOL, ushort GNODJBCLMHK = 0, bool JDJGFHEKNJP = false) where T : class, LFILLLADNAC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8D00", Offset = "0x6DB7700", VA = "0x186DB8D00")]
		public static DEMMDJFFENH FindClosestDefaultUpdateLod(float BOBOPJONPNF)
		{
			return default(DEMMDJFFENH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8DA150", Offset = "0x8D8B50", VA = "0x1808DA150")]
		public static DEMMDJFFENH MinUpdateLod(DEMMDJFFENH MBBKJKLHOKP, DEMMDJFFENH FNAAKEDDAKO)
		{
			return default(DEMMDJFFENH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9470", Offset = "0x6DB7E70", VA = "0x186DB9470")]
		public static DEMMDJFFENH MaxUpdateLod(DEMMDJFFENH MBBKJKLHOKP, DEMMDJFFENH FNAAKEDDAKO)
		{
			return default(DEMMDJFFENH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9D30", Offset = "0x6DB8730", VA = "0x186DB9D30")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CFBGJFCDEAK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BFPBMJOLFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera LJGIEJMPDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	APNHDGDPKOI AOGPPGJLEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PPGEDGDNMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	APNHDGDPKOI EBBBNGFIACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LINJNLPILIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PALGLEFKFHF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOEGDDICEDP(LFILLLADNAC BBNKFKDCOLP, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJOABDGMIKH(LFILLLADNAC MMDNCOPELHJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCAGOEOBEND(LFILLLADNAC BBNKFKDCOLP, GALLBHMJHEK NAPMDPGIOKH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAMCKGIAKLK<T> : PALGLEFKFHF where T : class, LFILLLADNAC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOEGDDICEDP(T BBNKFKDCOLP, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOEGDDICEDP(T BBNKFKDCOLP, Transform MCLAMILMMPE, float JNPCONGOFCD, GALLBHMJHEK OOPDDHNKNFO = GALLBHMJHEK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJOABDGMIKH(T MMDNCOPELHJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBCHPHJEKDB(T BBNKFKDCOLP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LFILLLADNAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FOBEMKFOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DEMMDJFFENH PACMIPCMEFO, DEMMDJFFENH AMIFOGIJCON);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IOGPMONELGI);
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
