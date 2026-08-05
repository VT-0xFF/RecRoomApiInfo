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
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MCPBGMMMJOM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KEGDJCPFKCC
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
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LDLEIFAAOFO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HLPIHAAELGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly LDLEIFAAOFO AIMAEJIIKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string JLGPEANIBKK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6046CB0", Offset = "0x6045CB0", VA = "0x186046CB0")]
	public HLPIHAAELGH(LDLEIFAAOFO BEMGGLGKLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6046D50", Offset = "0x6045D50", VA = "0x186046D50")]
	public HLPIHAAELGH(LDLEIFAAOFO BEMGGLGKLJJ, string ILHLJGFFJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6046C20", Offset = "0x6045C20", VA = "0x186046C20")]
	public bool LHDBPBKOKDO(LDLEIFAAOFO ANEBMPDGJKD, string DFLENJJPMPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HKIEFFLJDCF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NACNIMDHPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6047000", Offset = "0x6046000", VA = "0x186047000")]
	public static void MBEDAPNMFDI(this AudioSource BEOBFIPKKPF, AudioRolloff JIOBLIPHIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KGJKBEGCAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6046DC0", Offset = "0x6045DC0", VA = "0x186046DC0")]
	public static float AGFHPLGDCFP(float NFFMLPOJMBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6046E20", Offset = "0x6045E20", VA = "0x186046E20")]
	public static float MNBDLPGIAHO(float HEOLIMODILE)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6046940", Offset = "0x6045940", VA = "0x186046940")]
		public float FFAFBEHBFCI(float CGCBLMKGFKF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6046C00", Offset = "0x6045C00", VA = "0x186046C00")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAGJGGIGHAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HIKDMGALKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, JHHJCHFLMID> AAHAPEFPKLC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, HLPIHAAELGH)> EBAEKKAMMCG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup MDJJLCNFAIO(LDLEIFAAOFO BEMGGLGKLJJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup ENAKJBJPGOL(HLPIHAAELGH POADAFPAHKI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource OPKKOECMPNF(RecRoomAudioClip PIKDGJHPAMC, Transform EBDBIHHAPHL, [Optional] AudioRolloff NODOGCDCGJA, [Optional] Action<SFXAudioSource> JOIDHBOHFNG, [Optional] HLPIHAAELGH? BEMGGLGKLJJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJHJEPHNFLO(SFXAudioSource BAHFMCLJJML);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource NDEJLHFOAHK(RecRoomAudioClip[] CFFNMIEIIHI, bool OBGBOMJMAJN = false, float ADAFDCFFOIN = 1f, [Optional] Action<SFXAudioSource> JOIDHBOHFNG, [Optional] HLPIHAAELGH? BEMGGLGKLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource AJAHBLFLALP(RecRoomAudioClip[] CFFNMIEIIHI, Transform EBDBIHHAPHL, [Optional] AudioRolloff NODOGCDCGJA, bool OBGBOMJMAJN = false, [Optional] Action<SFXAudioSource> JOIDHBOHFNG, [Optional] HLPIHAAELGH? BEMGGLGKLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource AAJNBKNHOBJ(RecRoomAudioClip GBOADOCOECG, Vector3 HLCDMCNCOBO, bool LNNFDAHFAIM, [Optional] AudioRolloff NODOGCDCGJA, [Optional] Action<SFXAudioSource> JOIDHBOHFNG, [Optional] HLPIHAAELGH? BEMGGLGKLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource FCDHINLDJIC(RecRoomAudioClip JCCIPHGGLKC, [Optional] Action<SFXAudioSource> JOIDHBOHFNG, [Optional] HLPIHAAELGH? BEMGGLGKLJJ);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6047800", Offset = "0x6046800", VA = "0x186047800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6047850", Offset = "0x6046850", VA = "0x186047850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60477B0", Offset = "0x60467B0", VA = "0x1860477B0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60477C0", Offset = "0x60467C0", VA = "0x1860477C0")]
		public RecRoomAudioClip(AudioClip JCCIPHGGLKC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60476E0", Offset = "0x60466E0", VA = "0x1860476E0")]
		public bool KFDHFKLIJJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C00", Offset = "0x8A3C00", VA = "0x1808A4C00")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, PCJIPFBBBJJ.HGFDIBMOCDF
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct MGKACKLILJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? BAFCFPKBBKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? IHBEDBGCDBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 JLMNIJABFFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform CBGHAFOCNFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff KNFDHAEDCPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float JAKEFDENLNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float MDNKIGPEOJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public LDLEIFAAOFO? AIMAEJIIKGB;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float ILCIAGGMEJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6046F30", Offset = "0x6045F30", VA = "0x186046F30")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public LDLEIFAAOFO HJMHJBLDDDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6046FB0", Offset = "0x6045FB0", VA = "0x186046FB0")]
				get
				{
					return default(LDLEIFAAOFO);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct OADMPHHOIDN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public MGKACKLILJP playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x60470C0", Offset = "0x60460C0", VA = "0x1860470C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6047680", Offset = "0x6046680", VA = "0x186047680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KMHLGLPDGIK : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public KMHLGLPDGIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6046E60", Offset = "0x6045E60", VA = "0x186046E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6046EE0", Offset = "0x6045EE0", VA = "0x186046EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> PLIGKFCAMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private CKENCMBGPDL EOLKBFPMPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private MAFPGJFOFOP JEHJFNOCIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KAGJGGIGHAB KGKPHELJNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float JBBLBFLBPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float LMAFLOHEAHB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string JMLACOGJCGD = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform CBGHAFOCNFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int DDIKIKIPCGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6048E80", Offset = "0x6047E80", VA = "0x186048E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HOLDGJMFJIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6048F60", Offset = "0x6047F60", VA = "0x186048F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool BDBDGLGPOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6048F40", Offset = "0x6047F40", VA = "0x186048F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float BAFCFPKBBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6048F80", Offset = "0x6047F80", VA = "0x186048F80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float KBFPJOHLFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6048EA0", Offset = "0x6047EA0", VA = "0x186048EA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60478E0", Offset = "0x60468E0", VA = "0x1860478E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6048100", Offset = "0x6047100", VA = "0x186048100")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6048DC0", Offset = "0x6047DC0", VA = "0x186048DC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6048DA0", Offset = "0x6047DA0", VA = "0x186048DA0")]
		public void UpdateVolume(float BDEDENKNNBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6048B90", Offset = "0x6047B90", VA = "0x186048B90")]
		public void UpdatePitch(float GNNFGNMHMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6048AF0", Offset = "0x6047AF0", VA = "0x186048AF0")]
		public void UpdateDopplerLevel(float GKDDIPGFKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6048D00", Offset = "0x6047D00", VA = "0x186048D00")]
		public void UpdateSpatialBlend(float OAOHNIJCEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6048A20", Offset = "0x6047A20", VA = "0x186048A20")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60483E0", Offset = "0x60473E0", VA = "0x1860483E0")]
		public void Play(AudioClip JCCIPHGGLKC, float BDEDENKNNBJ, Vector3 HLCDMCNCOBO, float KOIDJJFDFIA, float DHDKNIEGBKE, AudioRolloff JIOBLIPHIIL, [Optional] Action<SFXAudioSource> BAEMNMFFICK, [Optional] HLPIHAAELGH? BEMGGLGKLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6048290", Offset = "0x6047290", VA = "0x186048290")]
		[AsyncStateMachine(typeof(OADMPHHOIDN))]
		public Task PlayAsync(AudioClip JCCIPHGGLKC, MGKACKLILJP BFPCNHHNNHE, CancellationToken JMJKFNJJBHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60479B0", Offset = "0x60469B0", VA = "0x1860479B0")]
		private void JMLEHAKAKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60480B0", Offset = "0x60470B0", VA = "0x1860480B0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6048A50", Offset = "0x6047A50", VA = "0x186048A50")]
		public void Scrub(float CJLMIDOLMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6048AB0", Offset = "0x6047AB0", VA = "0x186048AB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6048950", Offset = "0x6047950", VA = "0x186048950")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60488D0", Offset = "0x60478D0", VA = "0x1860488D0")]
		[IteratorStateMachine(typeof(KMHLGLPDGIK))]
		public IEnumerator<LLCDBDMNGNA> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x11694F0", Offset = "0x11684F0", VA = "0x1811694F0", Slot = "4")]
		private void EBLGKHIIGEO(bool JDPFGDIKIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public SFXAudioSource()
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
