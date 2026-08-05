using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class BRMSZAJTATI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[AttributeUsage(AttributeTargets.Method)]
		[UsedImplicitly]
		public sealed class Root : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			[Conditional("UNITY_EDITOR")]
			public sealed class EditorOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
			}

			[Cpp2IlInjected.Token(Token = "0x2000005")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			public sealed class GameOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
				[Cpp2IlInjected.Token(Token = "0x6000002")]
				[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
				public GameOnly()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public Root()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[AttributeUsage(AttributeTargets.Method)]
		[UsedImplicitly]
		public sealed class Session : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			[Conditional("UNITY_EDITOR")]
			public sealed class EditorOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			public sealed class GameOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
				[Cpp2IlInjected.Token(Token = "0x6000004")]
				[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
				public GameOnly()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public Session()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[AttributeUsage(AttributeTargets.Method)]
		[UsedImplicitly]
		public sealed class Room : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			[Conditional("UNITY_EDITOR")]
			public sealed class EditorOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[AttributeUsage(AttributeTargets.Method)]
			[UsedImplicitly]
			public sealed class GameOnly : RecRoom.DataLayer.Attributes.PreserveAttribute
			{
				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
				public GameOnly()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public Room()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum DiContainerType
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Session,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Room
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RRBeforeAssemblyReloadMethodAttribute : RecRoom.NoEngine.Common.PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96821A0", Offset = "0x9680BA0", VA = "0x1896821A0")]
		public RRBeforeAssemblyReloadMethodAttribute(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RRPostPlayModeMethodAttribute : RecRoom.NoEngine.Common.PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly PostPlayModePhase TeardownPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int Priority;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96821D0", Offset = "0x9680BD0", VA = "0x1896821D0")]
		public RRPostPlayModeMethodAttribute(PostPlayModePhase teardownPhase = PostPlayModePhase.ExitingPlayMode, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum PostPlayModePhase
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ExitingPlayMode,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		EnteredEditMode,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		EnteredEditModeNextFrame
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.Method)]
	public class RRPrePlayModeMethodAttribute : RecRoom.NoEngine.Common.PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
		public RRPrePlayModeMethodAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class RRRuntimeInitializeMethod : RecRoom.DataLayer.Attributes.PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class SubsystemRegistration : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public SubsystemRegistration()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class AfterAssembliesLoaded : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public AfterAssembliesLoaded()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class BeforeSplashScreen : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class BeforeSceneLoad : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public BeforeSceneLoad()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class AfterSceneLoad : RecRoom.DataLayer.Attributes.PreserveAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
			public AfterSceneLoad()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E88A70", Offset = "0x2E87470", VA = "0x182E88A70")]
		public RRRuntimeInitializeMethod()
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
