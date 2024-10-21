using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures.Model;
using System.IO;
using Tekla.Structures.Dialog;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;
using System.Linq;
using System.Drawing;
using RenderData;
using System.Threading.Tasks;
using System.Reflection.Emit;



namespace PadFootingCreator
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<string, Action> optionActions;
        private readonly Model MyModel;

        #region Private functions for resizing the form controls

        private Size formOriginalSize;

        private Rectangle recLabelSpacingX;
        private Rectangle recLabelSpacingY;
        private Rectangle recLabelNumPadsX;
        private Rectangle recLabelNumPadsY;
        private Rectangle recLabelHeight;
        private Rectangle recNumPadsXInput;
        private Rectangle recNumPadsYInput;
        private Rectangle recSpacingXInput;
        private Rectangle recSpacingYInput;
        private Rectangle recHeightInput;
        private Rectangle recColumnSettingsLabel;
        private Rectangle recBeamSettingsLabel;
        private Rectangle recLoadColumnSettings;
        private Rectangle recLoadBeamSettings;
        private Rectangle recLabelJobNumber;
        private Rectangle recLabelJobName;
        private Rectangle recLabelJobBuilder;
        private Rectangle recLabelJobDescription;
        private Rectangle recLabelJobDesigner;
        private Rectangle recPostcodeLabel;
        private Rectangle recLabelInfo1;
        private Rectangle recJobNumberText;
        private Rectangle recJobNameText;
        private Rectangle recJobBuilderText;
        private Rectangle recJobDescription;
        private Rectangle recJobDesignerText;
        private Rectangle recJobPostCodeText;
        private Rectangle recJobInfo1;
        private Rectangle recCreatePadFootingButton;
        private Rectangle recComboBox1;
        private Rectangle recLabelOption;
        private Rectangle recInsertJobDescriptionButton;
        private Rectangle recGridInsertButton;


