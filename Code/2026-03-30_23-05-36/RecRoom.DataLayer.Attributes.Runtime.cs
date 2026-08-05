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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A1C90", Offset = "0x84A0A90", VA = "0x1884A1C90")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public AlsoBindServiceAs(Type bindType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Method)]
	public class CleanupBetweenRooms : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F11FF0", Offset = "0x7F10DF0", VA = "0x187F11FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2154DA0", Offset = "0x2153BA0", VA = "0x182154DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2154DA0", Offset = "0x2153BA0", VA = "0x182154DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public CanDesyncAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Event)]
	internal class ChangeEventAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public ChangeEventAttribute(string propertyName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Config : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7578170", Offset = "0x7576F70", VA = "0x187578170")]
		public Config([Optional] string friendlyName, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = false)]
	public class ConfigGroupAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84A1C40", Offset = "0x84A0A40", VA = "0x1884A1C40")]
		public ConfigGroupAttribute(string group, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
	public class ConfigIgnore : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public ConfigIgnore()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Tooltip : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public Tooltip(string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal class CustomUpgradeSystemAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public CustomUpgradeSystemAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class DefaultAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute(object enumValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DefaultAttribute([Optional] string defaultExpression)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DEPRECATED_NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DEPRECATED_NetworkComponentAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DoNotGenerateComponentProperties : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public DoNotGenerateComponentProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class FieldAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public FieldAttribute(int fieldNumber)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class IsBufferAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public IsBufferAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal class Key : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public Key(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public NetworkComponentAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class NetworkEnumAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public NetworkEnumAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Interface)]
	internal class NetworkInterfaceAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public NetworkInterfaceAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkStructAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public NetworkStructAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ProtoProp : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public ProtoProp(string propName, [Optional] Type? ToV1Converter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
	public class R2OnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public R2OnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class RangeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public RangeAttribute(object min, object max)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class RegisterComponentDefault : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public RegisterComponentDefault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class SingletonComponent : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public SingletonComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	internal class RRGuidAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public RRGuidAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
	public class RuntimeOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public RuntimeOnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class SerializationOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
			public Auth()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[AttributeUsage(AttributeTargets.Property)]
		internal class Any : Attribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
			public Any()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SourceGenerate : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public SourceGenerate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class StableTypeHashAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public StableTypeHashAttribute(ulong typeHash, uint version = 0u)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class SwatchPrimaryKeyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public SwatchPrimaryKeyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface)]
	internal class TombstonedFieldsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public TombstonedFieldsAttribute(params int[] fieldIndices)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal class TombstonedVersionedTypeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public TombstonedVersionedTypeAttribute(string versionedTypeGuid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AttributeUsage(AttributeTargets.Method)]
	internal class UpgradeFromVersionAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public UpgradeFromVersionAttribute(int oldVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[AttributeUsage(AttributeTargets.Class)]
	internal class UpgraderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public UpgraderAttribute(Type type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[AttributeUsage(AttributeTargets.Class)]
	public class RemovedDuringBakingInRoomsV2 : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public RemovedDuringBakingInRoomsV2()
		{
		}
	}
}
namespace RecRoom.DataLayer.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class AlignUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private struct AlignOfHelper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public byte dummy;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public T data;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20")]
		public static int AlignOf<T>() where T : struct
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Obfuscation]
	public abstract class AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public virtual string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public virtual void SetServiceCategoryIndices(List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "6")]
		public virtual void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
		public virtual void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public virtual void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "9")]
		public virtual void RegisterComponentDefaults(IComponentDefaultRegistration registration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x33B5600", Offset = "0x33B4400", VA = "0x1833B5600")]
		protected void RegisterComponentDefault<T>(IComponentDefaultRegistration registration, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84A1A20", Offset = "0x84A0820", VA = "0x1884A1A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84A1B90", Offset = "0x84A0990", VA = "0x1884A1B90")]
		protected AssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[AttributeUsage(AttributeTargets.Assembly)]
	public class HasAssemblyIndex : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public HasAssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IComponentDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterComponentDefault(Type type, int alignment, Span<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanBind(Type bindType, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Register(Type bindType, Lifetime lifetime, object instance);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Register(Type[] bindTypes, Lifetime lifetime, ulong mask, object instance);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface ITypeRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterTypes(Type attribute, params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RegisterMethods(Type attribute, params Delegate[] delegates);
	}
	[StructLayout((LayoutKind)2, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct ServiceBitset : IComparable<ServiceBitset>, IEquatable<ServiceBitset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal uint first;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal uint second;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5129130", Offset = "0x5127F30", VA = "0x185129130")]
		public static ServiceBitset Create()
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84A2200", Offset = "0x84A1000", VA = "0x1884A2200", Slot = "4")]
		public int CompareTo(ServiceBitset other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84A2300", Offset = "0x84A1100", VA = "0x1884A2300", Slot = "5")]
		public bool Equals(ServiceBitset other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84A2230", Offset = "0x84A1030", VA = "0x1884A2230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84A1D40", Offset = "0x84A0B40", VA = "0x1884A1D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84A2550", Offset = "0x84A1350", VA = "0x1884A2550")]
		public static ServiceBitset operator |(ServiceBitset a, ServiceBitset b)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84A2340", Offset = "0x84A1140", VA = "0x1884A2340")]
		public static ServiceBitset From(int[] localIndices, List<int> globalFromLocalIndices)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84A2400", Offset = "0x84A1200", VA = "0x1884A2400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class ServiceBitsetExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84A1D40", Offset = "0x84A0B40", VA = "0x1884A1D40")]
		public static int GetHashCode([In] ServiceBitset a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84A1D10", Offset = "0x84A0B10", VA = "0x1884A1D10")]
		public static int CompareTo([In] ServiceBitset a, [In] ServiceBitset b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84A1DB0", Offset = "0x84A0BB0", VA = "0x1884A1DB0")]
		public static bool HasNone([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84A1D80", Offset = "0x84A0B80", VA = "0x1884A1D80")]
		public static bool HasAny([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84A1D50", Offset = "0x84A0B50", VA = "0x1884A1D50")]
		public static bool HasAll([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E10", Offset = "0x84A0C10", VA = "0x1884A1E10")]
		public static void Or([In] this ServiceBitset a, [In] ServiceBitset b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1DE0", Offset = "0x84A0BE0", VA = "0x1884A1DE0")]
		public static bool IsSet([In] this ServiceBitset bitset, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E20", Offset = "0x84A0C20", VA = "0x1884A1E20")]
		public static void Set(this ServiceBitset bitset, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74A5CB0", Offset = "0x74A4AB0", VA = "0x1874A5CB0")]
		public static void ClearAll(this ServiceBitset bitset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct ServiceBitsetFilter : IComparable<ServiceBitsetFilter>, IEquatable<ServiceBitsetFilter>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
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

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84A21E0", Offset = "0x84A0FE0", VA = "0x1884A21E0")]
		public ServiceBitsetFilter(ServiceBitset all, ServiceBitset any, ServiceBitset none, Mask mask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E60", Offset = "0x84A0C60", VA = "0x1884A1E60", Slot = "4")]
		public int CompareTo(ServiceBitsetFilter other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84A2170", Offset = "0x84A0F70", VA = "0x1884A2170")]
		public bool Matches([In] ServiceBitset bitset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84A2160", Offset = "0x84A0F60", VA = "0x1884A2160")]
		public bool Has(Mask value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84A2010", Offset = "0x84A0E10", VA = "0x1884A2010", Slot = "5")]
		public bool Equals(ServiceBitsetFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84A1F60", Offset = "0x84A0D60", VA = "0x1884A1F60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84A2100", Offset = "0x84A0F00", VA = "0x1884A2100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RecRoom.DataLayer.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	public class AstarNavGraphType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public AstarNavGraphType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class RenderingVolumeComponentType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public RenderingVolumeComponentType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	[Obfuscation(ApplyToMembers = false)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
