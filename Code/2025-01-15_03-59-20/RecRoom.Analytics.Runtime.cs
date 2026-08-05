using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E18460", Offset = "0x6E17860", VA = "0x186E18460")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A690", Offset = "0x6E19A90", VA = "0x186E1A690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings LJPJDFLJJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JFIDLOHMNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, FAMNLLOHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum HBGLOFACHGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class DGNEMPLNBDN
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class GNBECFCPAND
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int JMAHPLKPFHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> ACJOJOMEGIB;

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				public GNBECFCPAND()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class CAOHBBNEAMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				public CAOHBBNEAMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x6E0EC20", Offset = "0x6E0E020", VA = "0x186E0EC20")]
				internal bool FLBJFDJNEHD(GNBECFCPAND item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string KJEGFOAKGCO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string DFDAPFPPOMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<GNBECFCPAND> HFHDJEDBNIP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? GKEELIJAPDP
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x6E10930", Offset = "0x6E0FD30", VA = "0x186E10930")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E10C80", Offset = "0x6E10080", VA = "0x186E10C80")]
			internal DGNEMPLNBDN(string AFCNEILCHPM, string KLFBMIKLPDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E109D0", Offset = "0x6E0FDD0", VA = "0x186E109D0")]
			public int MMBDGFDCJBH([Optional] int? FFFCMJMPEIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0FA30", Offset = "0x6E0EE30", VA = "0x186E0FA30")]
			public List<Dictionary<string, object>> AJCGHCLDCJO(int GGACNCGGAGP, int? FFFCMJMPEIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E10690", Offset = "0x6E0FA90", VA = "0x186E10690")]
			public void JICCICHCDMA(AmplitudeAnalyticsIdentifyMessage NCHBKHMIMGJ, bool OPADPHDKGAH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6E10580", Offset = "0x6E0F980", VA = "0x186E10580")]
			public void JICCICHCDMA(Dictionary<string, object> NCHBKHMIMGJ, bool OPADPHDKGAH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E0FCA0", Offset = "0x6E0F0A0", VA = "0x186E0FCA0")]
			public void CMKPKDBHLIG(params Dictionary<string, object>[] OJPCDMFBGCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6E0FF40", Offset = "0x6E0F340", VA = "0x186E0FF40")]
			public void FGEONMLBEFC(List<Dictionary<string, object>> KBCKBFDPDFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6E10B80", Offset = "0x6E0FF80", VA = "0x186E10B80")]
			private void PKAEFPEBKOC(Dictionary<string, object> NCHBKHMIMGJ, bool OPADPHDKGAH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E10730", Offset = "0x6E0FB30", VA = "0x186E10730")]
			public void KGCANGGLMJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E10180", Offset = "0x6E0F580", VA = "0x186E10180")]
			private void JEBHLGJCJCC([Optional] string NNCJBHDKFKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E0FE20", Offset = "0x6E0F220", VA = "0x186E0FE20")]
			private static string EFLFEDLMKHP(string HCPAOILCJCB, string LDCKBFKFIKC)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6E1A2B0", Offset = "0x6E196B0", VA = "0x186E1A2B0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct IBMCGIJPBKG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int GLGLHOCJLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string HKAPIAAAADJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T PJOGKLGOJOC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MFFGLJBFDLD : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public MFFGLJBFDLD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6E14D20", Offset = "0x6E14120", VA = "0x186E14D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6E154B0", Offset = "0x6E148B0", VA = "0x186E154B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JFEJBOLJDDN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public FPFCPNKOFAP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public JFEJBOLJDDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6E12DC0", Offset = "0x6E121C0", VA = "0x186E12DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6E12ED0", Offset = "0x6E122D0", VA = "0x186E12ED0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HBECEHHPNAC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public HBECEHHPNAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E12870", Offset = "0x6E11C70", VA = "0x186E12870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6E129E0", Offset = "0x6E11DE0", VA = "0x186E129E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JEICHOEEFDH : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public JEICHOEEFDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6E12B10", Offset = "0x6E11F10", VA = "0x186E12B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6E12D70", Offset = "0x6E12170", VA = "0x186E12D70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CKIGOGEIIBO : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public CKIGOGEIIBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EC90", Offset = "0x6E0E090", VA = "0x186E0EC90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EEE0", Offset = "0x6E0E2E0", VA = "0x186E0EEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KNJMBFCHAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public DGNEMPLNBDN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public KNJMBFCHAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6E13330", Offset = "0x6E12730", VA = "0x186E13330")]
			internal void KNOOJFGICHM(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6E13640", Offset = "0x6E12A40", VA = "0x186E13640")]
			internal void PJBLGGKLCJC(IBMCGIJPBKG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class GPMBBJFAEBA : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public DGNEMPLNBDN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private KNJMBFCHAGP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public GPMBBJFAEBA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6E12020", Offset = "0x6E11420", VA = "0x186E12020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6E12820", Offset = "0x6E11C20", VA = "0x186E12820", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DAKCPGBDJMA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DAKCPGBDJMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E4B2C0", Offset = "0x5E4A6C0", VA = "0x185E4B2C0")]
			internal IBMCGIJPBKG<T> BHOMIOGHCNJ(AOCAAHLCPKC postResponse)
			{
				return default(IBMCGIJPBKG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private GMAGBLHDHPN AIJIHINIFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<ELMOCMDBKDB> HKJBMINOLEO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string HHEGJANGMHB = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string GBDCCPDFHMC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string BNDFHIOGBEB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FCNDCFNOEGB = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int HDIEOPFFLJI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int FHAAKFLOJJL = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float AEFELCBDEBL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BCKCEPLMEOI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string JNNGKNCNGJL = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string OEMODJHBAED = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string OIPEOHIPKCH = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string KBDELMCMDJP = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool DOBDCENNGGF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool FFEMNLDDMLG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int CGLNMDPOJJK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int ODONDIKFKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LOMBHALLIDK IFKBKCLHIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KDGIKGOPJAJ EBBFFFEGDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FNJEDMNNIPN JOEJCKPBHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool BBPCPBOPEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float DDDGIDDKNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float LFNBAAOABOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int MEDENMEGMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KKAENMKJBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? KGDOKHNBFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? FJPHPFALKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long OCMCHDCOBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string BGDFFCBPNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string NDGNFKAPKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long EOKKNNJEACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string KBBHBNLHCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string FKOLLLHOCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> NLNFLLMCIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HBGLOFACHGO CLDDOHJEAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int ACFNMJAALGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int CKLCHDLIEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float EDPKEMAIGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool OOEDGKEDEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool LCLBFNIFIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DGNEMPLNBDN PBOBHCMAJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private DGNEMPLNBDN KKLMPGNDIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private DGNEMPLNBDN PGPCKBKJKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string MNMOEIOHCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CGDBMGGOKEO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JPMLFPKPFHN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string KDPBKFCHLHF;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string JFCIJCOJBCG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string CEMOCLEPFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string EADANHENNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string OIEBFKFCOBC;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GMAGBLHDHPN FHBDCDMPPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6E07DB0", Offset = "0x6E071B0", VA = "0x186E07DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ELMOCMDBKDB NDEGOOFGPJN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B410", Offset = "0x6E0A810", VA = "0x186E0B410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int KKBNNKCPBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6E0ACE0", Offset = "0x6E0A0E0", VA = "0x186E0ACE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long EBILPEJBEBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D2F0", Offset = "0x6E0C6F0", VA = "0x186E0D2F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D400", Offset = "0x6E0C800", VA = "0x186E0D400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string NKEDOLKBEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D2C0", Offset = "0x6E0C6C0", VA = "0x186E0D2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BBLEIKONDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xFB2C40", Offset = "0xFB2040", VA = "0x180FB2C40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xFB1810", Offset = "0xFB0C10", VA = "0x180FB1810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HOAPOAIBEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9EBA90", Offset = "0x9EAE90", VA = "0x1809EBA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF769D0", Offset = "0xF75DD0", VA = "0x180F769D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? CHMKHDNDAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x911AB0", Offset = "0x910EB0", VA = "0x180911AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC69080", Offset = "0xC68480", VA = "0x180C69080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JPEMCHFFPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA03E70", Offset = "0xA03270", VA = "0x180A03E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEB1300", Offset = "0xEB0700", VA = "0x180EB1300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool NMDBHAFACDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D190", Offset = "0x6E0C590", VA = "0x186E0D190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EACFBNFLHMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D0D0", Offset = "0x6E0C4D0", VA = "0x186E0D0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D340", Offset = "0x6E0C740", VA = "0x186E0D340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E075F0", Offset = "0x6E069F0", VA = "0x186E075F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E08710", Offset = "0x6E07B10", VA = "0x186E08710")]
		private void ELLBCHEJMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C710", Offset = "0x6E0BB10", VA = "0x186E0C710")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B360", Offset = "0x6E0A760", VA = "0x186E0B360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0CA40", Offset = "0x6E0BE40", VA = "0x186E0CA40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B460", Offset = "0x6E0A860", VA = "0x186E0B460")]
		public CLHPIMOBJFN PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A300", Offset = "0x6E09700", VA = "0x186E0A300")]
		[IteratorStateMachine(typeof(MFFGLJBFDLD))]
		public IEnumerator<ONHNFKGBFKG> InitializeForLocalAccount(AmplitudeAnalyticsEvent EHMMMNCDBGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BDE0", Offset = "0x6E0B1E0", VA = "0x186E0BDE0")]
		public void SendAppEnterEvent(bool EGPDODABCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C9C0", Offset = "0x6E0BDC0", VA = "0x186E0C9C0")]
		public void UpdateLastKnownInteractionCategory(string MHANPDKOFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C910", Offset = "0x6E0BD10", VA = "0x186E0C910")]
		public void UpdateLastAliveTime(float GNOIEGLKNOM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E08F00", Offset = "0x6E08300", VA = "0x186E08F00")]
		private CLHPIMOBJFN HLAPJPIJKOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E07C40", Offset = "0x6E07040", VA = "0x186E07C40")]
		private CLHPIMOBJFN BEPHLKCIICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C0F0", Offset = "0x6E0B4F0", VA = "0x186E0C0F0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E08DE0", Offset = "0x6E081E0", VA = "0x186E08DE0")]
		[IteratorStateMachine(typeof(JFEJBOLJDDN))]
		private IEnumerator FOILAONOKLK(FPFCPNKOFAP HCLHNNAGNME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E0CCD0", Offset = "0x6E0C0D0", VA = "0x186E0CCD0")]
		[IteratorStateMachine(typeof(HBECEHHPNAC))]
		public IEnumerator WaitForFlush(float NIFKBJPBAKP = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C7F0", Offset = "0x6E0BBF0", VA = "0x186E0C7F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C730", Offset = "0x6E0BB30", VA = "0x186E0C730")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HCHBEBADBKN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E09E00", Offset = "0x6E09200", VA = "0x186E09E00")]
		public static PEDDEDHHDBJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E07440", Offset = "0x6E06840", VA = "0x186E07440")]
		public static FFHHMNHLDLN AccountSelectionPostLoginEvent([NotNull] string JAOOIHNGGNK, string EOJIEKDCDLB, OFKOGMEFDGP OEPLMPCAGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E08AD0", Offset = "0x6E07ED0", VA = "0x186E08AD0")]
		public static FFHHMNHLDLN Event([NotNull] string JAOOIHNGGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B5F0", Offset = "0x6E0A9F0", VA = "0x186E0B5F0")]
		public static FFHHMNHLDLN PreviousSessionEvent([NotNull] string JAOOIHNGGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E09FA0", Offset = "0x6E093A0", VA = "0x186E09FA0")]
		public static FFHHMNHLDLN InitializeEvent(string EOJIEKDCDLB, int GBGNONKDMNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C2F0", Offset = "0x6E0B6F0", VA = "0x186E0C2F0")]
		public static FFHHMNHLDLN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E08000", Offset = "0x6E07400", VA = "0x186E08000")]
		public static FFHHMNHLDLN CreateOutOfSessionEvent(string JAOOIHNGGNK, bool BJLANEINNFL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A900", Offset = "0x6E09D00", VA = "0x186E0A900")]
		public static CLHPIMOBJFN LogOutOfSessionEvent(FFHHMNHLDLN NDDJLBBIFJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A6A0", Offset = "0x6E09AA0", VA = "0x186E0A6A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent GKINGFKFBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AAD0", Offset = "0x6E09ED0", VA = "0x186E0AAD0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent GKINGFKFBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC00", Offset = "0x6E0A000", VA = "0x186E0AC00")]
		public void LogSerializedEventAsync(Dictionary<string, object> EGEJAKAMDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A7D0", Offset = "0x6E09BD0", VA = "0x186E0A7D0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LBONAFNDIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E082D0", Offset = "0x6E076D0", VA = "0x186E082D0")]
		private void ECPLOOIMDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AEE0", Offset = "0x6E0A2E0", VA = "0x186E0AEE0")]
		private void OIAJGPNJKKL(Dictionary<string, object> JDCAHNFKMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E09D10", Offset = "0x6E09110", VA = "0x186E09D10")]
		private void IJCPDLOIPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B190", Offset = "0x6E0A590", VA = "0x186E0B190")]
		private void OMELIFPBBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E70", Offset = "0x6E08270", VA = "0x186E08E70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A470", Offset = "0x6E09870", VA = "0x186E0A470")]
		[IteratorStateMachine(typeof(JEICHOEEFDH))]
		private IEnumerator<ONHNFKGBFKG> JCMMBNOKHJN(float NIFKBJPBAKP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A500", Offset = "0x6E09900", VA = "0x186E0A500")]
		[IteratorStateMachine(typeof(CKIGOGEIIBO))]
		private IEnumerator<ONHNFKGBFKG> LCCGGCEKDAN(float NIFKBJPBAKP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A390", Offset = "0x6E09790", VA = "0x186E0A390")]
		[IteratorStateMachine(typeof(GPMBBJFAEBA))]
		private IEnumerator<ONHNFKGBFKG> JBFJPBHLOIM(DGNEMPLNBDN JDENFLNKFLO, int? FFFCMJMPEIJ, string HOJHPCOIIIN, float NIFKBJPBAKP, Action<int> OBGOBFMGFHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A590", Offset = "0x6E09990", VA = "0x186E0A590")]
		private static void LHLEPOBGLFJ(bool JCJGJBLMCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E083D0", Offset = "0x6E077D0", VA = "0x186E083D0")]
		private AMMGOODCICE<IBMCGIJPBKG<Dictionary<string, object>>> EKNJKOKOHIC(string HOJHPCOIIIN, string IEPHPPPLKBO, Dictionary<string, object> PJOGKLGOJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E084A0", Offset = "0x6E078A0", VA = "0x186E084A0")]
		private AMMGOODCICE<IBMCGIJPBKG<List<Dictionary<string, object>>>> EKNJKOKOHIC(string HOJHPCOIIIN, string IEPHPPPLKBO, List<Dictionary<string, object>> PJOGKLGOJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x375E200", Offset = "0x375D600", VA = "0x18375E200")]
		private AMMGOODCICE<IBMCGIJPBKG<T>> JGLKIAFGEMF<T>(string GONCFJCDCMO, string HOJHPCOIIIN, string IEPHPPPLKBO, T PJOGKLGOJOC, Dictionary<string, object> OMAEOFPIJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E07FB0", Offset = "0x6E073B0", VA = "0x186E07FB0")]
		private bool CKMFOMLFDJH(float IEEMNOBMLEO, float NIFKBJPBAKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E08FB0", Offset = "0x6E083B0", VA = "0x186E08FB0")]
		private Dictionary<string, object> IFLGPKDPMPD(string HOJHPCOIIIN, Dictionary<string, object> PJOGKLGOJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E0CDC0", Offset = "0x6E0C1C0", VA = "0x186E0CDC0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B70", Offset = "0x8F1F70", VA = "0x1808F2B70", Slot = "6")]
		private bool HKCAABAJPPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E07E40", Offset = "0x6E07240", VA = "0x186E07E40")]
		[CompilerGenerated]
		private long CGNHCCOBGPG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E082C0", Offset = "0x6E076C0", VA = "0x186E082C0")]
		[CompilerGenerated]
		private void DIOEIAKCIEJ(int PLBFOAPFNAE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string assignedUserCrm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E0F0", Offset = "0x6E0D4F0", VA = "0x186E0E0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E1C0", Offset = "0x6E0D5C0", VA = "0x186E0E1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E130", Offset = "0x6E0D530", VA = "0x186E0E130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E210", Offset = "0x6E0D610", VA = "0x186E0E210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E0B0", Offset = "0x6E0D4B0", VA = "0x186E0E0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E170", Offset = "0x6E0D570", VA = "0x186E0E170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF20", Offset = "0x8CA320", VA = "0x1808CAF20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DB80", Offset = "0x6E0CF80", VA = "0x186E0DB80")]
		public static FFHHMNHLDLN KOPOAAAOIOD(string GKEHKEEIHAE, [NotNull] string CJDBHELDNNN, long BLMHJOODFPE, long BKBKAMKJIPD, string EOJIEKDCDLB, string OEPLMPCAGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D460", Offset = "0x6E0C860", VA = "0x186E0D460")]
		public static FFHHMNHLDLN AEONDHMCLHF(string GKEHKEEIHAE, [NotNull] string CJDBHELDNNN, long BLMHJOODFPE, long BKBKAMKJIPD, string EOJIEKDCDLB, long OHBOGLIJEJK, string AHEBCLHHLFO, string KCBLJBBDBDB, string INLLCKKMIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DF10", Offset = "0x6E0D310", VA = "0x186E0DF10")]
		private AmplitudeAnalyticsEvent(string GKEHKEEIHAE, [NotNull] string CJDBHELDNNN, long BLMHJOODFPE, long BKBKAMKJIPD, string EOJIEKDCDLB, string OEPLMPCAGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA956C0", VA = "0x180A962C0")]
		public void JCLFHMDGJOF(long NNMGFMIBDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DA80", Offset = "0x6E0CE80", VA = "0x186E0DA80", Slot = "5")]
		public override void HIHLDBBIKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DD90", Offset = "0x6E0D190", VA = "0x186E0DD90", Slot = "6")]
		public override void NBNOGKPBDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D5C0", Offset = "0x6E0C9C0", VA = "0x186E0D5C0", Slot = "4")]
		protected override Dictionary<string, object> ECNLLAPNNHI(Dictionary<string, object> BMJLGHPDHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DC80", Offset = "0x6E0D080", VA = "0x186E0DC80")]
		private void MEEHFMNGFEN(string LDCKBFKFIKC, string HCPAOILCJCB, bool ILJGCHMLPKC = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6E10DF0", Offset = "0x6E101F0", VA = "0x186E10DF0")]
			public void ACFAONCEDBE(Dictionary<string, object> PJCBCKLBNFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6E19F40", Offset = "0x6E19340", VA = "0x186E19F40")]
			public void ACFAONCEDBE(Dictionary<string, object> JGIKNIBNCEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE735E0", Offset = "0xE729E0", VA = "0x180E735E0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E6C0", Offset = "0x6E0DAC0", VA = "0x186E0E6C0")]
		public static PEDDEDHHDBJ KOPOAAAOIOD(string GKEHKEEIHAE, string EOJIEKDCDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E910", Offset = "0x6E0DD10", VA = "0x186E0E910")]
		protected AmplitudeAnalyticsIdentifyMessage(string GKEHKEEIHAE, string EOJIEKDCDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E630", Offset = "0x6E0DA30", VA = "0x186E0E630")]
		public Dictionary<string, object> KCEKOENOIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E260", Offset = "0x6E0D660", VA = "0x186E0E260", Slot = "4")]
		protected virtual Dictionary<string, object> ECNLLAPNNHI(Dictionary<string, object> BMJLGHPDHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E870", Offset = "0x6E0DC70", VA = "0x186E0E870")]
		protected void NMDIDANPADG(string LDCKBFKFIKC, Dictionary<string, object> INMKPKMFBDH, Dictionary<string, object> AHPFIBINFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E780", Offset = "0x6E0DB80", VA = "0x186E0E780")]
		protected void LGGPOLCCIIP(string LDCKBFKFIKC, string HCPAOILCJCB, Dictionary<string, object> ONNHFDIPJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E5A0", Offset = "0x6E0D9A0", VA = "0x186E0E5A0", Slot = "5")]
		public virtual void HIHLDBBIKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E7F0", Offset = "0x6E0DBF0", VA = "0x186E0E7F0", Slot = "6")]
		public virtual void NBNOGKPBDNI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PEDDEDHHDBJ : FOMCPLCEEJL<AmplitudeAnalyticsIdentifyMessage, PEDDEDHHDBJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override PEDDEDHHDBJ AADFMMBMIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MNKCOJOIANP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E198D0", Offset = "0x6E18CD0", VA = "0x186E198D0")]
	public PEDDEDHHDBJ(AmplitudeAnalyticsIdentifyMessage LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E19830", Offset = "0x6E18C30", VA = "0x186E19830", Slot = "4")]
	public override void NBNOGKPBDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FFHHMNHLDLN : FOMCPLCEEJL<AmplitudeAnalyticsEvent, FFHHMNHLDLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool JBLBMJMALBJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override FFHHMNHLDLN AADFMMBMIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JBMGJGCJOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E11B30", Offset = "0x6E10F30", VA = "0x186E11B30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E11D90", Offset = "0x6E11190", VA = "0x186E11D90")]
	public FFHHMNHLDLN(AmplitudeAnalyticsEvent LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "5")]
	public override AmplitudeAnalyticsEvent MNKCOJOIANP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E11CF0", Offset = "0x6E110F0", VA = "0x186E11CF0", Slot = "4")]
	public override void NBNOGKPBDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3020EB0", Offset = "0x30202B0", VA = "0x183020EB0")]
	public FFHHMNHLDLN BHOANFGMAPJ<T>(string LKGPHBHEBBE, T[] HCPAOILCJCB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3020EB0", Offset = "0x30202B0", VA = "0x183020EB0")]
	public FFHHMNHLDLN BHOANFGMAPJ(string LKGPHBHEBBE, string[] HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3020C00", Offset = "0x3020000", VA = "0x183020C00")]
	public FFHHMNHLDLN BHOANFGMAPJ<T>(string LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E11A10", Offset = "0x6E10E10", VA = "0x186E11A10")]
	public FFHHMNHLDLN BHOANFGMAPJ(string LKGPHBHEBBE, long HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E11A90", Offset = "0x6E10E90", VA = "0x186E11A90")]
	public FFHHMNHLDLN BHOANFGMAPJ(string LKGPHBHEBBE, string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E11B00", Offset = "0x6E10F00", VA = "0x186E11B00")]
	public FFHHMNHLDLN FLEIEDMIEOA(string LKGPHBHEBBE, object? HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E11B50", Offset = "0x6E10F50", VA = "0x186E11B50")]
	public FFHHMNHLDLN HMOKJICEDEK(string LKGPHBHEBBE, string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E11BF0", Offset = "0x6E10FF0", VA = "0x186E11BF0")]
	private FFHHMNHLDLN IDILJKHHNJE(string LKGPHBHEBBE, object HCPAOILCJCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PIOHBCKPPCI : FFHHMNHLDLN
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E11D90", Offset = "0x6E11190", VA = "0x186E11D90")]
	public PIOHBCKPPCI(AmplitudeAnalyticsEvent LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E19920", Offset = "0x6E18D20", VA = "0x186E19920", Slot = "4")]
	public override void NBNOGKPBDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class FOMCPLCEEJL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FOMCPLCEEJL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M LNICHECHJFC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR AADFMMBMIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public FOMCPLCEEJL(M LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x40B2DA0", Offset = "0x40B21A0", VA = "0x1840B2DA0")]
	public BLDR CGLNJHPCKPP(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LEKFPEOOLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x40B2ED0", Offset = "0x40B22D0", VA = "0x1840B2ED0")]
	public BLDR EOMJGBCMIJM(AmplitudeAnalyticsIdentifyMessage.RevenueData KMJENNDGDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x40B2E20", Offset = "0x40B2220", VA = "0x1840B2E20")]
	public BLDR DMMADIKBABH(string LKGPHBHEBBE, string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3184530", Offset = "0x3183930", VA = "0x183184530")]
	public BLDR DMMADIKBABH<T>(string LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NBNOGKPBDNI();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x40B2DF0", Offset = "0x40B21F0", VA = "0x1840B2DF0")]
	internal static string CHNMIAJDPNG(string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40B2F20", Offset = "0x40B2320", VA = "0x1840B2F20")]
	private BLDR KPMFHDJFPGC(string LKGPHBHEBBE, object HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MNKCOJOIANP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LLPIKLIELLM : LOMBHALLIDK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ELLOCKOFFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<AOCAAHLCPKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LLPIKLIELLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E10F70", Offset = "0x6E10370", VA = "0x186E10F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E119A0", Offset = "0x6E10DA0", VA = "0x186E119A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient EIDOHADAEBL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E13BF0", Offset = "0x6E12FF0", VA = "0x186E13BF0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void HBDGMCJELEB(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E13DD0", Offset = "0x6E131D0", VA = "0x186E13DD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLPIKLIELLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E13C60", Offset = "0x6E13060", VA = "0x186E13C60", Slot = "4")]
	[AsyncStateMachine(typeof(ELLOCKOFFMH))]
	public Task<AOCAAHLCPKC> INNKFLKLOAD(string GONCFJCDCMO, string FHNGDFIINPB, string JEKLPKKPOLA, string AGIOEOLOONE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LDKGFIEDLFD : LOMBHALLIDK
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JBHMDDFDCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<AOCAAHLCPKC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JBHMDDFDCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E12A30", Offset = "0x6E11E30", VA = "0x186E12A30")]
		internal void AKNIIFFIHHG(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct NLJMDKBHPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<AOCAAHLCPKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<AOCAAHLCPKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E15EE0", Offset = "0x6E152E0", VA = "0x186E15EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E16430", Offset = "0x6E15830", VA = "0x186E16430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void AHDPIOJPDIL(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[RecRoom.NoEngine.Common.Preserve]
	public LDKGFIEDLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E13A90", Offset = "0x6E12E90", VA = "0x186E13A90", Slot = "4")]
	[AsyncStateMachine(typeof(NLJMDKBHPBD))]
	public Task<AOCAAHLCPKC> INNKFLKLOAD(string GONCFJCDCMO, string FHNGDFIINPB, string JEKLPKKPOLA, string AGIOEOLOONE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BNECJFIMOMC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LPEELJBGMAF;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EA80", Offset = "0x6E0DE80", VA = "0x186E0EA80")]
	internal static bool JLBAJNOEGGB(string LDCKBFKFIKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LOMBHALLIDK
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AOCAAHLCPKC> INNKFLKLOAD(string GONCFJCDCMO, string FHNGDFIINPB, string JEKLPKKPOLA, string AGIOEOLOONE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AOCAAHLCPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int AOFGCLIAFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string GBADKPBHIJN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x11A7440", Offset = "0x11A6840", VA = "0x1811A7440")]
	public AOCAAHLCPKC(int GLGLHOCJLGM, string HKAPIAAAADJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum BKCCMAELHJH
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MAPNMJOHMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long HAMABNMLECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private FFHHMNHLDLN EBHMEHANGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool OJNGAFLENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float BFKDOBHBEFE;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E14B90", Offset = "0x6E13F90", VA = "0x186E14B90")]
	public MAPNMJOHMFH(string HNICMIPKFDF, float BFKDOBHBEFE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x312E5E0", Offset = "0x312D9E0", VA = "0x18312E5E0")]
	public void BHOANFGMAPJ<T>(string LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E148F0", Offset = "0x6E13CF0", VA = "0x186E148F0")]
	public void BHOANFGMAPJ(string LKGPHBHEBBE, string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E14800", Offset = "0x6E13C00", VA = "0x186E14800")]
	public void AMPEMFGNNAO(string HDELEDDEFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E14970", Offset = "0x6E13D70", VA = "0x186E14970")]
	public void IPEKCECEFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E14A30", Offset = "0x6E13E30", VA = "0x186E14A30")]
	private void OIKCFDEJGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E14B40", Offset = "0x6E13F40", VA = "0x186E14B40")]
	private bool PBMJIOHECCC()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum DLFEIJNNFDN
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private DLFEIJNNFDN parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public DLFEIJNNFDN Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
			get
			{
				return default(DLFEIJNNFDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4100", Offset = "0x8F3500", VA = "0x1808F4100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A0B0", Offset = "0x6E194B0", VA = "0x186E1A0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class BEHJDKAIKCD : KPIDKLDELAH, BGMEGBODLEK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void DBHHEABLFPO(BFJHECEPFJL IGNLBFPCAFJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly EFIMKFDAKIF EGNHBDMABIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly DBHHEABLFPO OPPKJEBDDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string EDEJNEBHCGN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string JCNLHJINDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x162D0D0", Offset = "0x162C4D0", VA = "0x18162D0D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MMLPDAEIIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E9D0", Offset = "0x6E0DDD0", VA = "0x186E0E9D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FIDHIENMMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E9F0", Offset = "0x6E0DDF0", VA = "0x186E0E9F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> LBKIDFLFGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x162D0B0", Offset = "0x162C4B0", VA = "0x18162D0B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EA10", Offset = "0x6E0DE10", VA = "0x186E0EA10")]
	public BEHJDKAIKCD(EFIMKFDAKIF JAGODFHKNAI, string DOOFLMBDDLC, [Optional] DBHHEABLFPO JIEHADBBIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2DCB670", Offset = "0x2DCAA70", VA = "0x182DCB670", Slot = "8")]
	public T AFFELPLAAIM<T>(string LDCKBFKFIKC, T EKFBHIJFHMA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NMPKEJNGEEO : PBMDMFNAGKG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct LNMGKNCFFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public KDGIKGOPJAJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public NMPKEJNGEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E13E50", Offset = "0x6E13250", VA = "0x186E13E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E147A0", Offset = "0x6E13BA0", VA = "0x186E147A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AOOIMONHOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6E07220", Offset = "0x6E06620", VA = "0x186E07220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6E073E0", Offset = "0x6E067E0", VA = "0x186E073E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PPELDGLAAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KDGIKGOPJAJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NMPKEJNGEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6E19AD0", Offset = "0x6E18ED0", VA = "0x186E19AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6E19EE0", Offset = "0x6E192E0", VA = "0x186E19EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JJGIFNKENPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public NMPKEJNGEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KDGIKGOPJAJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6E12F20", Offset = "0x6E12320", VA = "0x186E12F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E132D0", Offset = "0x6E126D0", VA = "0x186E132D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IReadOnlyDictionary<string, JCNIOAFANOH> EEPLPOIEEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool ABMEPBPFCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool ICNDDFDHPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> CKHFKAPOGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private TaskCompletionSource<bool> AAEOFKEPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly SemaphoreSlim EINGFBFCGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private LHPEDMOPCAE EFKLCEBGMFI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task MMFJBFCGMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E164E0", Offset = "0x6E158E0", VA = "0x186E164E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OOOOCBMHIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EPINGDJAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xF5E030", Offset = "0xF5D430", VA = "0x180F5E030", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string HOAPOAIBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E173D0", Offset = "0x6E167D0", VA = "0x186E173D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public BNHIOPFEMDG GFEFKGJHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E18000", Offset = "0x6E17400", VA = "0x186E18000", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MOFAIOHHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E17480", Offset = "0x6E16880", VA = "0x186E17480", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E16AD0", Offset = "0x6E15ED0", VA = "0x186E16AD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PMNGDFNADLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E173E0", Offset = "0x6E167E0", VA = "0x186E173E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E17F60", Offset = "0x6E17360", VA = "0x186E17F60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KNCLCOEHAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E16B70", Offset = "0x6E15F70", VA = "0x186E16B70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E165D0", Offset = "0x6E159D0", VA = "0x186E165D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<BFJHECEPFJL> NDEDLNPPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E16910", Offset = "0x6E15D10", VA = "0x186E16910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E18030", Offset = "0x6E17430", VA = "0x186E18030", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E16670", Offset = "0x6E15A70", VA = "0x186E16670", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E180E0", Offset = "0x6E174E0", VA = "0x186E180E0", Slot = "12")]
	[AsyncStateMachine(typeof(LNMGKNCFFLL))]
	public Task OOJJEJPOBFE(string KLFBMIKLPDJ, [Optional] KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E16520", Offset = "0x6E15920", VA = "0x186E16520", Slot = "23")]
	[AsyncStateMachine(typeof(AOOIMONHOND))]
	public Task DLLMHCHDBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E17E60", Offset = "0x6E17260", VA = "0x186E17E60", Slot = "18")]
	[AsyncStateMachine(typeof(PPELDGLAAGG))]
	public Task MCFJIECHMAM(KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E16DF0", Offset = "0x6E161F0", VA = "0x186E16DF0")]
	private void JNJJNOMPFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E169C0", Offset = "0x6E15DC0", VA = "0x186E169C0", Slot = "19")]
	[AsyncStateMachine(typeof(JJGIFNKENPD))]
	public Task FDMBEGEMKGN(KDGIKGOPJAJ OEJDLHPPLOG, Dictionary<string, string> HJFCKKEEIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E16690", Offset = "0x6E15A90", VA = "0x186E16690", Slot = "20")]
	public bool EKLCFMMJMFN(string HMGKLIEJEGL, bool BEEOAEILPDN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E16750", Offset = "0x6E15B50", VA = "0x186E16750", Slot = "21")]
	public KPIDKLDELAH ENDLADMDPFD(string DOOFLMBDDLC, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E17030", Offset = "0x6E16430", VA = "0x186E17030")]
	private EFIMKFDAKIF KGGJCHCFIJH(string DOOFLMBDDLC, bool BEEOAEILPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E17220", Offset = "0x6E16620", VA = "0x186E17220", Slot = "22")]
	public DEBKEPCJKGC KMJHJEJPCPG(string IBFNBKMLPJP, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E16D20", Offset = "0x6E16120", VA = "0x186E16D20")]
	private EHKLCFJBGFK JKBEMEIAAFK(string IBFNBKMLPJP, bool BEEOAEILPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E17520", Offset = "0x6E16920", VA = "0x186E17520")]
	private MALLCGKCLFO LDBAKNHFHJJ(KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E16E90", Offset = "0x6E16290", VA = "0x186E16E90")]
	private MJCPEPFKDEB JPILHJCNJIF(string KLFBMIKLPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E16C10", Offset = "0x6E16010", VA = "0x186E16C10")]
	private void JGCBLDBHNBP(string DOOFLMBDDLC, EFIMKFDAKIF JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E18360", Offset = "0x6E17760", VA = "0x186E18360")]
	public NMPKEJNGEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E164A0", Offset = "0x6E158A0", VA = "0x186E164A0")]
	[CompilerGenerated]
	private void IKBNAEMOGDE(BFJHECEPFJL NOMFBHAJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E164A0", Offset = "0x6E158A0", VA = "0x186E164A0")]
	[CompilerGenerated]
	private void AKOBKOJKNKM(BFJHECEPFJL NOMFBHAJODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OLMKEMFHAOA : PBMDMFNAGKG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MLDOGINOAEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OLMKEMFHAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public KDGIKGOPJAJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E15500", Offset = "0x6E14900", VA = "0x186E15500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E15E80", Offset = "0x6E15280", VA = "0x186E15E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct GLEELPPHENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E11DE0", Offset = "0x6E111E0", VA = "0x186E11DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NMPKEJNGEEO NPNDBLIGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> CKHFKAPOGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TaskCompletionSource<bool> AAEOFKEPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Task KKJAMMDBMGM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private PBMDMFNAGKG NKEGKDFAIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E195F0", Offset = "0x6E189F0", VA = "0x186E195F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EPINGDJAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6E19480", Offset = "0x6E18880", VA = "0x186E19480", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OOOOCBMHIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6E188C0", Offset = "0x6E17CC0", VA = "0x186E188C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task MMFJBFCGMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6E184E0", Offset = "0x6E178E0", VA = "0x186E184E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string HOAPOAIBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E80", Offset = "0x6E18280", VA = "0x186E18E80", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BNHIOPFEMDG GFEFKGJHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E19440", Offset = "0x6E18840", VA = "0x186E19440", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PMNGDFNADLF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6E18EA0", Offset = "0x6E182A0", VA = "0x186E18EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6E19260", Offset = "0x6E18660", VA = "0x186E19260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MOFAIOHHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E18F40", Offset = "0x6E18340", VA = "0x186E18F40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6E18C80", Offset = "0x6E18080", VA = "0x186E18C80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KNCLCOEHAHP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6E18D20", Offset = "0x6E18120", VA = "0x186E18D20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E187F0", Offset = "0x6E17BF0", VA = "0x186E187F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BFJHECEPFJL> NDEDLNPPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6E18AB0", Offset = "0x6E17EB0", VA = "0x186E18AB0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6E19500", Offset = "0x6E18900", VA = "0x186E19500", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E19770", Offset = "0x6E18B70", VA = "0x186E19770")]
	[UnityEngine.Scripting.Preserve]
	public OLMKEMFHAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E19300", Offset = "0x6E18700", VA = "0x186E19300")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E19490", Offset = "0x6E18890", VA = "0x186E19490")]
	internal static void NFHGLPIKFBE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E18890", Offset = "0x6E17C90", VA = "0x186E18890", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E19660", Offset = "0x6E18A60", VA = "0x186E19660", Slot = "12")]
	[AsyncStateMachine(typeof(MLDOGINOAEI))]
	public Task OOJJEJPOBFE(string KLFBMIKLPDJ, [Optional] KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E19160", Offset = "0x6E18560", VA = "0x186E19160", Slot = "18")]
	public Task MCFJIECHMAM(KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E18B60", Offset = "0x6E17F60", VA = "0x186E18B60", Slot = "19")]
	public Task FDMBEGEMKGN(KDGIKGOPJAJ OEJDLHPPLOG, Dictionary<string, string> HJFCKKEEIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E188D0", Offset = "0x6E17CD0", VA = "0x186E188D0", Slot = "20")]
	public bool EKLCFMMJMFN(string HMGKLIEJEGL, bool BEEOAEILPDN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E189F0", Offset = "0x6E17DF0", VA = "0x186E189F0", Slot = "21")]
	public KPIDKLDELAH ENDLADMDPFD(string DOOFLMBDDLC, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E18DC0", Offset = "0x6E181C0", VA = "0x186E18DC0", Slot = "22")]
	public DEBKEPCJKGC KMJHJEJPCPG(string IBFNBKMLPJP, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E186E0", Offset = "0x6E17AE0", VA = "0x186E186E0", Slot = "23")]
	public Task DLLMHCHDBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E18FE0", Offset = "0x6E183E0", VA = "0x186E18FE0")]
	private static void LFJABNGFBNA(TaskCompletionSource<bool> NOJOJIMAJMM, Task DGEIPBCGMBJ, Task JNLIBKCOPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E19370", Offset = "0x6E18770", VA = "0x186E19370")]
	[AsyncStateMachine(typeof(GLEELPPHENJ))]
	private static void MKJIOOEKOAI(Task LCFJPCOMAFL, TaskCompletionSource<bool> NOJOJIMAJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xAFB410", Offset = "0xAFA810", VA = "0x180AFB410")]
	[CompilerGenerated]
	private void DNLLPPEJNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xA8B4D0", Offset = "0xA8A8D0", VA = "0x180A8B4D0")]
	[CompilerGenerated]
	private void NJENIDHCEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9AAF30", Offset = "0x9AA330", VA = "0x1809AAF30")]
	[CompilerGenerated]
	private void FMPBLODGANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E195B0", Offset = "0x6E189B0", VA = "0x186E195B0")]
	[CompilerGenerated]
	private void OHBAFMPCPGM(BFJHECEPFJL NOMFBHAJODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class MKHEKIBHGPN : DEBKEPCJKGC, BGMEGBODLEK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void JDCPPONBIJJ(BFJHECEPFJL IGNLBFPCAFJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly JDCPPONBIJJ OPPKJEBDDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly EHKLCFJBGFK CHJDHMGNEHP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string JCNLHJINDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF770", VA = "0x180A00370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6139DB0", Offset = "0x61391B0", VA = "0x186139DB0")]
	public MKHEKIBHGPN(EHKLCFJBGFK HOGNIHDLFAI, [Optional] JDCPPONBIJJ JIEHADBBIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3140F40", Offset = "0x3140340", VA = "0x183140F40", Slot = "5")]
	public T AFFELPLAAIM<T>(string LDCKBFKFIKC, T EKFBHIJFHMA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DOKMIPPFDNA
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class CPBNMBDFNMK : DOKMIPPFDNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly FMLLDCONNPO PPIMILBEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly List<LAAGLFPJPOF> CKLBCHDAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string AINHECNLKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string OICIAKBAILN;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F860", Offset = "0x6E0EC60", VA = "0x186E0F860")]
	[UsedImplicitly]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void BMOABOOGHNH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F8D0", Offset = "0x6E0ECD0", VA = "0x186E0F8D0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CPBNMBDFNMK([NotNull][CNGCCDLPGOD(null)] FMLLDCONNPO PPIMILBEIGN, [CNGCCDLPGOD(null)][NotNull] CFOKEALIDKN LNHIIMFKFLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CLAINDPNCKE : PBMDMFNAGKG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task MMFJBFCGMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EF30", Offset = "0x6E0E330", VA = "0x186E0EF30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EPINGDJAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OOOOCBMHIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string HOAPOAIBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BNHIOPFEMDG GFEFKGJHOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PMNGDFNADLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F4B0", Offset = "0x6E0E8B0", VA = "0x186E0F4B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F680", Offset = "0x6E0EA80", VA = "0x186E0F680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action MOFAIOHHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F550", Offset = "0x6E0E950", VA = "0x186E0F550", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F2E0", Offset = "0x6E0E6E0", VA = "0x186E0F2E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action KNCLCOEHAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F380", Offset = "0x6E0E780", VA = "0x186E0F380", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F050", Offset = "0x6E0E450", VA = "0x186E0F050", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<BFJHECEPFJL> NDEDLNPPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F1A0", Offset = "0x6E0E5A0", VA = "0x186E0F1A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F720", Offset = "0x6E0EB20", VA = "0x186E0F720", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[RecRoom.NoEngine.Common.Preserve]
	public CLAINDPNCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F7D0", Offset = "0x6E0EBD0", VA = "0x186E0F7D0", Slot = "12")]
	public Task OOJJEJPOBFE(string KLFBMIKLPDJ, [Optional] KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F5F0", Offset = "0x6E0E9F0", VA = "0x186E0F5F0", Slot = "18")]
	public Task MCFJIECHMAM(KDGIKGOPJAJ OEJDLHPPLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F250", Offset = "0x6E0E650", VA = "0x186E0F250", Slot = "19")]
	public Task FDMBEGEMKGN(KDGIKGOPJAJ OEJDLHPPLOG, Dictionary<string, string> HJFCKKEEIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "20")]
	public bool EKLCFMMJMFN(string HMGKLIEJEGL, bool BEEOAEILPDN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F0F0", Offset = "0x6E0E4F0", VA = "0x186E0F0F0", Slot = "21")]
	public KPIDKLDELAH ENDLADMDPFD(string DOOFLMBDDLC, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F420", Offset = "0x6E0E820", VA = "0x186E0F420", Slot = "22")]
	public DEBKEPCJKGC KMJHJEJPCPG(string IBFNBKMLPJP, bool BEEOAEILPDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EFC0", Offset = "0x6E0E3C0", VA = "0x186E0EFC0", Slot = "23")]
	public Task DLLMHCHDBGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class LHPEDMOPCAE : BNHIOPFEMDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MALLCGKCLFO DJAGNBAKIKF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IReadOnlyDictionary<string, object> IHFLLCDNHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA016D0", Offset = "0xA00AD0", VA = "0x180A016D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public LHPEDMOPCAE(MALLCGKCLFO JJKAELGCFMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FNOFCGNAJIL
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAPNMJOHMFH PDNEJDDAJEM(string HNICMIPKFDF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FNJEDMNNIPN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum KDABDLCCHMP
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long BALKCIKPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string KLEPMKJBPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string IMKDPIIHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool LGEKBHOENPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long HDGGEIFIMFK();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJBOKDHLJJ(long BLMHJOODFPE, bool ILJGCHMLPKC = true);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPMPIAGOJHG(string NOIHGGNEIML, string HHKCFLABBMA, string KONCFNJACEI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDOJAAJKBHC(string NOIHGGNEIML);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NAHCCLINKOL(string NOIHGGNEIML, string MFHIMAPFBAB, string DLBAANKFAMD);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHOKKLAKAOB(string BLNFCPHILBB, object FODBEDBEHAI, object FLALBIEMKMF);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KNIMKDMGPML(KDABDLCCHMP NMGFAKFCACG, int LCEJFEIPOIC, [Optional] PLLKDGGCDAN PPEDHDFACMP, [Optional] string EAPNJPFPNBD, [Optional] string PLAICKAFAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OKMBLBCEMHG(PLLKDGGCDAN PPEDHDFACMP, long FOBPNIBLBEO, long BDLNGGCAHDF, int BKNBBMGNPBE, string EAPNJPFPNBD, int LCEJFEIPOIC);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KDONAECHCMH(PLLKDGGCDAN PPEDHDFACMP, bool BIDPAAHCAAA, [Optional] string PLAICKAFAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GJOHGHHDIBA(PLLKDGGCDAN PPEDHDFACMP, bool BIDPAAHCAAA, [Optional] string PLAICKAFAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KIOPHDIKICH(PLLKDGGCDAN PPEDHDFACMP, bool BIDPAAHCAAA, [Optional] string PLAICKAFAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBJCKNGAEJI(long GGLEGKBAGLC, string BEDKGAJALEA);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface APKLAEDOFEG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string CMENLPCCNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
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