#endregion Private functions




        public Form1()
        {
            InitializeComponent();
            this.Resize += this.Form1_Resize;
            //this.Resize += this.Form1_Resize;
            //this.Resize += new System.EventHandler(this.Form1_Resize);


            formOriginalSize = this.Size;
            #region some other rectangular declarations for resizing

            recLabelSpacingX = new Rectangle(LabelSpacingX.Location, LabelSpacingX.Size);
            recLabelSpacingY = new Rectangle(LabelSpacingY.Location, LabelSpacingY.Size);
            recLabelNumPadsX = new Rectangle(LabelNumberPadsX.Location, LabelNumberPadsX.Size);
            recLabelNumPadsY = new Rectangle(LabelNumberPadsY.Location, LabelNumberPadsY.Size);
            recLabelHeight = new Rectangle(LabelHeight.Location, LabelHeight.Size);
            recSpacingXInput = new Rectangle(SpacingXInput.Location, SpacingXInput.Size);
            recSpacingYInput = new Rectangle(SpacingYInput.Location, SpacingYInput.Size);
            recNumPadsXInput = new Rectangle(NumPadsXInput.Location, NumPadsXInput.Size);
            recNumPadsYInput = new Rectangle(NumPadsYInput.Location, NumPadsYInput.Size);
            recHeightInput = new Rectangle(HeightInput.Location, HeightInput.Size);
            recColumnSettingsLabel = new Rectangle(ColumnSettingsLabel.Location, ColumnSettingsLabel.Size);
            recBeamSettingsLabel = new Rectangle(BeamSettingsLabel.Location, BeamSettingsLabel.Size);
            recLoadColumnSettings = new Rectangle(LoadColumnSettings.Location, LoadColumnSettings.Size);
            recLoadBeamSettings = new Rectangle(LoadBeamSettings.Location, LoadBeamSettings.Size);
            recLabelJobNumber = new Rectangle(LabelJobNumber.Location, LabelJobNumber.Size);
            recLabelJobName = new Rectangle(LabelJobName.Location, LabelJobName.Size);
            recLabelJobBuilder = new Rectangle(LabelJobBuilder.Location, LabelJobBuilder.Size);
            recLabelJobDescription = new Rectangle(LabelJobDescription.Location, LabelJobDescription.Size);
            recLabelJobDesigner = new Rectangle(LabelJobDesigner.Location, LabelJobDesigner.Size);
            recPostcodeLabel = new Rectangle(PostcodeLabel.Location, PostcodeLabel.Size);
            recLabelInfo1 = new Rectangle(LabelInfo1.Location, LabelInfo1.Size);
            recJobNumberText = new Rectangle(JobNumberText.Location, JobNumberText.Size);
            recJobNameText = new Rectangle(JobNameText.Location, JobNameText.Size);
            recJobBuilderText = new Rectangle(JobBuilderText.Location, JobBuilderText.Size);
            recJobDescription = new Rectangle(JobDescription.Location, JobDescription.Size);
            recJobDesignerText = new Rectangle(JobDesignerText.Location, JobDesignerText.Size);
            recJobPostCodeText = new Rectangle(JobPostCodeText.Location, JobPostCodeText.Size);
            recJobInfo1 = new Rectangle(JobInfo1.Location, JobInfo1.Size);
            recCreatePadFootingButton = new Rectangle(CreatePadFootingButton.Location, CreatePadFootingButton.Size);
            recComboBox1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            recLabelOption = new Rectangle(LabelOption.Location, LabelOption.Size);
            recInsertJobDescriptionButton = new Rectangle(InsertJobDescriptionButton.Location, InsertJobDescriptionButton.Size);
            recGridInsertButton = new Rectangle(GridInsertButton.Location, GridInsertButton.Size);
            #endregion some other rectangular declarations for resizing


            //base.InitializeForm();
            #region new Model connection
            MyModel = new Model();

            if (MyModel.GetConnectionStatus())
            {

                MessageBox.Show("Successfully connected to Tekla Structures model.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Could not connect to Tekla Structures model.\nPlease Check Tekla is insstalled in the correct path: \nC>Program files>Tekla Structures>Version> \nAnd have access to >Bin> folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            #endregion

            #region Validation () - only numbers in numbered fields 
            SpacingXInput.KeyPress += SpacingXInput_KeyPress;
            SpacingYInput.KeyPress += SpacingYInput_KeyPress;
            NumPadsXInput.KeyPress += NumPadsXInput_KeyPress;
            NumPadsYInput.KeyPress += NumPadsYInput_KeyPress;
            HeightInput.KeyPress += HeightInput_KeyPress;
            #endregion KeyPress=only numbers validation

            #region Here are the options of the canopies

            comboBox1.Items.Add("Option 1");
            comboBox1.Items.Add("Option 2");
            //default option selected 1 with index 0 
            comboBox1.SelectedIndex = 0;
            // Initialize the dictionary
            optionActions = new Dictionary<string, Action>
                    {
                        { "Option 1", ExecuteOption1 },
                        { "Option 2", ExecuteOption2 }
                    };
            #endregion


            #region Declare xsFirmPath or modelFolder

            // Add .clm files to the ComboBox
            //MessageBox.Show($"XS_FIRM Path: {xsFirmPath}");
            //MessageBox.Show($"XS_FIRM Path: {modelFolder}");
            //string clmDirectory = @"C:\TeklaStructuresModels\New model 2\attributes";


            string xsFirmPath = "";
            TeklaStructuresSettings.GetAdvancedOption("XS_FIRM", ref xsFirmPath);
            
            string clmDirectory;
            if (string.IsNullOrWhiteSpace(xsFirmPath))
            {
                string modelFolder = MyModel.GetInfo().ModelPath;
                clmDirectory = Path.Combine(modelFolder, "attributes");

                MessageBox.Show("Using model folder attributes path.");
            }
            else
            {
                clmDirectory = xsFirmPath;
            }

            if (Directory.Exists(clmDirectory))
            {
                try
                {
                    string[] allFiles = Directory.GetFiles(clmDirectory);
                    foreach (string file in allFiles)
                    {
                        string fileName = Path.GetFileName(file);
                        if (file.EndsWith(".clm"))
                        {
                            LoadColumnSettings.Items.Add(Path.GetFileNameWithoutExtension(fileName));
                        }
                        else if (file.EndsWith(".prt"))
                        {
                            LoadBeamSettings.Items.Add(Path.GetFileNameWithoutExtension(fileName));
                        }
                    }

                    if (LoadColumnSettings.Items.Count > 0)
                    {
                        LoadColumnSettings.SelectedIndex = 0;
                    }
                    if (LoadBeamSettings.Items.Count > 0)
                    {
                        LoadBeamSettings.SelectedIndex = 0;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accessing files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Directory not found: {clmDirectory}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            #endregion

            // Set the background color of the form 

            this.BackColor = System.Drawing.Color.FromArgb(29, 36, 57);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // message all loaded 
            MessageBox.Show("All loaded");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadColumnSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Form1_Resize

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(LabelSpacingX, recLabelSpacingX);
            resize_Control(LabelSpacingY, recLabelSpacingY);
            resize_Control(LabelNumberPadsX, recLabelNumPadsX);
            resize_Control(LabelNumberPadsY, recLabelNumPadsY);
            resize_Control(LabelHeight, recLabelHeight);
            resize_Control(SpacingXInput, recSpacingXInput);
            resize_Control(SpacingYInput, recSpacingYInput);
            resize_Control(NumPadsXInput, recNumPadsXInput);
            resize_Control(NumPadsYInput, recNumPadsYInput);
            resize_Control(HeightInput, recHeightInput);
            resize_Control(ColumnSettingsLabel, recColumnSettingsLabel);
            resize_Control(BeamSettingsLabel, recBeamSettingsLabel);
            resize_Control(LoadColumnSettings, recLoadColumnSettings);
            resize_Control(LoadBeamSettings, recLoadBeamSettings);
            resize_Control(LabelJobNumber, recLabelJobNumber);
            resize_Control(LabelJobName, recLabelJobName);
            resize_Control(LabelJobBuilder, recLabelJobBuilder);
            resize_Control(LabelJobDescription, recLabelJobDescription);
            resize_Control(LabelJobDesigner, recLabelJobDesigner);
            resize_Control(PostcodeLabel, recPostcodeLabel);
            resize_Control(LabelInfo1, recLabelInfo1);
            resize_Control(JobNumberText, recJobNumberText);
            resize_Control(JobNameText, recJobNameText);
            resize_Control(JobBuilderText, recJobBuilderText);
            resize_Control(JobDescription, recJobDescription);
            resize_Control(JobDesignerText, recJobDesignerText);
            resize_Control(JobPostCodeText, recJobPostCodeText);
            resize_Control(JobInfo1, recJobInfo1);
            resize_Control(CreatePadFootingButton, recCreatePadFootingButton);
            resize_Control(comboBox1, recComboBox1);
            resize_Control(LabelOption, recLabelOption);
            resize_Control(InsertJobDescriptionButton, recInsertJobDescriptionButton);
            resize_Control(GridInsertButton, recGridInsertButton);




        }

        private void resize_Control(Control control, Rectangle rec)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            control.Left = (int)(rec.Left * xRatio);
            control.Top = (int)(rec.Top * yRatio);
            control.Width = (int)(rec.Width * xRatio);
            control.Height = (int)(rec.Height * yRatio);
            control.Location = new System.Drawing.Point(control.Left, control.Top);
            int newWidth = (int)(rec.Width * xRatio);
            int newHeight = (int)(rec.Height * yRatio);
            control.Size = new Size(newWidth, newHeight);
        }

        #endregion Form1_Resize

        #region Validations for the inputs in the form for numbers only

        private void SpacingXInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SpacingYInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumPadsXInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumPadsYInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        private bool ValidateInputs()
        {
            var inputControls = new (System.Windows.Forms.TextBox, string)[]
            {
        (SpacingXInput, "Spacing X"),
        (SpacingYInput, "Spacing Y"),
        (NumPadsXInput, "Number of Pads X"),
        (NumPadsYInput, "Number of Pads Y"),
        (HeightInput, "Height"),
             };

            foreach (var (input, name) in inputControls)
            {
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    MessageBox.Show($"Please insert a value for {name}.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        #endregion Validations for the inputs in the form for numbers only

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Optional: Handle any immediate actions when selection changes
        //}
        private void Execute_OnButtonclick(object sender, EventArgs e)
        {
            // Get the selected item ?? means option 1 is selected by default
            string selectedOption = comboBox1.SelectedItem?.ToString() ?? "Option 1";

            // Execute the corresponding action
            if (optionActions.ContainsKey(selectedOption))
            {
                optionActions[selectedOption].Invoke();
            }
        }

        #region ExecuteOption1&2
        #region Execute Option 1

        private void ExecuteOption1()
        {
            // Do something for Option 1
            if (MyModel.GetConnectionStatus())
            {
                if (!ValidateInputs())
                {
                    return;
                }
                double spacingX = double.Parse(SpacingXInput.Text);
                double spacingY = double.Parse(SpacingYInput.Text);
                int numPadsX = int.Parse(NumPadsXInput.Text);
                int numPadsY = int.Parse(NumPadsYInput.Text);
                double height = double.Parse(HeightInput.Text);

                for (int x = 0; x < numPadsX; x++)
                {
                    double PositionX = x * spacingX;
                    if (x == 0 || x == numPadsX - 1)
                    {
                        for (int y = 0; y < numPadsY; y++)
                        {
                            double PositionY = y * spacingY;
                            CreatePadFooting(PositionX, PositionY);
                            CreateColumn(PositionX, PositionY, height);

                            if (numPadsY != 2) // Create beams along Y direction if numPadsY != 2
                            {
                                if (x == 0 && y < numPadsY - 1)
                                {
                                    CreateBeam(PositionX, PositionY, PositionX, PositionY + spacingY, height);
                                }
                                else if (x == numPadsX - 1 && y > 0)
                                {
                                    CreateBeam(PositionX, PositionY, PositionX, PositionY - spacingY, height);
                                }
                            }
                        }
                    }
                    else
                    {
                        CreatePadFooting(PositionX, 0.0);
                        CreatePadFooting(PositionX, (numPadsY - 1) * spacingY);
                        CreateColumn(PositionX, 0.0, height);
                        CreateColumn(PositionX, (numPadsY - 1) * spacingY, height);

                        // Create beams along X direction if numPadsX > 2
                        if (x < numPadsX - 1 && numPadsX != 2)
                        {
                            CreateBeam(PositionX, 0.0, PositionX + spacingX, 0.0, height);
                            CreateBeam(PositionX, (numPadsY - 1) * spacingY, PositionX + spacingX, (numPadsY - 1) * spacingY, height);
                        }
                    }
                }

                // Special case for the first beam if numPadsX > 2
                if (numPadsX != 2)
                {
                    // Create the missing beam from 0,0 to the first spacing along X direction
                    CreateBeam(0.0, 0.0, spacingX, 0.0, height);

                    // Extend the first beams negatively by -140mm along X direction
                    ExtendBeamEnd(-140.0, 0.0, 0.0, 0.0, height);
                    ExtendBeamEnd(-140.0, (numPadsY - 1) * spacingY, 0.0, (numPadsY - 1) * spacingY, height);

                    // Special case for the last beam
                    CreateBeam(0.0, (numPadsY - 1) * spacingY, spacingX, (numPadsY - 1) * spacingY, height);
                }

                // Extend the very last beams along Y direction by 140mm if numPadsY > 2
                if (numPadsY > 2)
                {
                    ExtendBeamEnd((numPadsX - 1) * spacingX, (numPadsY - 1) * spacingY, (numPadsX - 1) * spacingX, (numPadsY - 1) * spacingY + 140.0, height);
                    ExtendBeamEnd(0.0, (numPadsY - 1) * spacingY, 0.0, (numPadsY - 1) * spacingY + 140.0, height);
                }

                // Extend the very last beams along X direction by 140mm if numPadsX > 2
                if (numPadsX > 2)
                {
                    ExtendBeamEnd((numPadsX - 1) * spacingX, 0.0, (numPadsX - 1) * spacingX + 140.0, 0.0, height);
                    ExtendBeamEnd((numPadsX - 1) * spacingX, (numPadsY - 1) * spacingY, (numPadsX - 1) * spacingX + 140.0, (numPadsY - 1) * spacingY, height);
                }

                MyModel.CommitChanges();
            }
        }

        #endregion
        // Function to extend an existing beam
        private void ExtendBeamEnd(double startX, double startY, double endX, double endY, double height)
        {
            // Extend the existing beam by adjusting its end point
            CreateBeam(startX, startY, endX, endY, height);
        }



        private void ExecuteOption2()
        {
            // Do something for Option 2
            if (MyModel.GetConnectionStatus())
            {
                if (!ValidateInputs())
                {
                    return;
                }
                double spacingX = double.Parse(SpacingXInput.Text);
                double spacingY = double.Parse(SpacingYInput.Text);
                int numPadsX = int.Parse(NumPadsXInput.Text);
                int numPadsY = int.Parse(NumPadsYInput.Text);
                double height = double.Parse(HeightInput.Text);
                for (int i = 0; i < numPadsX; i++)
                {
                    double PositionX = i * spacingX;
                    for (int j = 0; j < numPadsY; j++)
                    {
                        double PositionY = j * spacingY;
                        CreatePadFooting(PositionX, PositionY);
                        CreateColumn(PositionX, PositionY, height);
                        // Create beams along Y direction between columns
                        if (j < numPadsY - 1)
                        {
                            CreateBeam(PositionX, PositionY, PositionX, PositionY + spacingY, height);
                        }
                        // Create beams along X direction between columns
                        if (i < numPadsX - 1)
                        {
                            CreateBeam(PositionX, PositionY, PositionX + spacingX, PositionY, height);
                        }
                    }
                }
                MyModel.CommitChanges();
            }
        }

        #endregion ExecuteOption1&2 

        #region CreatePadFooting, CreateColumn, CreateBeam
        private static void CreatePadFooting(double PositionX, double PositionY)
        {

            Beam PadFooting1 = new Beam
            {
                Name = "PAD-FOOTING",
                Profile = { ProfileString = "1000*1000" },
                Material = { MaterialString = "C25" },
                Class = "8",
                StartPoint = { X = PositionX, Y = PositionY, Z = -200.0 },
                EndPoint = { X = PositionX, Y = PositionY, Z = -1000.0 },
                Position = { Rotation = Position.RotationEnum.FRONT, Plane = Position.PlaneEnum.MIDDLE, Depth = Position.DepthEnum.MIDDLE }
            };
            PadFooting1.Insert();
        }

        private static void CreateColumn(double PositionX, double PositionY, double PositionZ)
        {
            //string colclass = $"{i}";
            Beam Column = new Beam
            {
                Name = "COLUMN",
                Profile = { ProfileString = "CHS139.7*5.0" },
                Material = { MaterialString = "S235JR" },
                Class = "1",
                StartPoint = { X = PositionX, Y = PositionY, Z = -200.0 },
                EndPoint = { X = PositionX, Y = PositionY, Z = PositionZ },
                Position = { Rotation = Position.RotationEnum.FRONT, Plane = Position.PlaneEnum.MIDDLE, Depth = Position.DepthEnum.MIDDLE }
            };
            Column.Insert();
        }
        private static void CreateBeam(double startX, double startY, double endX, double endY, double height)
        {
            Beam Beam = new Beam
            {
                Name = "BEAM",
                Profile = { ProfileString = "SHS100*100*5.0" },
                Material = { MaterialString = "S235JR" },
                Class = "3",
                StartPoint = { X = startX, Y = startY, Z = height },
                EndPoint = { X = endX, Y = endY, Z = height },
                Position = { Rotation = Position.RotationEnum.TOP, Plane = Position.PlaneEnum.MIDDLE, Depth = Position.DepthEnum.MIDDLE }
            };
            Beam.Insert();
        }

        #endregion  CreatePadFooting, CreateColumn, CreateBeam

  

        private void InsertJobDescription(object sender, EventArgs e)
        {
            if (MyModel.GetConnectionStatus())
            {
                ProjectInfo myPI = MyModel.GetProjectInfo();

                myPI.ProjectNumber = JobNumberText.Text;
                myPI.Name = JobNameText.Text;
                myPI.Builder = JobBuilderText.Text;
                myPI.Object = JobDescription.Text;
                myPI.Designer = JobDesignerText.Text;
                myPI.Location = JobPostCodeText.Text;
                myPI.Info1 = JobInfo1.Text;
                myPI.Modify();

            }
        }


        #region Find Grid ID, Delete Grid by ID
        private int FindGridID()
        {
            ModelObjectEnumerator modelObjects = MyModel.GetModelObjectSelector().GetAllObjects();

            while (modelObjects.MoveNext())
            {
                var modelObject = modelObjects.Current;
                if (modelObject is Grid gridObject)
                {
                    int gridId = gridObject.Identifier.ID;
                    MessageBox.Show($"Grid ID: {gridId}");
                    return gridId; // Return the first found grid ID
                }
            }

            MessageBox.Show("No grid found.");
            return 0; // Return -1 if no grid is found
        }

        private void DeleteGridByID(int gridID)
        {
            ModelObjectEnumerator modelObjects = MyModel.GetModelObjectSelector().GetAllObjects();

            while (modelObjects.MoveNext())
            {
                var modelObject = modelObjects.Current;
                if (modelObject is Grid gridObject && gridObject.Identifier.ID == gridID)
                {
                    gridObject.Delete();
                    MyModel.CommitChanges();
                    return;
                }
            }


        }

        #endregion

        private void GridInsertButton_Click(object sender, EventArgs e)
        {


            if (MyModel.GetConnectionStatus())
            {

                if (!ValidateInputs())
                {
                    return;
                }

                int gridID = FindGridID();
                if (gridID != 0)
                {
                    DeleteGridByID(gridID);
                }


                double spacingX = double.Parse(SpacingXInput.Text);
                double spacingY = double.Parse(SpacingYInput.Text);
                int numPadsX = int.Parse(NumPadsXInput.Text);
                int numPadsY = int.Parse(NumPadsYInput.Text);
                double height = 0; // Height is set to 0

                // Create the CoordinateX and CoordinateY strings using the variables
                string coordinateX = $"0.00 {numPadsX-1}*{spacingX:0.00}";
                string coordinateY = $"0.00 {numPadsY-1}*{spacingY:0.00}";
                string coordinateZ = $"-200 0 {height}"; // Adjusted CoordinateZ
                string labelX = string.Join(" ", Enumerable.Range(0, numPadsX).Select(i => ((char)('A' + i)).ToString()));
                string labelY = string.Join(" ", Enumerable.Range(1, numPadsY).Select(i => i.ToString()));

                Grid objGrid = new Grid
                {
                    Name = "Grid",
                    CoordinateX = coordinateX,
                    CoordinateY = coordinateY,
                    CoordinateZ = coordinateZ,
                    LabelX = labelX,
                    LabelY = labelY,
                    LabelZ = "+0 +6000 +8000 +9000", // Keeping LabelZ unchanged
                    ExtensionLeftX = 1000.0,
                    ExtensionLeftY = 1000.0,
                    ExtensionLeftZ = 1000.0,
                    ExtensionRightX = 1000.0,
                    ExtensionRightY = 1000.0,
                    ExtensionRightZ = 1000.0,
                    IsMagnetic = false
                };


                bool result = objGrid.Insert();
                MyModel.CommitChanges();
                MessageBox.Show($"Grid insert result: {result}");
            }

        }

    }
}