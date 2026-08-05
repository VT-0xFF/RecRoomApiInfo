using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HLGCLNPFCOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NLBKEFDNIGE
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RadioHighPitch = 12
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ILNDNNFJPOL
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OABKFHKPHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly ILNDNNFJPOL JGGMFDAADDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string NAJAPMKGCPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66E3D80", Offset = "0x66E3180", VA = "0x1866E3D80")]
	public OABKFHKPHFH(ILNDNNFJPOL IPEJJHCCOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66E3E20", Offset = "0x66E3220", VA = "0x1866E3E20")]
	public OABKFHKPHFH(ILNDNNFJPOL IPEJJHCCOCE, string NAIKMHHKBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CF0", Offset = "0x66E30F0", VA = "0x1866E3CF0")]
	public bool AOBHMHICNFJ(ILNDNNFJPOL JOEBDBDFLDE, string MGCOFPEKNMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ABJCEOFAKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LFEBKPICKFL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66E37A0", Offset = "0x66E2BA0", VA = "0x1866E37A0")]
	public static void IGFJMKAMIGP(this AudioSource GJBIGNKMPHN, AudioRolloff EHJJDFMLABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66E36D0", Offset = "0x66E2AD0", VA = "0x1866E36D0")]
	public static void DKCJOEJOKFJ(this AudioSource FONEFFECKOD, RecRoomAudioClip FPIFKEENCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EACNIOILFLM
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const float FMIAGNCODED = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const float POOCNLKDLOO = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66E2F70", Offset = "0x66E2370", VA = "0x1866E2F70")]
	public static float KHENGKCPPEP(float MEAFOPPCNFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66E2F40", Offset = "0x66E2340", VA = "0x1866E2F40")]
	public static float FNCKFHHMBGN(float PPFIMEAGFDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EACNIOILFLM()
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66E2F20", Offset = "0x66E2320", VA = "0x1866E2F20")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DFJDEONOPNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CADIAIGELGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, JNGPMOCOLPC> OCDIHMOAOID();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, OABKFHKPHFH)> JGBJHINHDEI();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup GMONKBKPHIO(ILNDNNFJPOL IPEJJHCCOCE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup BJPGBNEFDGF(OABKFHKPHFH OBJJDMACEHC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGFJMKAMIGP(AudioSource FONEFFECKOD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource OPLMJJDMLEK(RecRoomAudioClip FEKCJICGJKL, Transform JFOAIKIJPKK, [Optional] AudioRolloff HGKNNBHIIBD, [Optional] Action<SFXAudioSource> AEGNGKHDBED, [Optional] OABKFHKPHFH? IPEJJHCCOCE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKBMILCHLEG(SFXAudioSource FONEFFECKOD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource FOIEHKJIINL(RecRoomAudioClip[] DLJIHKFBEIJ, bool PECOFJLLKNJ = false, float IGGKHKJJECE = 1f, [Optional] Action<SFXAudioSource> AEGNGKHDBED, [Optional] OABKFHKPHFH? IPEJJHCCOCE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource LNAEFNMBOPA(RecRoomAudioClip[] DLJIHKFBEIJ, Transform JFOAIKIJPKK, [Optional] AudioRolloff HGKNNBHIIBD, bool PECOFJLLKNJ = false, [Optional] Action<SFXAudioSource> AEGNGKHDBED, [Optional] OABKFHKPHFH? IPEJJHCCOCE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource AOBKBMBJDGD(RecRoomAudioClip FKCCMGBCBGA, Vector3 BJNJDEBFECO, bool JMKAINFJHMC, [Optional] AudioRolloff HGKNNBHIIBD, [Optional] Action<SFXAudioSource> AEGNGKHDBED, [Optional] OABKFHKPHFH? IPEJJHCCOCE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource DCFOFHGMMCC(RecRoomAudioClip AKLAMMCJPAE, [Optional] Action<SFXAudioSource> AEGNGKHDBED, [Optional] OABKFHKPHFH? IPEJJHCCOCE);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x66E4280", Offset = "0x66E3680", VA = "0x1866E4280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x66E4310", Offset = "0x66E3710", VA = "0x1866E4310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66E4220", Offset = "0x66E3620", VA = "0x1866E4220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x66E42C0", Offset = "0x66E36C0", VA = "0x1866E42C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66E41D0", Offset = "0x66E35D0", VA = "0x1866E41D0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x66E41E0", Offset = "0x66E35E0", VA = "0x1866E41E0")]
		public RecRoomAudioClip(AudioClip AKLAMMCJPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66E4060", Offset = "0x66E3460", VA = "0x1866E4060")]
		public bool HOCIKADFMCP(RecRoomAudioClip JHMCLPBFJBC)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66E3F90", Offset = "0x66E3390", VA = "0x1866E3F90")]
		public bool ABCELNLLKEN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE24C60", Offset = "0xE24060", VA = "0x180E24C60")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, MNBAGKCAGAJ.PLHPLKCFNNF
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct KNDDKOGEBLM
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private const float JMJFEMIFKDN = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private const float KDNNIBIFION = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private const ILNDNNFJPOL AKJOIECGIMJ = ILNDNNFJPOL.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float? GFMGMAFCNBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? NLHJPGLGJOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public Vector3 FMFAPMGMJJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Transform BALEJLODBLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AudioRolloff IDENIGFNEHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public float LOICJIIPAIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float NPHHOEBLELC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public ILNDNNFJPOL? JGGMFDAADDG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public float FCCNKMPIKFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x66E35F0", Offset = "0x66E29F0", VA = "0x1866E35F0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ILNDNNFJPOL FOJPMCCLKMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x66E3680", Offset = "0x66E2A80", VA = "0x1866E3680")]
				get
				{
					return default(ILNDNNFJPOL);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct NJMIPOKGEFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public KNDDKOGEBLM playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x66E3860", Offset = "0x66E2C60", VA = "0x1866E3860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OLJMKMFCMIB : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public OLJMKMFCMIB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66E3E90", Offset = "0x66E3290", VA = "0x1866E3E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66E3F50", Offset = "0x66E3350", VA = "0x1866E3F50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Action<SFXAudioSource> NADFGIFMMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GKOIHBKMELE BFGIENNFFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private AudioSource _audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private JGEBMMLMDCN LMMJKFHMPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DFJDEONOPNC JDOLIDFBGGN;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string KHLGHEDNPOL = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform BALEJLODBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioSource OIEBBMMJIME
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66E4390", Offset = "0x66E3790", VA = "0x1866E4390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66E4B20", Offset = "0x66E3F20", VA = "0x1866E4B20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x66E5370", Offset = "0x66E4770", VA = "0x1866E5370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x66E4DB0", Offset = "0x66E41B0", VA = "0x1866E4DB0")]
		public void Play(AudioClip AKLAMMCJPAE, float PCGADOKEBIO, Vector3 BJNJDEBFECO, float PPECJONMLGB, float MCDFENAPIDE, AudioRolloff EHJJDFMLABH, [Optional] Action<SFXAudioSource> LIBFLJGPADN, [Optional] OABKFHKPHFH? IPEJJHCCOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66E4C40", Offset = "0x66E4040", VA = "0x1866E4C40")]
		[AsyncStateMachine(typeof(NJMIPOKGEFF))]
		public Task PlayAsync(AudioClip AKLAMMCJPAE, KNDDKOGEBLM IFLJKGAKMCN, CancellationToken ANIIOKLMHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x66E4490", Offset = "0x66E3890", VA = "0x1866E4490")]
		private void JCJCJBLPHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66E4AD0", Offset = "0x66E3ED0", VA = "0x1866E4AD0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x66E52D0", Offset = "0x66E46D0", VA = "0x1866E52D0")]
		public void Scrub(float PPIFMHEDLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66E5330", Offset = "0x66E4730", VA = "0x1866E5330")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66E4440", Offset = "0x66E3840", VA = "0x1866E4440")]
		public void CancelAudioSourceRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66E51E0", Offset = "0x66E45E0", VA = "0x1866E51E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x66E5170", Offset = "0x66E4570", VA = "0x1866E5170")]
		[IteratorStateMachine(typeof(OLJMKMFCMIB))]
		public IEnumerator<FEEMOJCDGJP> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x66E4430", Offset = "0x66E3830", VA = "0x1866E4430", Slot = "4")]
		private void CJNPJFHOFMB(bool HAAPPAEMABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66E2FC0", Offset = "0x66E23C0", VA = "0x1866E2FC0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66E30D0", Offset = "0x66E24D0", VA = "0x1866E30D0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
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
