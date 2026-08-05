using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Analytics.Statsig;
using RecRoom.NoEngine.Common;
using RecRoom.PlatformNotifications;
using RecRoom.RoomLoading;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Crm
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class UGAMFWKSNVG : XGVLNTEZTTV
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		[Preserve]
		internal UGAMFWKSNVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void AZUEQJSXIZW(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void UKQUCKKESUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9939500", Offset = "0x9937F00", VA = "0x189939500", Slot = "6")]
		public void ZTCCQPWJBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9939500", Offset = "0x9937F00", VA = "0x189939500", Slot = "7")]
		public void QGDBJNMUVGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99394E0", Offset = "0x9937EE0", VA = "0x1899394E0", Slot = "8")]
		public void KBYWCGXRQXP(string a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Tested]
	public class ECLYZOSWUVJ : OGWHSNCQWGI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly XGVLNTEZTTV EYRRURTXVOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ZRGQIPZKRPW SBXXTZIUHET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly IAHZRWVLBQU XXXPVEQIBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly QQNPQQDHHHE ESVEDMLKPXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly SZCUUDZWJNL QFWGNGRTRCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ILCYLSNORBB PNMHQAWAHKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly GXIDENQQQUA VCTNXGHSMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly ISKFFBLJTUT EVXGKMTZTXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool YIGLUSHGMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CompilerGenerated]
		private Action EKTONHZBXRE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool AMNKPKWAURZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD15930", Offset = "0xD14330", VA = "0x180D15930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private bool YFXPZCZFTMV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD159D0", Offset = "0xD143D0", VA = "0x180D159D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9937FD0", Offset = "0x99369D0", VA = "0x189937FD0")]
		[Preserve]
		internal ECLYZOSWUVJ([Inject(null)][NotNull] XGVLNTEZTTV brazeAPI, [Inject(null)][NotNull] ZRGQIPZKRPW recNetAccounts, [Inject(null)][NotNull] IAHZRWVLBQU platformNotificationManager, [Inject(null)][NotNull] QQNPQQDHHHE crmManager, [Inject(null)][NotNull] SZCUUDZWJNL roomManager, [Inject(null)][NotNull] ILCYLSNORBB gameConfigsProvider, [Inject(null)][NotNull] GXIDENQQQUA statsig, [Inject(null)][NotNull] ISKFFBLJTUT analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9937180", Offset = "0x9935B80", VA = "0x189937180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9937830", Offset = "0x9936230", VA = "0x189937830")]
		private void UJUPQFLXXPZ(PlatformNotification a, PlatformNotificationHandlerContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9937930", Offset = "0x9936330", VA = "0x189937930")]
		internal void YETCDKALSAZ(CrmAssignmentDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9937710", Offset = "0x9936110", VA = "0x189937710", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9937300", Offset = "0x9935D00", VA = "0x189937300")]
		private void LUNFBJLDYHH(RoomEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class SFKUIRKQPCF : QQNPQQDHHHE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GNPTGIXNRHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CrmAssignmentDTO BADMPCDGVVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Task JATENAACFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public bool ZIXHSZBLWJW;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9938490", Offset = "0x9936E90", VA = "0x189938490")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GNPTGIXNRHF()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <TryInitialize>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public SFKUIRKQPCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter<CrmAssignmentDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9939040", Offset = "0x9937A40", VA = "0x189939040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9939480", Offset = "0x9937E80", VA = "0x189939480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly ZRGQIPZKRPW SBXXTZIUHET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LLALNCNIQBJ KRBTCWXKVBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GNPTGIXNRHF VQSNWOYMZRZ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal bool ZIXHSZBLWJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9938EE0", Offset = "0x99378E0", VA = "0x189938EE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x99384D0", Offset = "0x9936ED0", VA = "0x1899384D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal CrmAssignmentDTO BADMPCDGVVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7213A70", Offset = "0x7212470", VA = "0x187213A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9938670", Offset = "0x9937070", VA = "0x189938670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Task IDJFWWXWBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x18DE1F0", Offset = "0x18DCBF0", VA = "0x1818DE1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9938F00", Offset = "0x9937900", VA = "0x189938F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZMOTPBGWWMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9938E40", Offset = "0x9937840", VA = "0x189938E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CrmType BFGLTVYGZZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9938BC0", Offset = "0x99375C0", VA = "0x189938BC0", Slot = "4")]
			get
			{
				return default(CrmType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CrmAssignmentDTO> YETCDKALSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9938B10", Offset = "0x9937510", VA = "0x189938B10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99386A0", Offset = "0x99370A0", VA = "0x1899386A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9938F30", Offset = "0x9937930", VA = "0x189938F30")]
		[Preserve]
		internal SFKUIRKQPCF([Inject(null)] ZRGQIPZKRPW recNetAccounts, [Inject(null)] LLALNCNIQBJ recNetCrmService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99385D0", Offset = "0x9936FD0", VA = "0x1899385D0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9938750", Offset = "0x9937150", VA = "0x189938750", Slot = "8")]
		public Task Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9938C40", Offset = "0x9937640", VA = "0x189938C40")]
		[AsyncStateMachine(typeof(<TryInitialize>d__23))]
		private Task PWQMMLQPOCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9938D10", Offset = "0x9937710", VA = "0x189938D10", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99384F0", Offset = "0x9936EF0", VA = "0x1899384F0")]
		[CompilerGenerated]
		private object DYOBJSUZUVZ()
		{
			return null;
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
