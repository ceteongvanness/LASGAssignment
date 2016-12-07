namespace Ass5.Workflows {
    
    #line 18 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 19 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 20 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 21 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 22 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\et.cheah\documents\visual studio 2015\Projects\Ass5\Business\Ass5.Workflows\TaskWorkflowService.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class TaskWorkflowService : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext0 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext1 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext2 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext3 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext4 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext5 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TaskWorkflowService_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 1);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext6 = ((TaskWorkflowService_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext0 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext1 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext2 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext3 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext4 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext5 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                TaskWorkflowService_TypedDataContext2_ForReadOnly valDataContext6 = new TaskWorkflowService_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "_handle") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_handle") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_handle") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_handle") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new TimeSpan(0,2,0)") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "_applyResult") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (TaskWorkflowService_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new TaskWorkflowService_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext1 : TaskWorkflowService_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return TaskWorkflowService_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext1_ForReadOnly : TaskWorkflowService_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return TaskWorkflowService_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext2 : TaskWorkflowService_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle _handle {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected Ass5.Entities.Task _applyResult {
                get {
                    return ((Ass5.Entities.Task)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected Ass5.Entities.Task _task {
                get {
                    return ((Ass5.Entities.Task)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected Ass5.Entities.TaskLog _taskLog {
                get {
                    return ((Ass5.Entities.TaskLog)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "_handle") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "_applyResult") 
                            || (locationReferences[(offset + 1)].Type != typeof(Ass5.Entities.Task)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "_task") 
                            || (locationReferences[(offset + 2)].Type != typeof(Ass5.Entities.Task)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "_taskLog") 
                            || (locationReferences[(offset + 3)].Type != typeof(Ass5.Entities.TaskLog)))) {
                    return false;
                }
                return TaskWorkflowService_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TaskWorkflowService_TypedDataContext2_ForReadOnly : TaskWorkflowService_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TaskWorkflowService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TaskWorkflowService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.ServiceModel.Activities.CorrelationHandle _handle {
                get {
                    return ((System.ServiceModel.Activities.CorrelationHandle)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected Ass5.Entities.Task _applyResult {
                get {
                    return ((Ass5.Entities.Task)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected Ass5.Entities.Task _task {
                get {
                    return ((Ass5.Entities.Task)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected Ass5.Entities.TaskLog _taskLog {
                get {
                    return ((Ass5.Entities.TaskLog)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 66 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                _handle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr0Get() {
                
                #line 66 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                _handle;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 122 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                          _handle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr1Get() {
                
                #line 122 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                          _handle;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 166 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                          _handle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr2Get() {
                
                #line 166 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                          _handle;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 210 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.ServiceModel.Activities.CorrelationHandle>> expression = () => 
                          _handle;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.ServiceModel.Activities.CorrelationHandle @__Expr3Get() {
                
                #line 210 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                          _handle;
                
                #line default
                #line hidden
            }
            
            public System.ServiceModel.Activities.CorrelationHandle ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 243 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                      new TimeSpan(0,2,0);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr4Get() {
                
                #line 243 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                      new TimeSpan(0,2,0);
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 251 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Ass5.Entities.Task>> expression = () => 
                        _applyResult;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Ass5.Entities.Task @__Expr5Get() {
                
                #line 251 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                        _applyResult;
                
                #line default
                #line hidden
            }
            
            public Ass5.Entities.Task ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 256 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Ass5.Entities.TaskLog>> expression = () => 
                        null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Ass5.Entities.TaskLog @__Expr6Get() {
                
                #line 256 "C:\USERS\ET.CHEAH\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\ASS5\BUSINESS\ASS5.WORKFLOWS\TASKWORKFLOWSERVICE.XAML"
                return 
                        null;
                
                #line default
                #line hidden
            }
            
            public Ass5.Entities.TaskLog ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "_handle") 
                            || (locationReferences[(offset + 0)].Type != typeof(System.ServiceModel.Activities.CorrelationHandle)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "_applyResult") 
                            || (locationReferences[(offset + 1)].Type != typeof(Ass5.Entities.Task)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "_task") 
                            || (locationReferences[(offset + 2)].Type != typeof(Ass5.Entities.Task)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "_taskLog") 
                            || (locationReferences[(offset + 3)].Type != typeof(Ass5.Entities.TaskLog)))) {
                    return false;
                }
                return TaskWorkflowService_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
