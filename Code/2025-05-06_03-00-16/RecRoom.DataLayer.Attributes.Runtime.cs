using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1850", Offset = "0x7AB0050", VA = "0x187AB1850")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class DependsOn : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DependsOn()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public class InitServiceAfter : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type PriorService
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public InitServiceAfter(Type prior)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	public abstract class RegisterType : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		protected RegisterType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public class AlsoBindServiceAs : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Type BindType
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public AlsoBindServiceAs(Type bindType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Method)]
	public class CleanupBetweenRooms : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public CleanupBetweenRooms()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class RegisterService : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type BindType
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75DC930", Offset = "0x75DB130", VA = "0x1875DC930")]
		public RegisterService(Type bindType, params string[] categories)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class ServiceLifetime : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Lifetime Lifetime
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2112550", Offset = "0x2110D50", VA = "0x182112550")]
		public ServiceLifetime(Lifetime lifetime)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class SystemEnabledLifetimeAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Lifetime Lifetime
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2112550", Offset = "0x2110D50", VA = "0x182112550")]
		public SystemEnabledLifetimeAttribute(Lifetime lifetime)
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum Lifetime
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Application,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		LoginSession,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		PhotonRoom,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		OMRoom,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LoadInstance,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		COUNT
	}
}
namespace RecRoom.Analyzers
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class NullCheckWithIsNullOrDestroyedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public NullCheckWithIsNullOrDestroyedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Interface)]
	public class CanDesyncAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public CanDesyncAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Event)]
	internal class ChangeEventAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public ChangeEventAttribute(string propertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Config : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BA27C0", Offset = "0x6BA0FC0", VA = "0x186BA27C0")]
		public Config([Optional] string friendlyName, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = false)]
	public class ConfigGroupAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1800", Offset = "0x7AB0000", VA = "0x187AB1800")]
		public ConfigGroupAttribute(string group, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
	public class ConfigIgnore : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public ConfigIgnore()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Tooltip : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public Tooltip(string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal class CustomUpgradeSystemAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public CustomUpgradeSystemAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class DefaultAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute(object enumValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DefaultAttribute([Optional] string defaultExpression)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DEPRECATED_NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DEPRECATED_NetworkComponentAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DoNotGenerateComponentProperties : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public DoNotGenerateComponentProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class FieldAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public FieldAttribute(int fieldNumber)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class IsBufferAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsBufferAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal class Key : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public Key(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public NetworkComponentAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class NetworkEnumAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public NetworkEnumAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Interface)]
	internal class NetworkInterfaceAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public NetworkInterfaceAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkStructAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public NetworkStructAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ProtoProp : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public ProtoProp(string propName, [Optional] Type? ToV1Converter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
	public class R2OnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public R2OnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class RangeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public RangeAttribute(object min, object max)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class RegisterComponentDefault : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public RegisterComponentDefault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class SingletonComponent : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public SingletonComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	internal class RRGuidAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public RRGuidAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class RuntimeOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public RuntimeOnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class SerializationOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public SerializationOnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class Set
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[AttributeUsage(AttributeTargets.Property)]
		internal class Auth : Attribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
			public Auth()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SourceGenerate : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public SourceGenerate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal class StableTypeHashAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public StableTypeHashAttribute(ulong typeHash, uint version = 0u)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class SwatchPrimaryKeyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public SwatchPrimaryKeyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface)]
	internal class TombstonedFieldsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public TombstonedFieldsAttribute(params int[] fieldIndices)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal class TombstonedVersionedTypeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public TombstonedVersionedTypeAttribute(string versionedTypeGuid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[AttributeUsage(AttributeTargets.Method)]
	internal class UpgradeFromVersionAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public UpgradeFromVersionAttribute(int oldVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AttributeUsage(AttributeTargets.Class)]
	internal class UpgraderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public UpgraderAttribute(Type type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[AttributeUsage(AttributeTargets.Class)]
	public class RemovedDuringBakingInRoomsV2 : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public RemovedDuringBakingInRoomsV2()
		{
		}
	}
}
namespace RecRoom.DataLayer.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class AlignUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private struct AlignOfHelper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public byte dummy;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public T data;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xBB51B0", Offset = "0xBB39B0", VA = "0x180BB51B0")]
		public static int AlignOf<T>() where T : struct
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Obfuscation]
	public abstract class AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public virtual string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public virtual void SetServiceCategoryIndices(List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
		public virtual void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		public virtual void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "8")]
		public virtual void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
		public virtual void RegisterComponentDefaults(IComponentDefaultRegistration registration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x342F5E0", Offset = "0x342DDE0", VA = "0x18342F5E0")]
		protected void RegisterComponentDefault<T>(IComponentDefaultRegistration registration, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AB14E0", Offset = "0x7AAFCE0", VA = "0x187AB14E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1760", Offset = "0x7AAFF60", VA = "0x187AB1760")]
		protected AssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[AttributeUsage(AttributeTargets.Assembly)]
	public class HasAssemblyIndex : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public HasAssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface IComponentDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterComponentDefault(Type type, int alignment, Span<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanBind(Type bindType, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Register(Type bindType, Lifetime lifetime, object instance);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Register(Type[] bindTypes, Lifetime lifetime, ulong mask, object instance);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface ITypeRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterTypes(Type attribute, params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RegisterMethods(Type attribute, params Delegate[] delegates);
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct ServiceBitset : IComparable<ServiceBitset>, IEquatable<ServiceBitset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal uint first;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal uint second;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1DE0", Offset = "0x7AB05E0", VA = "0x187AB1DE0")]
		public static ServiceBitset Create()
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1DB0", Offset = "0x7AB05B0", VA = "0x187AB1DB0", Slot = "4")]
		public int CompareTo(ServiceBitset other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1EC0", Offset = "0x7AB06C0", VA = "0x187AB1EC0", Slot = "5")]
		public bool Equals(ServiceBitset other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1DF0", Offset = "0x7AB05F0", VA = "0x187AB1DF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1900", Offset = "0x7AB0100", VA = "0x187AB1900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2100", Offset = "0x7AB0900", VA = "0x187AB2100")]
		public static ServiceBitset operator |(ServiceBitset a, ServiceBitset b)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1F00", Offset = "0x7AB0700", VA = "0x187AB1F00")]
		public static ServiceBitset From(int[] localIndices, List<int> globalFromLocalIndices)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1FC0", Offset = "0x7AB07C0", VA = "0x187AB1FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class ServiceBitsetExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1900", Offset = "0x7AB0100", VA = "0x187AB1900")]
		public static int GetHashCode([In] ServiceBitset a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AB18D0", Offset = "0x7AB00D0", VA = "0x187AB18D0")]
		public static int CompareTo([In] ServiceBitset a, [In] ServiceBitset b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1970", Offset = "0x7AB0170", VA = "0x187AB1970")]
		public static bool HasNone([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1940", Offset = "0x7AB0140", VA = "0x187AB1940")]
		public static bool HasAny([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1910", Offset = "0x7AB0110", VA = "0x187AB1910")]
		public static bool HasAll([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB19D0", Offset = "0x7AB01D0", VA = "0x187AB19D0")]
		public static void Or([In] this ServiceBitset a, [In] ServiceBitset b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB19A0", Offset = "0x7AB01A0", VA = "0x187AB19A0")]
		public static bool IsSet([In] this ServiceBitset bitset, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB19E0", Offset = "0x7AB01E0", VA = "0x187AB19E0")]
		public static void Set(this ServiceBitset bitset, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFBD0", Offset = "0x6ACE3D0", VA = "0x186ACFBD0")]
		public static void ClearAll(this ServiceBitset bitset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct ServiceBitsetFilter : IComparable<ServiceBitsetFilter>, IEquatable<ServiceBitsetFilter>
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[Flags]
		public enum Mask
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			All = 1,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Any = 2,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			None = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ServiceBitset all;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ServiceBitset any;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ServiceBitset none;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Mask mask;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1D90", Offset = "0x7AB0590", VA = "0x187AB1D90")]
		public ServiceBitsetFilter(ServiceBitset all, ServiceBitset any, ServiceBitset none, Mask mask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1A20", Offset = "0x7AB0220", VA = "0x187AB1A20", Slot = "4")]
		public int CompareTo(ServiceBitsetFilter other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1D20", Offset = "0x7AB0520", VA = "0x187AB1D20")]
		public bool Matches([In] ServiceBitset bitset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x793E260", Offset = "0x793CA60", VA = "0x18793E260")]
		public bool Has(Mask value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1BD0", Offset = "0x7AB03D0", VA = "0x187AB1BD0", Slot = "5")]
		public bool Equals(ServiceBitsetFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1B20", Offset = "0x7AB0320", VA = "0x187AB1B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1CC0", Offset = "0x7AB04C0", VA = "0x187AB1CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RecRoom.DataLayer.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	public class AstarNavGraphType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public AstarNavGraphType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	public class RenderingVolumeComponentType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public RenderingVolumeComponentType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Obfuscation(ApplyToMembers = false)]
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public PreserveAttribute()
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
